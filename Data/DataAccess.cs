using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace Quiz_MDI_Application.Data
{
    public class DataAccess
    {
        private const string ConnectionString = "Server=DESKTOP-8LNSVN2\\MSSQLSERVER01;Database=QuizMDI;Integrated Security=False;Trusted_Connection=True;";

        protected void ExecuteInsertQuery(string query, Action<SqlCommand> paramAction, params string[] parameters)
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

        protected ICollection<T> ExecuteSelectQuery<T>(string query, Func<SqlDataReader, T> mappingFunction)
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
    }
}
