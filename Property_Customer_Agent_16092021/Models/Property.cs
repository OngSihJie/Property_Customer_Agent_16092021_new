using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Property_Customer_Agent_16092021.Models
{
    public class Property
    {
        [Key]
        public int Id { get; set; }
        [Required]

        public string Property_Name { get; set; }

        public int Property_WeeklyRent { get; set; }

        public int Property_Number_of_Bedrooms { get; set; }

        public int Property_Number_of_Bathrooms { get; set; }

        public string Property_Location { get; set; }
    }
}
