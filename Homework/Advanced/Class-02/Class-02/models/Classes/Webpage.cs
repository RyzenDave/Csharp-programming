using Class_02.models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_02.models.Classes
{
    // Represents a web page
    public class WebPage : ISearchable // "WebPage" implements the "ISearchable" interface
    {
        private string _htmlContent; // Field to store the web page's HTML
        private string _pageTitle;

        // Constructor
        public WebPage(string title, string htmlContent)
        {
            _pageTitle = title;
            _htmlContent = htmlContent;
        }

        // Implementation of the Search method required by ISearchable
        public bool Search(string word)
        {
            Console.WriteLine($"Searching for '{word}' in WebPage '{_pageTitle}'...");
            if (string.IsNullOrEmpty(_htmlContent) || string.IsNullOrEmpty(word))
            {
                return false;
            }
            // For a webpage, you might search in title and content
            bool foundInTitle = !string.IsNullOrEmpty(_pageTitle) && _pageTitle.Contains(word, StringComparison.OrdinalIgnoreCase);
            bool foundInContent = _htmlContent.Contains(word, StringComparison.OrdinalIgnoreCase); // Case-insensitive

            return foundInTitle || foundInContent;
        }
    }
}
