using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRS.Domain.Models
{
    [NotMapped]
    public class LanguageJSON
    {
        [NotMapped]
        public class Rootobject
        {
            public string type { get; set; }
            public Properties properties { get; set; }
            public Feature[] features { get; set; }
        }

        [NotMapped]
        public class Properties
        {
            public string layer { get; set; }
        }

        [NotMapped]
        public class Feature
        {
            public string type { get; set; }
            public Properties1 properties { get; set; }
            public Geometry geometry { get; set; }
            public string id { get; set; }
        }

        [NotMapped]
        public class Properties1
        {
            public Language language { get; set; }
            public string icon { get; set; }
            public string name { get; set; }
        }

        [NotMapped]
        public class Language
        {
            public int pk { get; set; }
            public string hid { get; set; }
            public int? father_pk { get; set; }
            public int? family_pk { get; set; }
            public string level { get; set; }
            public bool bookkeeping { get; set; }
            public string category { get; set; }
            public string newick { get; set; }
            public int child_family_count { get; set; }
            public int child_language_count { get; set; }
            public int child_dialect_count { get; set; }
            public string macroareas { get; set; }
            public Jsondata jsondata { get; set; }
            public string id { get; set; }
            public string name { get; set; }
            public object description { get; set; }
            public object markup_description { get; set; }
            public float latitude { get; set; }
            public float longitude { get; set; }
        }

        [NotMapped]
        public class Jsondata
        {
            public Iso_Retirement iso_retirement { get; set; }
            public Ethnologue_Comment ethnologue_comment { get; set; }
            public Link[] links { get; set; }
            public object[][] meds { get; set; }
            public bool _new { get; set; }
        }

        [NotMapped]
        public class Iso_Retirement
        {
            public string code { get; set; }
            public string name { get; set; }
            public string change_request { get; set; }
            public string effective { get; set; }
            public string reason { get; set; }
            public string[] change_to { get; set; }
            public string remedy { get; set; }
            public string comment { get; set; }
        }

        [NotMapped]
        public class Ethnologue_Comment
        {
            public string isohid { get; set; }
            public string comment_type { get; set; }
            public string[] ethnologue_versions { get; set; }
            public string comment { get; set; }
        }

        [NotMapped]
        public class Link
        {
            public string url { get; set; }
            public string label { get; set; }
        }

        [NotMapped]
        public class Geometry
        {
            public string type { get; set; }
            public float[] coordinates { get; set; }
        }
    }
}
