using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorldMVCApp.Models
{
    public class GradesModel
    {
        public int ID { get; set; }

        [Required]
        //[MinLength(2, ErrorMessage = "Please enter a two digit number.")]
        public int StudentId { get; set; }

        [Required]
        public string TeacherName { get; set; }

        public string Subject { get; set; }

        public string Assignment { get; set; }


        public string Notes { get; set; }



    }
}
