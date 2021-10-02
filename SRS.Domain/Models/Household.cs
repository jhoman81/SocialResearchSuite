using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRS.Domain.Models
{
    public class Household : DomainObject
    {
        public IEnumerable<Person>? People { get; set; } // Individuals within the household
        public Place? Location { get; set; }             // Location of household
    }
}
