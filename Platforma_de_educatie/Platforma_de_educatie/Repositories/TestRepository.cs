using System;
using System.Collections.Generic;
using System.Linq;
using Platforma_de_educatie.Models;
using Platforma_de_educatie.Data;

namespace Platforma_de_educatie.Repositories
{
    public class TestRepository : RepositoryBase
    {
        public List<TestModel> GetAvailableTests()
        {
            using (var context = new DataClassesDataContext())
            {
                return context.Testes.Select(t => new TestModel
                {
                    ID_Test = t.ID_Test,
                    NumeTest = t.NumeTest,
                    ID_Materie = t.ID_Materie ?? 0, // Tratare pentru valori nullable
                    Autor = t.Autor ?? 0,           // Tratare pentru valori nullable
                    DataCreare = t.DataCreare ?? new DateTime(1753, 1, 1) // Valoare default pentru SQL Server
                }).ToList();
            }
        }


        public List<QuestionModel> GetQuestionsByTestId(int testId)
        {
            using (var context = new DataClassesDataContext())
            {
                return context.Intrebaris
                    .Where(q => q.ID_Test == testId)
                    .Select(q => new QuestionModel
                    {
                        ID_Intrebare = q.ID_Intrebare,
                        TextIntrebare = q.TextIntrebare,
                        Punctaj = (float)(q.Punctaj ?? 0), 
                        Raspunsuri = GetAnswersByQuestionId(q.ID_Intrebare)
                    }).ToList();
            }
        }

        private List<AnswearModel> GetAnswersByQuestionId(int questionId)
        {
            using (var context = new DataClassesDataContext())
            {
                return context.Raspunsuris
                    .Where(a => a.ID_Intrebare == questionId)
                    .Select(a => new AnswearModel
                    {
                        ID_Raspuns = a.ID_Raspuns,
                        TextRaspuns = a.TextRaspuns,
                        EsteCorect = a.EsteCorect
                    }).ToList();
            }
        }
    }
}

