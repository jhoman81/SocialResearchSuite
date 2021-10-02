using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRS.Domain.Models
{
    public class User : DomainObject
    {
        public string? FirstName { get; set; }
        public string Username { get; set; }
        public string? Surname {  get; set; }
        public string? Email {  get; set; }
        public string? Password {  get; set; }
        public IEnumerable<Project>? Projects {  get; set; } // List of projects that are associated with this user
    }
}
