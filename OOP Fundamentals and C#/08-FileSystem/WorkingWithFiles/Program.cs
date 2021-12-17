using System;
using System.IO;

namespace WorkingWithFiles
{
    class Program
    {
        static void Main(string[] args)
        {

            var newDirPath = Path.Combine(Directory.GetCurrentDirectory(), "MyNewFolder");
            Directory.CreateDirectory(newDirPath);

            var newFilePath = Path.Combine(newDirPath, "MyFile.txt");
            
            var fileStream = File.Create(newFilePath);

            using (var sw = new StreamWriter(fileStream))
            {
                for (int i = 1; i <= 10; i++)
                {
                    sw.WriteLine($"This is line number: {i}");
                }
            }
            

            using var sr = new StreamReader(newFilePath);
            var read = true;

            while (read)
            {
                var line = sr.ReadLine();
                if (string.IsNullOrEmpty(line))
                    read = false;
                Console.WriteLine(line);
            }

            using var sr2 = new StreamReader(newFilePath);
            Console.WriteLine(sr2.ReadToEnd());
            sr2.Close();
        }
    }
}
