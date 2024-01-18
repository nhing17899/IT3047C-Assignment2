using System.ComponentModel.DataAnnotations;

namespace Assignment2_EFBasics.Models
{
    /*
        Model STUDENT
        Attributes: id, firstName, lastName, cohort
    */
    public class Student
    {
        public int Id { get; set; } 
        [MaxLength(50)]
        public string FirstName { get; set; } // Length doesn't exceed 50 characters
        [MaxLength(50)]
        public string LastName { get; set; } // Length doesn't exceed 50 characters
        public string Cohort { get; set; }
    }
}