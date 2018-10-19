# KeywordFinder

A simple library to get keywords from a text. It also includes English stop words.

Keywords are useful to optimize search for specific concepts.

### Usage and example ###

```C#
// Text to get keywords from
var text = "The last enemy to be destroyed is death.";

// Define keyword finder
var keywordFinder = KeywordFinderBuilder
                    .IgnoringWordsFrom(StopWords.English)
                    .Create();

// Get keywords from defined finder
var keywords = keywordFinder.GetKeywordsFrom(text);
```

The keywords for the text above would be: _enemy, destroyed, death_

### Todo list

- Implement synonymous for keywords
- More stop words
- Stop words from other languages
- Smart search for phrases?