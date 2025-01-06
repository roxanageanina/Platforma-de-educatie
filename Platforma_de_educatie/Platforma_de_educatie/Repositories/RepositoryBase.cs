using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Platforma_de_educatie.Repositories
{
    public abstract class RepositoryBase
    {
        private readonly string _connectionString;
        public RepositoryBase()
        {
            _connectionString = "Server=DESKTOP-TORV8IU\\SQLEXPRESS; Database=EducatieStiinteNaturale; Integrated Security=true";
        }
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
            Console.WriteLine("Conexiunea cu baza de date s-a realizat cu succes!");
        }
    }
}
