using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AuthenticationAndAuthorization.Models
{
    
    public class GradesPerTerm
    {
        [Key]
        public int ID { get; set; }
        public string Term { get; set; }
        public double Grade { get; set; }

        public int? Quiz1ID { get; set; }
        public int? Quiz2ID { get; set; }
        public int? Quiz3ID { get; set; }
        public int? Assignment1ID { get; set; }
        public int? Assignment2ID { get; set; }
        public int? Assignment3ID { get; set; }
        public ItemScore Quiz1 { get; set; }
        public ItemScore Quiz2 { get; set; }
        public ItemScore Quiz3 { get; set; }
        public ItemScore Assignment1 { get; set; }
        public ItemScore Assignment2 { get; set; }
        public ItemScore Assignment3 { get; set; }
    }
}
