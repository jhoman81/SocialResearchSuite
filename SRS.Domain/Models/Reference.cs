using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRS.Domain.Models
{
    public class Reference : DomainObject
    {
        public string Title { get; set; }
        public DateTime? PublicationDate { get; set; }
        public string? Description { get; set; }
        public DateTime? DateAdded { get; set; }
        public DateTime? DateLastModified { get; set; }
        // list of authors
        public string? PublicationTitle { get; set; }
        // list of editors
        public string? Pages { get; set; }
        public string? Publisher { get; set; }
        public string? PublisherLocation { get; set; }
        // type of publication or reference
        // list of linked docs
        public Media? ReferenceFile { get; set; }
        public IEnumerable<Note>? Notes { get; set; }    
    }
}
