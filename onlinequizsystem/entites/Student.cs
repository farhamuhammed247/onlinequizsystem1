using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onlinequizsystem.entites
{
    public class Student
    {
        public int Id { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required]
        public string Email { get; set; }
        public virtual ICollection<StudentQuiz> StudentQuizzes { get; set; } = new HashSet<StudentQuiz>();

    }
}
