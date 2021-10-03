using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SRS.Domain.Models
{
    public enum RelationType
    {
        Marriage,
        [Display(Name="Separation In Fact" )]
        SeparationInFact,       // Separated but not legally 
        [Display(Name="Legal Separation")]
        LegalSeparation,
        Divorce,
        Annulled,               // Annulment of marriage
        Widowed,                
        Engagement,
        Cohabitation,
        Committed,              // Committed relationship
        Casual,                 // Casual or dating, non-exclusive
        Temporary,              // One night stand
        [Display(Name="Love Affair")]
        LoveAffair,             
        Unknown
    };
}
