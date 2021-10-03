using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SRS.Domain.Models
{
    public enum PlaceType
    {
        [Display(Name="Administrative Facility")]
        AdminstrativeFacility,
        Business,
        Canton,
        [Display(Name="Celebration Hall")]
        CelebrationHall,
        Cemetary,
        Church,
        City,
        College,
        County,
        Country,
        Court,
        Domicile,
        [Display(Name="Educational Institute")]
        EducationalInstitute,
        Factory,
        Farm,
        Field,
        [Display(Name="Garden Plot")]
        GardenPlot,
        [Display(Name="Government Office")]
        GovernmentOffice,
        [Display(Name="Health Facility")]
        HealthFacility,
        Hospital,
        House,
        Prison,
        Landscape,                      // island, mountain, desert, natural feature with name
        [Display(Name="Military Base")]
        MilitaryBase,
        Mosque,
        Municipality,
        Park,
        Province,
        [Display(Name="Religious Facility")]
        ReligiousFacility,
        Restaurant,
        Road,                           // intersection, junction, interchange, etc.
        [Display(Name="Sacred Site")]
        SacredSite,
        School,
        State,
        Synagogue,
        Town,
        Temple,
        Trail,
        [Display(Name="Transportation Facility")]
        TransportationFacility,
        University,
        Village,
        Water,                          // river, lake, waterfall, ocean, sea, etc.
        Other
    };
}
