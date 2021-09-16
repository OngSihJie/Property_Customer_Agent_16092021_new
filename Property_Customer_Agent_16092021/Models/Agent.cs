using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Property_Customer_Agent_16092021.Models
{
    public class Agent
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Agent_Name { get; set; }

        public string Agent_Email { get; set; }

        public int Agent_Mobile { get; set; }

        public string Office_Location { get; set; }
    }
}
