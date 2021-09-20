using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRS.Domain.Models
{
    public class Project
    {
        public int Id {  get; set; }
        public string Title {  get; set; } // Project Title
        public string Description {  get; set; } // Description/Abstract of Project
        public int UserId { get; set; } // User ID of Project Owner
        public DateTime StartDate { get; set; } // Data project began - optional
        public DateTime EndDate { get; set; }  // Date for completion of project - optional
    }
}
