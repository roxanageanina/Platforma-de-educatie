using Platforma_de_educatie.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Platforma_de_educatie.Repositories
{
    public class UserRepository : RepositoryBase, IUserRepository
    {
        public void Add(UserModel userModel)
        {
            using (var connection = GetConnection())
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"INSERT INTO Utilizatori 
                                        (Nume, Prenume, Username, Email, Parola, TipCont) 
                                        VALUES (@nume, @prenume, @username, @email, @parola, @tipCont)";
                command.Parameters.Add("@nume", SqlDbType.NVarChar).Value = userModel.Name;
                command.Parameters.Add("@prenume", SqlDbType.NVarChar).Value = userModel.LastName;
                command.Parameters.Add("@username", SqlDbType.NVarChar).Value = userModel.Username;
                command.Parameters.Add("@email", SqlDbType.NVarChar).Value = userModel.Email;
                command.Parameters.Add("@parola", SqlDbType.NVarChar).Value = userModel.Password;
                command.Parameters.Add("@tipCont", SqlDbType.NVarChar).Value = userModel.AccountType;

                command.ExecuteNonQuery();
            }
        }

        public bool AuthenticateUser(NetworkCredential credential)
        {
            bool validUser;
            using (var connection = GetConnection())
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT COUNT(1) FROM Utilizatori WHERE Username=@username AND Parola=@password";
                command.Parameters.Add("@username", SqlDbType.NVarChar).Value = credential.UserName;
                command.Parameters.Add("@password", SqlDbType.NVarChar).Value = credential.Password;

                validUser = (int)command.ExecuteScalar() > 0;
            }
            return validUser;
        }

        public void Edit(UserModel userModel)
        {
            using (var connection = GetConnection())
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"UPDATE Utilizatori 
                                        SET Nume=@nume, Prenume=@prenume, Username=@username, 
                                            Email=@email, Parola=@parola, TipCont=@tipCont 
                                        WHERE ID_Utilizator=@id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = userModel.Id;
                command.Parameters.Add("@nume", SqlDbType.NVarChar).Value = userModel.Name;
                command.Parameters.Add("@prenume", SqlDbType.NVarChar).Value = userModel.LastName;
                command.Parameters.Add("@username", SqlDbType.NVarChar).Value = userModel.Username;
                command.Parameters.Add("@email", SqlDbType.NVarChar).Value = userModel.Email;
                command.Parameters.Add("@parola", SqlDbType.NVarChar).Value = userModel.Password;
                command.Parameters.Add("@tipCont", SqlDbType.NVarChar).Value = userModel.AccountType;

                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<UserModel> GetByAll()
        {
            var users = new List<UserModel>();
            using (var connection = GetConnection())
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Utilizatori";

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        users.Add(new UserModel()
                        {
                            Id = reader["ID_Utilizator"].ToString(),
                            Name = reader["Nume"].ToString(),
                            LastName = reader["Prenume"].ToString(),
                            Username = reader["Username"].ToString(),
                            Email = reader["Email"].ToString(),
                            AccountType = reader["TipCont"].ToString(),
                            RegistrationDate = reader["DataInregistrare"].ToString()
                        });
                    }
                }
            }
            return users;
        }

        public UserModel GetById(int id)
        {
            UserModel user = null;
            using (var connection = GetConnection())
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Utilizatori WHERE ID_Utilizator=@id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;

                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        user = new UserModel()
                        {
                            Id = reader["ID_Utilizator"].ToString(),
                            Name = reader["Nume"].ToString(),
                            LastName = reader["Prenume"].ToString(),
                            Username = reader["Username"].ToString(),
                            Email = reader["Email"].ToString(),
                            AccountType = reader["TipCont"].ToString(),
                            RegistrationDate = reader["DataInregistrare"].ToString()
                        };
                    }
                }
            }
            return user;
        }

        public UserModel GetByUsername(string username)
        {
            UserModel user = null;
            using (var connection = GetConnection())
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Utilizatori WHERE Username=@username";
                command.Parameters.Add("@username", SqlDbType.NVarChar).Value = username;

                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        user = new UserModel()
                        {
                            Id = reader["ID_Utilizator"].ToString(),
                            Name = reader["Nume"].ToString(),
                            LastName = reader["Prenume"].ToString(),
                            Username = reader["Username"].ToString(),
                            Email = reader["Email"].ToString(),
                            AccountType = reader["TipCont"].ToString(),
                            RegistrationDate = reader["DataInregistrare"].ToString()
                        };
                    }
                }
            }
            return user;
        }

        public void Remove(int id)
        {
            using (var connection = GetConnection())
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "DELETE FROM Utilizatori WHERE ID_Utilizator=@id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;

                command.ExecuteNonQuery();
            }
        }
    }
}
