using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Property_Customer_Agent_16092021.Models
{
    public class Customer
    {
        [Key]
        public string Cust_Username { get; set; }
        [Required]
        public string Cust_FirstName { get; set; }

        public string Cust_LastName { get; set; }

        public string Cust_Address { get; set; }

        public int Cust_Mobile { get; set; }

        public string Cust_Password { get; set; }
    }
}
