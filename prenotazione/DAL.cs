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
        public static void insertPerson(Person p)
        {/*correggere la insert con riferimento al DB corretto,*/

            string connectionString = WebConfigurationManager.ConnectionStrings["MainDB"].ConnectionString;
            string query = "insert into [dbo].[Persons] values (newid(), @username, @password, @nome, @cognome, @eta, getdate(),0)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@name", p.name);
                    command.Parameters.AddWithValue("@cognome", p.surname);
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
        }

        public static bool Login(string pass) /*Verifica che la mail non sia gia inserita*/
        {
            bool validuser = false;
            string connectionString = WebConfigurationManager.ConnectionStrings["MainDB"].ConnectionString;
            string query = "SELECT [ID] FROM [dbo].[Persons] WHERE [Password]=@pass";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    DataTable dt = new DataTable();
                    SqlCommand command = new SqlCommand(query, connection);
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