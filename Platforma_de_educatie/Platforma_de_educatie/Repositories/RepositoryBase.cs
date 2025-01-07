using System;
using Platforma_de_educatie.Data;

namespace Platforma_de_educatie.Repositories
{
    public abstract class RepositoryBase
    {
        protected DataClassesDataContext GetContext()
        {
            var context = new DataClassesDataContext();
            Console.WriteLine("Conexiunea cu baza de date s-a realizat cu succes!");
            return context;
        }
    }
}
