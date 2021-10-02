using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRS.Domain.Models
{
    public class Relation : DomainObject
    {
        public int? PersonOneId { get; set; }
        public int? PersonTwoId { get; set; }
        public string? RelationTerm { get; set; } // How P1 refers to P2
        public string? ReverseRelationTerm { get; set; } // How P2 refers to P2
        public RelationType? RelationType { get; set; }
        public PedigreeLink? PedigreeLink { get; set; }
        public IEnumerable<Person>? Offspring { get; set; } 
    }
}
