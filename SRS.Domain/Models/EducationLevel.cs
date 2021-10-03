using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SRS.Domain.Models
{ 
    public enum EducationLevel
    {
        None,
        Kindergarten,
        Primary,
        Secondary,
        [Display(Name="Technical or Institute")]
        TechnicalOrInstitute,
        [Display(Name="Some College")]
        SomeCollege,
        [Display(Name="Bachelor's Degree")]
        Bachelors,
        [Display(Name="Master's Degree")]
        Masters,
        Doctorate,
        Postdoctorate
    };
}
