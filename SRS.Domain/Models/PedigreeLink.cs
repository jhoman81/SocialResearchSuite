using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SRS.Domain.Models
{
    public enum PedigreeLink
    {
        Parent,
        [Display(Name="Biological Child")]
        BiologicalChild,
        [Display(Name="Adopted Child")]
        AdoptedChild,
        [Display(Name="Foster Child")]
        FosterChild
    };
}
