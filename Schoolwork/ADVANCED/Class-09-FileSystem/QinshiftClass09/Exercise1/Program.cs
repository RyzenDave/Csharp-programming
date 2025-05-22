

namespace Exercise1
{
    public class Program
    {
        static void Main(string[] args)
        {
            string appPath = @"..\..\..\";
            string folderPath = appPath + @"Exercise\";
            string filePath = folderPath + @"Calcualtions.txt";

            string combinePaths = Path.Combine(folderPath, "test.txt");
            Console.WriteLine(combinePaths);

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
                Console.WriteLine($"Directory created {folderPath}");
            }



            using (StreamWriter sw = new StreamWriter(filePath))
            {
                sw.WriteLine("Hello World");
                sw.WriteLine("This is a test file.");
                sw.WriteLine(Calculator.Calculate());
                Console.WriteLine("writing in the file complete!");
                
            }
        }
    }
}   