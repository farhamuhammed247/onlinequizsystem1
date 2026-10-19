using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onlinequizsystem.entites
{
    public class QuizSetting
    {
        [Key]
        [ForeignKey("Quiz")]
        public int QuizId { get; set; }
        public int Durationinminutes { get; set; }
        public bool ShuffleQuestions { get; set; }
        public virtual Quiz Quiz { get; set; }

    }
}
