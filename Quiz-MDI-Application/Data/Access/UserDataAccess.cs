using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Quiz_MDI_Application.Models;

namespace Quiz_MDI_Application.Data.Access
{
    public class UserDataAccess : DataAccess
    {
        public UserDataAccess() : base()
        {
        }

        public void CreateUser(User user)
        {
            this.ExecuteInsertQuery("Users", (command) =>
            {
                command.Parameters.Add(new SqlParameter("Id", this.NextId++));
                command.Parameters.Add(new SqlParameter("Username", user.Username));
                command.Parameters.Add(new SqlParameter("Password", user.Password));
                command.Parameters.Add(new SqlParameter("Role", user.Role.ToString()));
            }, "Id", "Username", "Password", "Role");
        }

        public ICollection<User> ReadUsers()
        {
            return this.ExecuteSelectQuery("Users", (reader) =>
            {
                int id = reader.GetInt32(0);
                string username = reader.GetString(1);
                string password = reader.GetString(2);
                string role = reader.GetString(3);

                User user = new User
                {
                    Id = id,
                    Username = username,
                    Password = password,
                    Role = (UserRole) Enum.Parse(typeof(UserRole), role)
                };

                return user;
            });
        }

        protected override void CreateTable()
        {
            List<string> parameters = new List<string>();

            parameters.Add("Id INT");
            parameters.Add("Username VARCHAR(255)");
            parameters.Add("Password VARCHAR(255)");
            parameters.Add("Role VARCHAR(255)");
            parameters.Add("CONSTRAINT PK_USERS PRIMARY KEY (Id)");
            
            this.ExecuteCreateTableQuery("Users", parameters);
        }

        protected override int InitializeNextId()
        {
            ICollection<User> users = this.ReadUsers();

            return users.Any() ? users.Max(user => user.Id) + 1: 1;
        }
    }
}
