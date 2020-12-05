using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AuthenticationAndAuthorization.Models
{
    //mich
    public class StudentGrades
    {
        [Key]
        public int ID { get; set; }
        public string UserID { get; set; }

        public int Quiz1Prelim { get; set; }
        public int Quiz2Prelim { get; set; }
        public int Quiz3Prelim { get; set; }
        public int Assignment1Prelim { get; set; }
        public int Assignment2Prelim { get; set; }
        public int Assignment3Prelim { get; set; }
        public int Quiz1Midterm { get; set; }
        public int Quiz2Midterm { get; set; }
        public int Quiz3Midterm { get; set; }
        public int Assignment1Midterm { get; set; }
        public int Assignment2Midterm { get; set; }
        public int Assignment3Midterm { get; set; }
        public int Quiz1Prefinal { get; set; }
        public int Quiz2Prefinal { get; set; }
        public int Quiz3Prefinal { get; set; }
        public int Assignment1Prefinal { get; set; }
        public int Assignment2Prefinal { get; set; }
        public int Assignment3Prefinal { get; set; }
        public int Quiz1Final { get; set; }
        public int Quiz2Final { get; set; }
        public int Quiz3Final { get; set; }
        public int Assignment1Final { get; set; }
        public int Assignment2Final { get; set; }
        public int Assignment3Final { get; set; }

        public float PrelimGrade {get; set;}
        public float MidtermGrade { get; set; }
        public float PrefinalGrade { get; set; }
        public float FinalGrade { get; set; }

    }
    //mich
}
