using Platforma_de_educatie.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platforma_de_educatie.Models
{
    public class QuestionModel
    {
        public int ID_Intrebare { get; set; }
        public string TextIntrebare { get; set; }
        public float Punctaj { get; set; }
        public List<AnswearModel> Raspunsuri { get; set; }
    }
}
