namespace QinshiftClass09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Directory stuff
            string currentDirectory = Directory.GetCurrentDirectory();
            Console.WriteLine(currentDirectory);

            string relativePath = @"..\..\..\";

            string absolutePath = "C:\\Users\\X\\Desktop\\Csharp-programming\\Schoolwork\\ADVANCED\\Class-09-FileSystem\\QinshiftClass09\\QinshiftClass09";

            string demoFolderPath = Path.Combine(absolutePath, "DemoFolder");
            if (!Directory.Exists(demoFolderPath))
            {
                Directory.CreateDirectory(demoFolderPath);
                Console.WriteLine($"Created folder: {demoFolderPath}");
            }
            else
            {
                Console.WriteLine($"Folder already exists: {demoFolderPath}");
            }

            /* Console.Write("Do you want to delete the DemoFolder? (y/n): ");
            string? input = Console.ReadLine();
            if (input != null && input.Trim().ToLower() == "y")
            {
                try
                {
                    Directory.Delete(demoFolderPath, true);
                    Console.WriteLine("DemoFolder deleted.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error deleting folder: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("DemoFolder was not deleted.");
            }
            */

            #endregion
            #region FileManipulation

            string folderPath = relativePath + @"DemoFolder_1\";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
                Console.WriteLine("A new folder has been created!");
            }

            string filePath = Path.Combine(folderPath, "demo.txt");
            if (!File.Exists(filePath))
            {
                File.WriteAllText(filePath, "hi dere");
                Console.WriteLine("A file was created and text was written!");
            }
            else
            {
                Console.WriteLine("File already exists: demo.txt");
            }
            string filePath2 = Path.Combine(folderPath, "demo2.txt");

        }

        #endregion

    }
}

