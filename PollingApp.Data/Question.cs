using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PollingApp.Data
{
    public class Question
    {
        [Key]
        public int QuestionId { get; set; }

        [Required]
        public string QuestionText { get; set; }

        public enum QuestionType { IsAnswerTrue, OnlyOneAnswer, MultipleAnswers}

        public bool IsAnswerTrue { get; set; }

        //how to make a list nullable? or is it fine since it's not required?
        public List<string> OnlyOneAnswer { get; set; } = new List<string>();
        //how to make a list nullable?
        public List<string> MultipleAnswers { get; set; } = new List<string>();
    }
}
