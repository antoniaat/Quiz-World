using Quiz_MDI_Application.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_MDI_Application.Data
{
    public class DataAccess
    {
        private const string ConnectionString = "Server=DESKTOP-8LNSVN2\\MSSQLSERVER01;Database=QuizMDI;Integrated Security=False;Trusted_Connection=True;";

        private void ExecuteInsertQuery(string query, Action<SqlCommand> paramAction, params string[] parameters)
        {
            query = query.Replace("@params@", string.Join(", ", parameters.Select(param => "@" + param)));

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    paramAction.Invoke(command);
                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
        }

        private ICollection<T> ExecuteSelectQuery<T>(string query, Func<SqlDataReader, T> mappingFunction)
        {
            ICollection<T> collection = new List<T>();

            using(SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();

                    while(reader.Read())
                    {
                        collection.Add(mappingFunction.Invoke(reader));
                    }
                }

                connection.Close();
            }

            return collection;
        }

        public void CreateUser(User user)
        {
            this.ExecuteInsertQuery("INSERT INTO Users VALUES(@params@)", (command) =>
            {
                command.Parameters.Add(new SqlParameter("Id", user.Id));
                command.Parameters.Add(new SqlParameter("Username", user.Username));
                command.Parameters.Add(new SqlParameter("Password", user.Password));
                command.Parameters.Add(new SqlParameter("Role", user.Role.ToString()));
            }, "Id", "Username", "Password", "Role");
        }

        public ICollection<User> ReadUsers()
        {
            return this.ExecuteSelectQuery("SELECT * FROM Users", (reader) =>
            {
                int id = reader.GetInt32(0);
                string username = reader.GetString(1);
                string password = reader.GetString(2);
                string role = reader.GetString(3);

                return new User
                {
                    Id = id,
                    Username = username,
                    Password = password,
                    Role = (UserRole)Enum.Parse(typeof(UserRole), role)
                };
            });
        }

    }
}
