using ElearningModels.Questions;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElearningModels
{
    public class Question
    {
        [Key]
        public Guid Id { get; set; }
        
        public QuestionType QType { get; set; }

        public FreeFormQModel FreeForm { get; set; }

        public MatchQModel Match { get; set; }

        public MultipleChoiceQModel MultipleChoice { get; set; }

        public TrueFalseQModel TrueFalse { get; set; }
    }


    public enum QuestionType
    {
        [Description("Ελευθέρου κειμένου")]
        FreeForm,
        [Description("Αντιστοίχηση")]
        Match,
        [Description("Πολλαπλής Επιλογής")]
        MultipleQuestion,
        [Description("Σωστό/Λάθος")]
        TrueFalse
    }

}
