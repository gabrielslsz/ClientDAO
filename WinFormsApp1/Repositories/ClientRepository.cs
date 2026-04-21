using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Models;

namespace WinFormsApp1.Repositories
{
    public class ClientRepository
    {
        private readonly string _connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=winformdb;Integrated Security=True;Trust Server Certificate=True";


        public List<Client> GetClients()
        {
            var clients = new List<Client>();
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();

                    string sql = "SELECT * FROM clients ORDER BY id DESC";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Client client = new Client();
                                client.id = reader.GetInt32(0);
                                client.firstName = reader.IsDBNull(1) ? "" : reader.GetString(1);
                                client.lastName = reader.IsDBNull(2) ? "" : reader.GetString(2);
                                client.email = reader.IsDBNull(3) ? "" : reader.GetString(3);
                                client.phone = reader.IsDBNull(4) ? "" : reader.GetString(4);
                                client.address = reader.IsDBNull(5) ? "" : reader.GetString(5);
                                client.createdAt = reader.IsDBNull(6) ? "" : reader.GetDateTime(6).ToString("yyyy-MM-dd HH:mm:ss");
                                clients.Add(client);
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return clients;
        }
        public Client? GetClient(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    string sql = "SELECT * FROM clients WHERE id = @id";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            Client client = new Client();
                            client.id = reader.GetInt32(0);
                            client.firstName = reader.IsDBNull(1) ? "" : reader.GetString(1);
                            client.lastName = reader.IsDBNull(2) ? "" : reader.GetString(2);
                            client.email = reader.IsDBNull(3) ? "" : reader.GetString(3);
                            client.phone = reader.IsDBNull(4) ? "" : reader.GetString(4);
                            client.address = reader.IsDBNull(5) ? "" : reader.GetString(5);
                            client.createdAt = reader.IsDBNull(6) ? "" : reader.GetDateTime(6).ToString("yyyy-MM-dd HH:mm:ss");

                            return client;
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }

            return null;
        }

        public void CreateClient(Client client)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    string sql = "INSERT INTO clients (firstName, lastName, email, phone, address) VALUES (@firstName, @lastName, @email, @phone, @address)";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@firstName", client.firstName);
                        command.Parameters.AddWithValue("@lastName", client.lastName);
                        command.Parameters.AddWithValue("@email", client.email);
                        command.Parameters.AddWithValue("@phone", client.phone);
                        command.Parameters.AddWithValue("@address", client.address);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

            public void UpdateClient(Client client)
            {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    string sql = "UPDATE clients SET firstName = @firstName, lastName = @lastName, email = @email, phone = @phone, address = @address WHERE id = @id";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@firstName", client.firstName);
                        command.Parameters.AddWithValue("@lastName", client.lastName);
                        command.Parameters.AddWithValue("@email", client.email);
                        command.Parameters.AddWithValue("@phone", client.phone);
                        command.Parameters.AddWithValue("@address", client.address);
                        command.Parameters.AddWithValue("@id", client.id);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            }   
        public void DeleteClient(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    string sql = "DELETE FROM clients WHERE id = @id";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
