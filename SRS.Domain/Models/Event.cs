using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRS.Domain.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; }
        // public enum Type -- list of event types here --> https://github.com/FamilySearch/gedcomx/blob/master/specifications/event-types-specification.md
        public string Description { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        public IEnumerable<Place>? Places { get; set; }
        public IEnumerable<Note> Notes { get; set; }
        public IEnumerable<Reference> References { get; set; }
        public IEnumerable<Person> Participants { get; set; }
        // LIST OF MEDIA
    }
}
