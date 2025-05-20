using Class_02.models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_02.models.Classes
{
    // Represents a text document
    public class Document : ISearchable // "Document" implements the "ISearchable" interface
    {
        private string _content; // Private field to store the document's text

        // Constructor to initialize the document with some text
        public Document(string content)
        {
            _content = content;
        }

        // Implementation of the Search method required by ISearchable
        public bool Search(string word)
        {
            Console.WriteLine($"Searching for '{word}' in Document...");
            if (string.IsNullOrEmpty(_content) || string.IsNullOrEmpty(word))
            {
                return false;
            }
            // Simple string search (case-sensitive)
            return _content.Contains(word);
            // For case-insensitive: return _content.ToLower().Contains(word.ToLower());
        }
    }
}
