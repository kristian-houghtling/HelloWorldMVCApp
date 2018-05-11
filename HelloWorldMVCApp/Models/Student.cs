using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HelloWorldMVCApp.Models
{

    public enum Gender
    {
        Male,
        Female
    }

    public enum Enrolled
    {
        Yes,
        No
    }

    public class Student
    {

        [Display(Name = "Student Id")]
        public int StudentId { get; set; }

        [Required]
        [MaxLength(5, ErrorMessage = "YOU SUCK!!!")]
        [Display(Name = "Name")]
        public string StudentName { get; set; }


        public Gender StudentGender { get; set; }
        public Enrolled StudentEnrolled { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        [Display(Name = "Grade Level")]
        public int GradeLevel { get; set; }



        [Display(Name = "Course Completed?")]
        public bool hasPassed { get; set; }

        public string status { get; set; }


    }




}
