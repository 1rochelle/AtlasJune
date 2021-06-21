using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PollingApp.Data
{
    public class Poll
    {
        [Key]
        public int PollId { get; set; }

        [Required]
        public bool IsPublished { get; set; }

        [Required]
        public string PollName { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        [ForeignKey(nameof(Question))]
        public int QuestionId { get; set; }
        public Question Question { get; set; }

        public DateTimeOffset ExpiresOn { get; set; }

    }
}
