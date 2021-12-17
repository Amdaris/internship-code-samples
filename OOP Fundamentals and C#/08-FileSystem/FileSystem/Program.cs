using System;
using System.IO;
using System.Threading.Tasks;

namespace FileSystem
{
    class Program
    {
        static async Task Main(string[] args)
        {
            DriveInfo[] driveInfo = DriveInfo.GetDrives();

            foreach (var info in driveInfo)
            {
                Console.WriteLine($"{info.Name}, {info.IsReady}, {info.AvailableFreeSpace}");
            }

            var dirInfo = new DirectoryInfo(Directory.GetCurrentDirectory());

            Console.WriteLine(dirInfo.Name);
            var parent = dirInfo.Parent;
            Console.WriteLine(parent.Name);

            var files = dirInfo.GetFiles();

            foreach (var item in files)
            {
                Console.WriteLine($"{item.Name}, {item.Extension}, {item.DirectoryName}");
            }

            var newDirPath = Path.Combine(Directory.GetCurrentDirectory(), "MyFolder");
            Directory.CreateDirectory(newDirPath);

            var newFile = Path.Combine(newDirPath, "example.txt");
            File.Create(newFile);

            var textFile = Path.Combine(newDirPath, "hello.txt");
            var fileStream = File.Create(textFile);

            var sw = new StreamWriter(fileStream);
            for (int i = 1; i <= 10; i++)
            {
                await sw.WriteLineAsync($"This is line number: {i}");
            }
            sw.Close();

            using (var sr = new StreamReader(textFile))
            {
                var read = true;

                while (read)
                {
                    var line = sr.ReadLine();
                    if (string.IsNullOrEmpty(line))
                        read = false;
                    else Console.WriteLine(line);
                }
            }
            


            var otherSr = new StreamReader(textFile);
            Console.WriteLine(otherSr.ReadToEnd());

            otherSr.Close();
        }
    }
}
