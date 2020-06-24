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
            string query = "SELECT [ID] FROM [dbo].[account] WHERE [mail]=@mail AND [Pass]=@pass";
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
    }
}