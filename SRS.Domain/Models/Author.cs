using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRS.Domain.Models
{
    public class Author : DomainObject
    { 
        public string FirstName { get; set; }
        public string? SecondName { get; set; }
        public string? AlternateName { get; set; }
        public string PaternalSurname { get; set; }
        public string? MaternalSurname { get; set; }
    }
}
