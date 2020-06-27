using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace prenotazione
{
	public class DAL
	{
        public static string ID = null;
        public static string userlogged = null;
        public static void insertUser(Person p)
        {/*correggere la insert con riferimento al DB corretto,*/

            string connectionString = WebConfigurationManager.ConnectionStrings["MainDB"].ConnectionString;
            string query = "insert into [dbo].[account] values (newid(), @name, @surname, @tel, @email, @pass)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@name", p.name);
                    command.Parameters.AddWithValue("@surname", p.surname);
                    command.Parameters.AddWithValue("@email", p.email);
                    command.Parameters.AddWithValue("@tel", p.tel);
                    command.Parameters.AddWithValue("@pass", p.pass);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {

                }
                finally
                {
                    connection.Close();
                }
            }
        } /*Permette di registrare nuovo utente*/

        public static bool checkMail(string mail) /*Verifica che la mail non sia gia inserita*/
        {
            bool validuser = false;
            string connectionString = WebConfigurationManager.ConnectionStrings["MainDB"].ConnectionString;
            string query = "SELECT [mail] FROM [dbo].[account] WHERE [mail]=@mail";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    DataTable dt = new DataTable();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@mail", mail);
                    connection.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter(command))
                    { da.Fill(dt); }
                    if (dt.Rows.Count == 1)

                        validuser = true;

                }
                catch (Exception ex)
                {

                }
                finally
                {
                    connection.Close();
                }
            }
            return validuser;
        }

        public static bool Login(string mail, string pass)
        {
            bool validuser = false;
            string connectionString = WebConfigurationManager.ConnectionStrings["MainDB"].ConnectionString;
            string query = "SELECT [ID], [name], [surname] FROM [dbo].[account] WHERE [mail]=@mail AND [Pass]=@pass";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    DataTable dt = new DataTable();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@mail", mail);
                    command.Parameters.AddWithValue("@pass", pass);
                    connection.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter(command))
                    { da.Fill(dt); }
                    if (dt.Rows.Count == 1)
                    {
                        validuser = true;
                        foreach (DataRow row in dt.Rows)
                        {
                            ID = row["ID"].ToString();
                            userlogged = row["name"].ToString() + " " + row["surname"].ToString();
                             }
                    }


                }
                catch (Exception ex)
                {

                }
                finally
                {
                    connection.Close();
                }
            }
            return validuser;
        } /*effettua la log-in e se confermata restituisce ID*/

        public static void insertBooking(Booking b)
        {
            string connectionString = WebConfigurationManager.ConnectionStrings["MainDB"].ConnectionString;
            string query = "insert into [dbo].[Prenotazioni] values (newid(),@IDUtente, @DataPrenotazione, @prenotati)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@IDUtente", b.ID);
                    command.Parameters.AddWithValue("@DataPrenotazione", b.dataPrenotazione);
                                      
                    command.Parameters.AddWithValue("@prenotati", b.prenotati);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {

                }
                finally
                {
                    connection.Close();
                }
            }
        } /*inserisce una nuova prenotazione*/

        
        public static List<Booking> getAllBooking(Guid ID)
        {
            List<Booking> booking = new List<Booking>();
            string connectionString = WebConfigurationManager.ConnectionStrings["MainDB"].ConnectionString;
            string query = "SELECT [DataPrenotazione],[prenotati],[ID_prenotazione] FROM [dbo].[prenotazioni] WHERE [IDUtente]=@id order by DataPrenotazione";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    DataTable dt = new DataTable();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id", ID);
                    connection.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter(command))
                    {
                        da.Fill(dt);
                    }
                    foreach (DataRow row in dt.Rows)
                    {
                        Booking b = new Booking();
                        b.dataPrenotazione = DateTime.Parse(row["DataPrenotazione"].ToString());
                        b.prenotati = int.Parse(row["prenotati"].ToString());
                    b.id_prenotazione = Guid.Parse(row["ID_prenotazione"].ToString());
                       booking.Add(b);
                    }
                }
                catch (Exception ex)
                {

                }
                finally
                {
                    connection.Close();
                }
            }
            return booking;
        }

        public static void Delete(Guid ID)
        {
            string connectionString = WebConfigurationManager.ConnectionStrings["MainDB"].ConnectionString;
            string query = "Delete [dbo].[prenotazioni] WHERE [ID_prenotazione]=@id";
            using (SqlConnection connection = new SqlConnection(connectionString))

                try
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id", ID.ToString());
                    connection.Open();
                    command.ExecuteNonQuery();

                }
                catch (Exception ex) { }
                finally { connection.Close(); }
        }
    }
}