using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace codeWarsAPI.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public Cohort Cohort { get; set; }
        public List<Kata> KatasProposed {get; set;}
        public List<Kata> KatasCompleted {get; set;}
        [DefaultValue(false)]
        public bool IsDeleted { get; set; }
        [ForeignKey("Cohort")]
        public int CohortFK { get; set; }
    }
}
