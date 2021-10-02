using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRS.Domain.Models
{
    public class Person : DomainObject
    { 
        public string FirstName { get; set; }
        public string? SecondName { get; set; }
        public string? AlternateName { get; set; }
        public string PaternalSurname { get; set; }
        public string? MaternalSurname { get; set; }
        public Place? BirthPlace { get; set; }
        public Place? DeathPlace { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public DateTime? DateOfDeath { get; set; }
        public Gender? Gender { get; set; }
        public Handedness? Hand { get; set; }
        public ReligionType? Religion { get; set; }
        public EducationLevel? Education { get; set; }
        public bool? IsMarried { get; set; } 
        public bool? HasChildren { get; set; }
        public Place? Residence { get; set; }
        public string? Description { get; set; }
        public IEnumerable<Fact>? Facts { get; set; }
        public IEnumerable<Note>? Notes { get; set; }
        // list of relatives with relationship type
        // list of languages
        // List of Past residences with years spent in each...
    }
}
