using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRS.Domain.Models
{
    public class Note
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateLastModified { get; set; }
        public string Content { get; private set; } 

        // public enum Type ---> Decide on types of notes!!!!
        public IEnumerable<Media> MediaList { get; set; }
        public IEnumerable<Person> People { get; set; }
        public IEnumerable<Reference> References { get; set; }
    }
}
