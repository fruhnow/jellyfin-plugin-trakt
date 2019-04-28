using System;

namespace Trakt.Api.DataContracts.BaseModel
{
    public class TraktPlaylist
    {
        public string name { get; set; }
        public string description { get; set; }
        public string privacy { get; set; }
        public bool display_numbers { get; set; }
        public bool allow_comments { get; set; }
        public string sort_by { get; set; }
        public string sort_how { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public int item_count { get; set; }
        public int comment_count { get; set; }
        public int likes { get; set; }
        public TraktId ids { get; set; }
    }
}
