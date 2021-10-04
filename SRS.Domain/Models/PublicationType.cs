using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRS.Domain.Models
{
    /// <summary>
    /// This enum combines the Zotero ref type with some others that are not included there
    /// </summary>
    public enum PublicationType
    {
        Advertisement,
        Artwork,
        [Display(Name = "Audio Recording")]
        AudioRecording,
        Bill,
        [Display(Name = "Blog Post")]
        BlogPost,
        [Display(Name = "Book Section")]
        BookSection,
        Case,
        [Display(Name = "Conference Paper")]
        ConferencePaper,
        Database,
        [Display(Name = "Dictionary Entry")]
        DictionaryEntry,
        Document,
        Email,
        [Display(Name = "Encyclopedia Article")]
        EncyclopediaArticle,
        Film,
        [Display(Name = "Field Note")]
        FieldNote,
        Flyer,
        [Display(Name = "Forum Post")]
        ForumPost,
        Hearing,
        [Display(Name = "Instant Message")]
        InstantMessage,
        Interview,
        [Display(Name = "Journal Article")]
        JournalArticle,
        Letter,
        [Display(Name = "Magazine Article")]
        MagazineArticle,
        Manuscript,
        Map,
        [Display(Name = "Newspaper Article")]
        NewspaperArticle,
        Patent,
        Podcast,
        Presentation,
        [Display(Name = "Radio Broadcast")]
        RadioBroadcast,
        Report,
        Sermon,
        Software,
        Statute,
        Thesis,
        Transcript,
        [Display(Name = "Television Broadcast")]
        TVBroadcast,
        [Display(Name = "Video Recording")]
        VideoRecording,
        [Display(Name = "Web Page")]
        WebPage,
        [Display(Name = "Working Paper")]
        WorkingPaper
    };
}
