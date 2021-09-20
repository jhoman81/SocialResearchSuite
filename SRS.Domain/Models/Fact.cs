using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRS.Domain.Models
{
    public class Fact
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }
        public IEnumerable<Person> People {  get; set; } // list of involved people
        public IEnumerable<Place> Places {  get; set; } // list of places
        public IEnumerable<Note> Notes { get; set; } // notes
        public IEnumerable<Reference> References { get; set; } // references
    }
}
