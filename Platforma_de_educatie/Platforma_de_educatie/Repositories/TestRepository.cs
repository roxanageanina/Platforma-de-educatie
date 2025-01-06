using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Platforma_de_educatie.Models;

namespace Platforma_de_educatie.Repositories
{
    public class TestRepository : RepositoryBase
    {
        public List<TestModel> GetAvailableTests()
        {
            var tests = new List<TestModel>();
            using (var connection = GetConnection())
            using (var command = new SqlCommand("SELECT * FROM Teste", connection))
            {
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        tests.Add(new TestModel
                        {
                            ID_Test = (int)reader["ID_Test"],
                            NumeTest = reader["NumeTest"].ToString(),
                            ID_Materie = (int)reader["ID_Materie"],
                            Autor = (int)reader["Autor"],
                            DataCreare = (DateTime)reader["DataCreare"]
                        });
                    }
                }
            }
            return tests;
        }

        public List<QuestionModel> GetQuestionsByTestId(int testId)
        {
            var questions = new List<QuestionModel>();
            using (var connection = GetConnection())
            using (var command = new SqlCommand("SELECT * FROM Intrebari WHERE ID_Test = @testId", connection))
            {
                command.Parameters.AddWithValue("@testId", testId);
                connection.Open();

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var intrebare = new QuestionModel
                        {
                            ID_Intrebare = (int)reader["ID_Intrebare"],
                            TextIntrebare = reader["TextIntrebare"].ToString(),
                            Punctaj = (float)reader["Punctaj"],
                            Raspunsuri = GetAnswersByQuestionId((int)reader["ID_Intrebare"]) // Obține răspunsurile întrebării
                        };
                        questions.Add(intrebare);
                    }
                }
            }
            return questions;
        }

        private List<AnswearModel> GetAnswersByQuestionId(int questionId)
        {
            var answers = new List<AnswearModel>();
            using (var connection = GetConnection())
            using (var command = new SqlCommand("SELECT * FROM Raspunsuri WHERE ID_Intrebare = @questionId", connection))
            {
                command.Parameters.AddWithValue("@questionId", questionId);
                connection.Open();

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        answers.Add(new AnswearModel
                        {
                            ID_Raspuns = (int)reader["ID_Raspuns"],
                            TextRaspuns = reader["TextRaspuns"].ToString(),
                            EsteCorect = (bool)reader["EsteCorect"]
                        });
                    }
                }
            }
            return answers;
        }
    }
}
