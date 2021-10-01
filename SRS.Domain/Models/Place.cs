using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRS.Domain.Models
{
    public class Place
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string AlternateName { get; set; }
        public string Type { get; set; } // Should be an enum ? 
        public string Description { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public DateTime FoundationDate { get; set; }
        public DateTime DesertedDate { get; set; }
        public string Address { get; set; }
        public string Country { get; private set; }
        public string Province { get; private set; }
        public string District { get; private set; }
        public string ZipCode { get; private set; }
        public string PhoneNumber { get; private set; } 
        public int Population { get; private set; }
        public bool AccessibleByRoad { get; private set; }
        public bool AccessibleByPlane { get; private set; }
        public bool AccessibleByRiver { get; private set; }
        public bool AccessibleByTrail { get; private set; }
        public bool HasElectricity { get; private set; }
        public bool HasPotableWater { get; private set; }
    }
}
