namespace Class_02
{
    using System; // For Console.WriteLine

    public class Program
    {
        public static void Main(string[] args)
        {
            // Create a Document object
            Document myDoc = new Document("This is a sample document with some text. C# is fun.");
            string wordToSearchDoc = "C#";
            bool foundInDoc = myDoc.Search(wordToSearchDoc);
            Console.WriteLine($"Word '{wordToSearchDoc}' found in document: {foundInDoc}\n");

            Document emptyDoc = new Document("");
            string wordToSearchEmpty = "text";
            bool foundInEmptyDoc = emptyDoc.Search(wordToSearchEmpty);
            Console.WriteLine($"Word '{wordToSearchEmpty}' found in empty document: {foundInEmptyDoc}\n");

            // Create a WebPage object
            WebPage myPage = new WebPage("My Awesome Page", "<html><body><h1>Welcome</h1><p>This page talks about programming and interfaces.</p></body></html>");
            string wordToSearchPage = "interfaces";
            bool foundInPage = myPage.Search(wordToSearchPage);
            Console.WriteLine($"Word '{wordToSearchPage}' found in web page: {foundInPage}\n");

            WebPage anotherPage = new WebPage("Tech News", "<p>Latest updates on C# and .NET.</p>");
            string wordToSearchAnotherPage = "Java";
            bool foundInAnotherPage = anotherPage.Search(wordToSearchAnotherPage);
            Console.WriteLine($"Word '{wordToSearchAnotherPage}' found in web page: {foundInAnotherPage}\n");


            // Example of using the interface type (polymorphism)
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

    // --- Interface Definition ---
    public interface ISearchable
    {
        bool Search(string word);
    }

    // --- Class Implementations ---
    public class Document : ISearchable
    {
        private string _content;

        public Document(string content)
        {
            _content = content;
        }

        public bool Search(string word)
        {
            Console.Write($"Searching in Document: ");
            if (string.IsNullOrEmpty(_content) || string.IsNullOrEmpty(word))
            {
                return false;
            }
            return _content.Contains(word, StringComparison.OrdinalIgnoreCase); // Case-insensitive
        }
    }

    public class WebPage : ISearchable
    {
        private string _htmlContent;
        private string _pageTitle;

        public WebPage(string title, string htmlContent)
        {
            _pageTitle = title;
            _htmlContent = htmlContent;
        }

        public bool Search(string word)
        {
            Console.Write($"Searching in WebPage '{_pageTitle}': ");
            if (string.IsNullOrEmpty(word)) return false;

            bool foundInTitle = !string.IsNullOrEmpty(_pageTitle) && _pageTitle.Contains(word, StringComparison.OrdinalIgnoreCase);
            bool foundInContent = !string.IsNullOrEmpty(_htmlContent) && _htmlContent.Contains(word, StringComparison.OrdinalIgnoreCase);

            return foundInTitle || foundInContent;
        }
    }
}
