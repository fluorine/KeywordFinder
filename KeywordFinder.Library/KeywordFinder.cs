using KeywordFinder.Contracts;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace KeywordFinder
{
    public class KeywordFinder : IKeywordFinder
    {
        public IEnumerable<string> IgnoredWords { get; set; }

        public KeywordFinder()
        {
        }

        public KeywordFinder(IEnumerable<string> ignoredWords)
        {
            IgnoredWords = ignoredWords;
        }

        public IEnumerable<string> GetKeywordsFrom(string text)
        {
            // Replace all special characters for space and gnore case
            text = Regex.Replace(text.ToLower(), @"[^0-9a-zA-Z]+", " ");

            // Get words as tokens
            var tokens = Regex.Split(text, "\\s+");

            // Get keywords, ignoring stop words
            var keywords = tokens
                .Where(w => !string.IsNullOrWhiteSpace(w))
                .Distinct()
                .Except(IgnoredWords ?? Enumerable.Empty<string>());

            return keywords;
        }
    }
}
