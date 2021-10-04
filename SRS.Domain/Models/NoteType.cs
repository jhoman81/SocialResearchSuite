using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRS.Domain.Models
{
    public enum NoteType
    {
        [Display(Name = "Diary Entry")]
        DiaryEntry,
        [Display(Name = "Field Note")]
        FieldNote,
        [Display(Name = "Log Or Record")]
        LogOrRecord,
        [Display(Name = "Scratch Note")]
        ScratchNote,
        Other
    };
}
