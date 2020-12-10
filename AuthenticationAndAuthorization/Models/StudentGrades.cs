using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AuthenticationAndAuthorization.Models
{
    public class StudentGrades
    {
        [Key]
        public int ID { get; set; }
        public string AppUserID { get; set; }
        public double SubjectGrade { get; set; }
        public int? PrelimID { get; set; }
        public int? MidtermID { get; set; }
        public int? PrefinalID { get; set; }
        public int? FinalID { get; set; }
        public AppUser AppUser { get; set; }
        public GradesPerTerm Prelim { get; set; }
        public GradesPerTerm Midterm { get; set; }
        public GradesPerTerm Prefinal { get; set; }
        public GradesPerTerm Final { get; set; }
    }
    
}
