using System;
using System.IO;
using Lucene.Net.Analysis;
using Lucene.Net.Analysis.Standard;
using Lucene.Net.Index;
using Lucene.Net.Index.Memory;
using System.Collections.Generic;
using Lucene.Net.QueryParsers;

var searchText = "hogwarts";
Analyzer analyzer = new SearchAnalyzer();
MemoryIndex index = new MemoryIndex();

index.AddField("title", searchText, analyzer);
index.AddField("content", searchText, analyzer);

QueryParser parser = new QueryParser(Lucene.Net.Util.Version.LUCENE_CURRENT, "title", analyzer);

Console.WriteLine("Search text: \'" + searchText + "\'");


var testStrings = new List<string>();
testStrings.Add("Hogwarts");
testStrings.Add("Hogwarts ");
testStrings.Add("Hogw arts");s
testStrings.Add(" Hogwarts ");
testStrings.Add(" Hogwarts");

foreach (var testString in testStrings)
{
    Console.WriteLine("String score: \'" + testString + "\' SCORE: (" + index.Search(parser.Parse(testString)) + ")");
}



public class SearchAnalyzer : Analyzer
{
    protected override TokenStreamComponents CreateComponents(string fieldName, TextReader reader)
    {
        Tokenizer tokenizer = new StandardTokenizer(Lucene.Net.Util.LuceneVersion.LUCENE_48, reader);
        TokenStream tokenStream = new StandardFilter(Lucene.Net.Util.LuceneVersion.LUCENE_48, tokenizer);

        var tokenStreamComponent = new TokenStreamComponents(tokenizer, tokenStream);
        return tokenStreamComponent;
    }
}