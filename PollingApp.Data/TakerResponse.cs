using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PollingApp.Data
{
    public class TakerResponse  
    {
        [Key]
        public int TakerResponseId { get; set; }

        [Required]
        [ForeignKey(nameof(Poll))]
        public int PollId { get; set; }
        public Poll Poll { get; set; }

        [Required]
        [ForeignKey(nameof(Question))]
        public int QuestionId { get; set; }
        public Question Question { get; set; }

        [Required]
        [ForeignKey(nameof(Answer))]
        public int AnswerId { get; set; }
        public Answer Answer { get; set; }
    }
}
