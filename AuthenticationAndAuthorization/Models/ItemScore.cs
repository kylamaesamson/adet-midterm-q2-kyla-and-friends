using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AuthenticationAndAuthorization.Models
{
    public class ItemScore
    {
        [Key]
        public int ID { get; set; }
        public string Type { get; set; }
        public int TotalItems { get; set; }
        public int Score { get; set; }
        public double Grade { get; set; }

    }
}
