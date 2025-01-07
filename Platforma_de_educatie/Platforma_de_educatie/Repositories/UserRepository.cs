using Platforma_de_educatie.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Platforma_de_educatie.Data;

namespace Platforma_de_educatie.Repositories
{
    public class UserRepository : RepositoryBase, IUserRepository
    {
        public void Add(UserModel userModel)
        {
            using (var context = new DataClassesDataContext())
            {
                var utilizator = new Utilizatori
                {
                    Nume = userModel.Name,
                    Prenume = userModel.LastName,
                    Username = userModel.Username,
                    Email = userModel.Email,
                    Parola = userModel.Password,
                    TipCont = userModel.AccountType
                };

                context.Utilizatoris.InsertOnSubmit(utilizator);
                context.SubmitChanges();
            }
        }

        public bool AuthenticateUser(NetworkCredential credential)
        {
            using (var context = new DataClassesDataContext())
            {
                return context.Utilizatoris.Any(u => u.Username == credential.UserName && u.Parola == credential.Password);
            }
        }

        public void Edit(UserModel userModel)
        {
            using (var context = new DataClassesDataContext())
            {
                var utilizator = context.Utilizatoris.FirstOrDefault(u => u.ID_Utilizator == userModel.Id);

                if (utilizator != null)
                {
                    utilizator.Nume = userModel.Name;
                    utilizator.Prenume = userModel.LastName;
                    utilizator.Username = userModel.Username;
                    utilizator.Email = userModel.Email;
                    utilizator.Parola = userModel.Password;
                    utilizator.TipCont = userModel.AccountType;

                    context.SubmitChanges();
                }
            }
        }

        public IEnumerable<UserModel> GetByAll()
        {
            using (var context = new DataClassesDataContext())
            {
                return context.Utilizatoris.Select(u => new UserModel
                {
                    Id = u.ID_Utilizator,
                    Name = u.Nume,
                    LastName = u.Prenume,
                    Username = u.Username,
                    Email = u.Email,
                    AccountType = u.TipCont,
                    RegistrationDate = u.DataInregistrare.ToString()
                }).ToList();
            }
        }

        public UserModel GetById(int id)
        {
            using (var context = new DataClassesDataContext())
            {
                var utilizator = context.Utilizatoris.FirstOrDefault(u => u.ID_Utilizator == id);
                return utilizator == null ? null : new UserModel
                {
                    Id = utilizator.ID_Utilizator,
                    Name = utilizator.Nume,
                    LastName = utilizator.Prenume,
                    Username = utilizator.Username,
                    Email = utilizator.Email,
                    AccountType = utilizator.TipCont,
                    RegistrationDate = utilizator.DataInregistrare.ToString()
                };
            }
        }

        public UserModel GetByUsername(string username)
        {
            using (var context = new DataClassesDataContext())
            {
                var utilizator = context.Utilizatoris.FirstOrDefault(u => u.Username == username);
                return utilizator == null ? null : new UserModel
                {
                    Id = utilizator.ID_Utilizator,
                    Name = utilizator.Nume,
                    LastName = utilizator.Prenume,
                    Username = utilizator.Username,
                    Email = utilizator.Email,
                    AccountType = utilizator.TipCont,
                    RegistrationDate = utilizator.DataInregistrare.ToString()
                };
            }
        }

        public void Remove(int id)
        {
            using (var context = new DataClassesDataContext())
            {
                var utilizator = context.Utilizatoris.FirstOrDefault(u => u.ID_Utilizator == id);
                if (utilizator != null)
                {
                    context.Utilizatoris.DeleteOnSubmit(utilizator);
                    context.SubmitChanges();
                }
            }
        }
    }
}
