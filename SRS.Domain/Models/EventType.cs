using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRS.Domain.Models
{
    /// <summary>
    /// This enumeration uses the GEDCOM Event Type specification with a few additions (marked with 3 asterisks)
    /// </summary>
    public enum EventType
    {
        Adoption,           // An adoption event.
        AdultChristening,   // An adult christening event.
        Annulment,          // An annulment event of a marriage.
        Baptism,            // A baptism event.
        BarMitzvah,         // A bar mitzvah event.
        BatMitzvah,         // A bat mitzvah event.
        Birth,              // A birth event.
        Blessing,           // A an official blessing event, such as at the hands of a clergy member or at another religious rite.
        Burial,             // A burial event.
        Census,             // A census event.
        Ceremony,           // A ceremony event. ***
        Christening,        // A christening event at birth.
        Circumcision,       // A circumcision event.
        CommunityMeeting,   // A community meeting or assembly. ***
        Confirmation,       // A confirmation event.
        Conflict,           // A conflict event. ***
        Cremation,          // A cremation event after death.
        Death,              // A death event.
        Divination,         // A divination event. ***
        Divorce,            // A divorce event.
        DivorceFiling,      // A divorce filing event.
        Education,          // An education or an educational achievement event (e.g. diploma, graduation, scholarship, etc.).
        Engagement,         // An engagement to be married event.
        Emigration,         // An emigration event.
        Excommunication,    // An excommunication event from a church.
        FirstCommunion,     // A first communion event.
        Funeral,            // A funeral event.
        Healing,            // A healing event. ***
        Immigration,        // An immigration event.
        LandTransaction,    // A land transaction event.
        Marriage,           // A marriage event.
        Meeting,            // A meeting event.
        MilitaryAward,      // A military award event.
        MilitaryDischarge,  // A military discharge event.
        Mission,            // A mission event.
        MoveFrom,           // An event of a move (i.e. change of residence) from a location.
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
