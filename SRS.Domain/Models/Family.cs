using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRS.Domain.Models
{
    public class Family : DomainObject
    {
        public IEnumerable<Person>? People { get; set; }
    }
}
