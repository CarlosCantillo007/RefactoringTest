using LegacyApp.Entities;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace LegacyApp
{
    public class ClientRepository
    {
        public Client GetById(int id)
        {
            try
            {
                Client client = null;

                using (var connection = new SqlConnection(Parameters.connectionString))
                {
                    var command = new SqlCommand
                    {
                        Connection = connection,
                        CommandType = CommandType.StoredProcedure,
                        CommandText = "uspGetClientById"
                    };

                    var parametr = new SqlParameter("@clientId", SqlDbType.Int) { Value = id };
                    command.Parameters.Add(parametr);

                    connection.Open();
                    var reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                    while (reader.Read())
                    {
                        client = new Client();
                        if(reader["ClientId"] != DBNull.Value)
                            client.Id = int.Parse(reader["ClientId"].ToString());

                        if (reader["Name"] != DBNull.Value)
                            client.Name = reader["Name"].ToString();

                        if (reader["ClientStatus"] != DBNull.Value)
                            client.ClientStatus = (ClientStatus)int.Parse(reader["ClientStatus"].ToString());
                    }
                }

                return client;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}