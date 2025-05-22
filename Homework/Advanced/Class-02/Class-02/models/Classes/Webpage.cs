using Class_02.models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_02.models.Classes
{
    // Represents a web page
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
