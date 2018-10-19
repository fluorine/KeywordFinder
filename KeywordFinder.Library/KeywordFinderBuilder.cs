using KeywordFinder.Contracts;
using System.Collections.Generic;

namespace KeywordFinder.Library
{
    public class KeywordFinderBuilder
    {
        public List<string> IgnoredWords { get; set; }

        public KeywordFinderBuilder(List<string> ignoredWords)
        {
            IgnoredWords = ignoredWords;
        }

        public static KeywordFinderBuilder IgnoringWordsFrom(List<string> ignoredWords)
        {
            return new KeywordFinderBuilder(ignoredWords);
        }

        public IKeywordFinder Create()
        {
            return new KeywordFinder(IgnoredWords);
        }
    }
}
