using Class_02.models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_02.models.Classes
{
    // Represents a text document
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
}

