using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace Quiz_MDI_Application.Data.Access
{
    public abstract class DataAccess
    {
        private const string ConnectionString = Database.ConnectionString;

        protected DataAccess()
        {
            this.CreateTable();
            this.NextId = this.InitializeNextId();
        }

        protected int NextId { get; set; }

        protected void ExecuteInsertQuery(string tableName, Action<SqlCommand> paramAction, params string[] parameters)
        {
            string query = "INSERT INTO " + tableName + " VALUES("
                           + string.Join(", ", parameters.Select(param => "@" + param))
               + ");";

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

        protected ICollection<T> ExecuteSelectQuery<T>(string tableName, Func<SqlDataReader, T> mappingFunction)
        {
            ICollection<T> collection = new List<T>();

            string query = "SELECT * FROM " + tableName;

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        collection.Add(mappingFunction.Invoke(reader));
                    }
                }

                connection.Close();
            }

            return collection;
        }

        protected void ExecuteCreateTableQuery(string tableName, List<string> tableParameters)
        {
            string query = "CREATE TABLE " + tableName + "(" + string.Join(",", tableParameters) + ");";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.ExecuteNonQuery();
                    }
                    catch (Exception e)
                    {
                        if (e.Message != "There is already an object named \'" + tableName + "\' in the database.")
                        {
                            throw e;
                        }
                    }
                }

                connection.Close();
            }
        }

        protected abstract void CreateTable();

        protected abstract int InitializeNextId();
    }
}
