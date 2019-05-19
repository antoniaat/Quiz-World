using Quiz_MDI_Application.Models;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Quiz_MDI_Application.Data
{
    public class UserDataAccess : DataAccess
    {
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
                    Role = (UserRole)System.Enum.Parse(typeof(UserRole), role)
                };
            });
        }
    }
}
