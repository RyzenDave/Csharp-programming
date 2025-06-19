using System.IO;

namespace Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Get the directory where the executable is running
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

            // Navigate up to the solution directory (assuming standard project structure)
            string solutionDirectory = Path.GetFullPath(Path.Combine(baseDirectory, "..\\..\\..\\"));

            string folderPath = Path.Combine(solutionDirectory, "Files");
            string filePath = Path.Combine(folderPath, "names.txt");

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            if (!File.Exists(filePath))
            {
                File.Create(filePath).Dispose();
            }

            // Optional: Print the path so you can see where the file was created
            Console.WriteLine($"File created at: {filePath}");
        }
    }
    
}
