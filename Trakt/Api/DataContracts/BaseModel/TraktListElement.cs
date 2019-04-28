using System;
using System.Collections.Generic;
using System.Text;

namespace Trakt.Api.DataContracts.BaseModel
{
    public class TraktListElement
    {
        public int rank { get; set; }
        public int id { get; set; }
        public DateTime listed_at { get; set; }
        public string type { get; set; }
        public TraktMovie movie { get; set; }
        public TraktShow show { get; set; }
    }
}
