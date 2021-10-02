using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRS.Domain.Models
{
    public enum RelationType
    {
        Marriage,
        SeparationInFact,       // Separated but not legally 
        LegalSeparation,
        Divorce,
        Annulled,               // Annulment of marriage
        Widowed,                
        Engagement,
        Cohabitation,
        Committed,              // Committed relationship
        Casual,                 // Casual or dating, non-exclusive
        Temporary,              // One night stand
        LoveAffair,             
        Unknown
    };
}
