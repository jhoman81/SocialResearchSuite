using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRS.Domain.Models
{
    public class Event : DomainObject
    {
        public string Name { get; set; }
        public EventType? EventType {  get; set; }
        public string? Description { get; set; }
        public DateTime? BeginDate { get; set; }
        public DateTime? EndDate { get; set; }
        public IEnumerable<Place>? Places { get; set; }
        public IEnumerable<Note>? Notes { get; set; }
        public IEnumerable<Reference>? References { get; set; }
        public IEnumerable<Person>? Participants { get; set; }
        public IEnumerable<Media>? Media { get; set; }
    }
}
