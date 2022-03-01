using Firehose.Web.Infrastructure;
using System;
using System.Collections.Generic;

namespace Firehose.Web.Authors
{
    public class JonNichols : IAmACommunityMember
    {
        public string FirstName => "Jon";
        public string LastName => "Nichols";
        public string ShortBioOrTagLine => "Use your skills for the good of humanity";
        public string StateOrRegion => "Michigan";
        public string EmailAddress => "nichojo89@gmail.com";
        public string TwitterHandle => "nichojo89";
        public string GravatarHash => "73271cc3f55d32f3e726926d26d036d1";
        public string GitHubHandle => "nichojo89";
        public GeoPosition Position => new GeoPosition(42.68458686737882, -82.79580390053044);
        public Uri WebSite => new Uri("https://app-trap.com/");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://app-trap.com/feed"); } }
        public string FeedLanguageCode => "en";
    }
}