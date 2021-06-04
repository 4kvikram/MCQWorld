using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MCQWorld.DAL.Models
{
    public class Questions
    {
        [Column("QuestionId")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public long QuestionId { get; set; }
        public string Question  { get; set; }
        public string Description  { get; set; }
        public long QuestionType { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifyedOn { get; set; }
        public string CreatedBy { get; set; }
        public string ModifyedBy { get; set; }
        public int Status { get; set; }

    }
}
