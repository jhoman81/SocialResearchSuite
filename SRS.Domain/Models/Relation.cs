using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRS.Domain.Models
{
    public class Relation
    {
        public int Id { get; set; }
        public int PersonOneId { get; set; }
        public int PersonTwoId { get; set; }
        // relationship type enum 
        // reverse relationship type
        // children produced through relationship
    }
}
