using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRS.Domain.Models
{
    public class Media : DomainObject
    {
        public string FileName { get; set; }
        public string? FileExtension { get; set; }
        public string? FileLocation { get; set; }
        public string? Description { get; set; }
        public string? Title { get; set; }
        public double? FileSize { get; set; }
        // FILE TYPE (e.g., video, audio, document, etc
        // LIST OF LINKED REFERENCES
    }
}
