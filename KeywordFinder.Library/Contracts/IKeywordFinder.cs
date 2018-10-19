using System.Collections.Generic;

namespace KeywordFinder.Contracts
{
    public interface IKeywordFinder
    {
        /// <summary>
        /// Words to be ignored.
        /// </summary>
        IEnumerable<string> IgnoredWords { get; }

        IEnumerable<string> GetKeywordsFrom(string text);
    }
}