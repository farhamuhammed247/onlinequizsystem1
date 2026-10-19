using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onlinequizsystem.entites
{
    public class Quiz
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }

        public virtual ICollection <Question> Questions { get; set; }=new HashSet<Question>();
        public virtual ICollection <StudentQuiz> StudentQuizzes { get; set; }=new HashSet<StudentQuiz>();
        public virtual QuizSetting Settings { get; set; }
    }
}
