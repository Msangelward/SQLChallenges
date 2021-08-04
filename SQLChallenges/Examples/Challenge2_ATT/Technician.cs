using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLChallenges.Examples.Challenge2_ATT
{
    public class Technician
    {
        public int TechnicianId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal CustomerRating { get; set; }
        public Vehicle Vehicle { get; set; }
    }
}
