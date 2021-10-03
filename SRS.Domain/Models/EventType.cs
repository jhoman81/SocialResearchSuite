using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SRS.Domain.Models
{
    /// <summary>
    /// This enumeration uses the GEDCOM Event Type specification with a few additions (marked with 3 asterisks)
    /// </summary>
    public enum EventType
    {
        Adoption,           // An adoption event.
        [Display(Name = "Adult Christening")]
        AdultChristening,   // An adult christening event.
        Annulment,          // An annulment event of a marriage.
        Baptism,            // A baptism event.
        [Display(Name = "Bar Mitzvah")]
        BarMitzvah,         // A bar mitzvah event.
        [Display(Name = "Bat Mitzvah")]
        BatMitzvah,         // A bat mitzvah event.
        Birth,              // A birth event.
        Blessing,           // A an official blessing event, such as at the hands of a clergy member or at another religious rite.
        Burial,             // A burial event.
        Census,             // A census event.
        Ceremony,           // A ceremony or ritual event. ***
        Christening,        // A christening event at birth.
        Circumcision,       // A circumcision event.
        [Display(Name = "Community Meeting")]
        CommunityMeeting,   // A community meeting or assembly. ***
        Confirmation,       // A confirmation event.
        Conflict,           // A conflict event. ***
        Cremation,          // A cremation event after death.
        Death,              // A death event.
        Divination,         // A divination event. ***
        Divorce,            // A divorce event.
        [Display(Name = "Divorce Filing")]
        DivorceFiling,      // A divorce filing event.
        Education,          // An education or an educational achievement event (e.g. diploma, graduation, scholarship, etc.).
        Engagement,         // An engagement to be married event.
        Emigration,         // An emigration event.
        Excommunication,    // An excommunication event from a church.
        [Display(Name = "First Communion")]
        FirstCommunion,     // A first communion event.
        Funeral,            // A funeral event.
        Healing,            // A healing event. ***
        Immigration,        // An immigration event.
        [Display(Name = "Land Transaction")]
        LandTransaction,    // A land transaction event.
        Marriage,           // A marriage event.
        Meeting,            // A meeting event.
        [Display(Name = "Military Award")]
        MilitaryAward,      // A military award event.
        [Display(Name = "Military Discharge")]
        MilitaryDischarge,  // A military discharge event.
        Mission,            // A mission event.
        [Display(Name = "Move From")]
        MoveFrom,           // An event of a move (i.e. change of residence) from a location.
        [Display(Name = "Move To")]
        MoveTo,             // An event of a move (i.e. change of residence) to a location.
        Naming,             // A naming event. ***
        Naturalization,     // A naturalization event (i.e. acquisition of citizenship and nationality).
        Ordination,         // An ordination event.
        Presentation,       // A presentation event. ***
        Protest,            // A protest event. ***
        Retirement,         // A retirement event.
        Ritual,             // A ritual event. ***
        Work                // A work or labor event. ***
    };
}
