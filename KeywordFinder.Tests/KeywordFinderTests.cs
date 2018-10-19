using FluentAssertions;
using KeywordFinder.Resources;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KeywordFinder.Tests
{
    [TestClass]
    public class KeywordFinderTests
    {
        [TestMethod]
        public void GetKeywordsFromClinicalDiagnostic()
        {
            var text = "Nondisplaced fracture of triquetrum [cuneiform] bone, left wrist, subsequent encounter for fracture with delayed healing";

            var keywordFinder = KeywordFinder
                .IgnoringWordsFrom(StopWords.English);

            var keywords = keywordFinder.GetKeywordsFrom(text);

            keywords.Should().Contain("bone");
            keywords.Should().NotContain("of");
            keywords.Should().NotContain(string.Empty);
        }

        [TestMethod]
        public void GetKeywordsFromVerse()
        {
            var text = "The last enemy to be destroyed is death.";

            var keywordFinder = KeywordFinder
                .IgnoringWordsFrom(StopWords.English);

            var keywords = keywordFinder.GetKeywordsFrom(text);

            keywords.Should().Contain("death");
            keywords.Should().NotContain("is");
            keywords.Should().NotContain(string.Empty);
        }
    }
}
