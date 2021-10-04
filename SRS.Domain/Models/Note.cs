using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRS.Domain.Models
{
    public class Note : DomainObject
    {
        public string Title { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateLastModified { get; set; }
        public string? Content { get; set; } 
        public NoteType? NoteType { get; set; }
        public IEnumerable<Media>? MediaList { get; set; }
        public IEnumerable<Person>? People { get; set; }
        public IEnumerable<Reference>? References { get; set; }
    }
}
