using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRS.Domain.Models
{
    public class Community : DomainObject
    {
        public IEnumerable<Person>? People { get; set; }         // List of families within the community
        public Place? Location { get; set; }                     // Place 
        public IEnumerable<Household>? Households {  get; set;}  // List of households within the community
    }
}
