using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace FinalProject
{
    class Client : User
    {
        public Client()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="role"></param>
        public void SignUp(string username, string password, string role)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\le2178404\Documents\FinalProject\FinalProject\Users.mdf;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string query = "INSERT INTO [User](Username, Password, Role) " + "values('"+username+"', '"+password+"', '"+role+"')";

            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.InsertCommand = new SqlCommand(query, connection);
            adapter.InsertCommand.ExecuteNonQuery();
            cmd.Dispose();
            connection.Close();

        }
    }
}
