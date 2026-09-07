using System;
using System.ComponentModel.DataAnnotations;

namespace StudentEnrollment.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [DataType(DataType.Date)]
        public DateTime EnrollmentDate { get; set; }

        public int CourseId { get; set; } // Foreign Key
        public Course? Course { get; set; } // Navigation Property
    }
}