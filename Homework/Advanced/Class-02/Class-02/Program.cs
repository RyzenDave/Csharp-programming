using Class_02.models.Classes;
using Class_02.models.Interfaces;

namespace Class_02
{
    using System; // For Console.WriteLine

    public class Program
    {
        public static void Main(string[] args)
        {
            // Created a doc object
            Document myDoc = new Document("This is a sample document with some text. C# is fun.");
            string wordToSearchDoc = "C#";
            bool foundInDoc = myDoc.Search(wordToSearchDoc);
            Console.WriteLine($"Word '{wordToSearchDoc}' found in document: {foundInDoc}\n");

            Document emptyDoc = new Document("");
            string wordToSearchEmpty = "text";
            bool foundInEmptyDoc = emptyDoc.Search(wordToSearchEmpty);
            Console.WriteLine($"Word '{wordToSearchEmpty}' found in empty document: {foundInEmptyDoc}\n");

            // Made webpage object
            WebPage myPage = new WebPage("My Awesome Page", "<html><body><h1>Welcome</h1><p>This page talks about programming and interfaces.</p></body></html>");
            string wordToSearchPage = "interfaces";
            bool foundInPage = myPage.Search(wordToSearchPage);
            Console.WriteLine($"Word '{wordToSearchPage}' found in web page: {foundInPage}\n");

            WebPage anotherPage = new WebPage("Tech News", "<p>Latest updates on C# and .NET.</p>");
            string wordToSearchAnotherPage = "Java";
            bool foundInAnotherPage = anotherPage.Search(wordToSearchAnotherPage);
            Console.WriteLine($"Word '{wordToSearchAnotherPage}' found in web page: {foundInAnotherPage}\n");


            // Using interface type for polymorphism
            Console.WriteLine("\n--- Demonstrating Polymorphism ---");
            ISearchable[] searchableItems = new ISearchable[]
            {
            new Document("Another document here. Testing the search functionality."),
            new WebPage("Search Engines", "<h1>About Search</h1><p>This page discusses how search engines work with web pages.</p>")
            };

            string commonSearchTerm = "page";
            foreach (ISearchable item in searchableItems)
            {
                // No need to know if it's a Document or WebPage, just that it's Searchable
                bool found = item.Search(commonSearchTerm); // The correct Search() method is called
                Console.WriteLine($"Item of type '{item.GetType().Name}' contains '{commonSearchTerm}': {found}");
            }
        }
    }
}

