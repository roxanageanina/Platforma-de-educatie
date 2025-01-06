using System;

namespace Platforma_de_educatie.Models
{
    public class TestModel
    {
        public int ID_Test { get; set; }
        public string NumeTest { get; set; }
        public int ID_Materie { get; set; }
        public int Autor { get; set; }
        public DateTime DataCreare { get; set; }
        public TestModel() { }
        public TestModel(int idTest, string numeTest, int idMaterie, int autor, DateTime dataCreare)
        {
            ID_Test = idTest;
            NumeTest = numeTest;
            ID_Materie = idMaterie;
            Autor = autor;
            DataCreare = dataCreare;
        }
        public override string ToString()
        {
            return $"{NumeTest} - {DataCreare:yyyy-MM-dd}";
        }
    }
}
