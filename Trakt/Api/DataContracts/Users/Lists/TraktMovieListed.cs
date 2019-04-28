using Trakt.Api.DataContracts.BaseModel;
using Trakt.Api.DataContracts.Users.Collection;

namespace Trakt.Api.DataContracts.Users.Lists
{
    public class TraktMovieListed
    {
        public string listed_at { get; set; }

        public TraktMetadata metadata { get; set; }

        public TraktMovie movie { get; set; }
    }
}
