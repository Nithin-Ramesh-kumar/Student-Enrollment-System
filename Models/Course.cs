using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StudentEnrollment.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        [Required]
        [Display(Name = "Course Name")]
        public string CourseName { get; set; }
        public ICollection<Student>? Students { get; set; }
    }
}