namespace FileString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string appPath = @"..\..\..\";

            string folderPath = appPath + @"myFolder\";
            string filePath = folderPath + @"test.txt";

            string combinePaths = Path.Combine(folderPath, "test.txt");
            Console.WriteLine(combinePaths);

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
                Console.WriteLine($"Directorycreated {folderPath}");
            }
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                sw.WriteLine("Hello World");
                sw.WriteLine("This is a test file.");
               
                Console.WriteLine("writing in the file complete!");
            }
            
        }
    }
}
