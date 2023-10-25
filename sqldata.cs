using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace InventoryManagementSystem
{
    public class sqldata
    {
        /*
            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = conn.query<
            }
         */
        public static void UpdateAcc(User useracc)
        {
            using (IDbConnection conn = new SQLiteConnection(LoadConnectionString()))
            {
                conn.Execute("insert into User (name, email, phoneNumber, password) values (@name, @email, @phoneNumber, @password)", useracc);
                MessageBox.Show("success");
            }
        }

        public static bool ValidateUser(User useracc)
        {
            using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM User WHERE name = @username AND password = @password";
                using (IDbCommand command = connection.CreateCommand())
                {
                    command.CommandText = query;

                    IDbDataParameter usernameParam = command.CreateParameter();
                    usernameParam.ParameterName = "@username";
                    usernameParam.Value = useracc.name;
                    command.Parameters.Add(usernameParam);

                    IDbDataParameter passwordParam = command.CreateParameter();
                    passwordParam.ParameterName = "@password";
                    passwordParam.Value = useracc.password;
                    command.Parameters.Add(passwordParam);

                    int count = Convert.ToInt32(command.ExecuteScalar());

                    // If count is 1, nay acc
                    return count == 1;
                }
            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }

}
