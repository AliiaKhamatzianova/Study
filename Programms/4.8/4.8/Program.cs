using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _4._8
{
    class Program
    {
        public static void MoveFiles(string sourceDir, string destinationDir, string extension )
        {
            DirectoryInfo source = new DirectoryInfo(sourceDir);

            var files = source.GetFiles();

            foreach (var file in files)
            {
                if (file.Extension == extension)
                    try
                    {
                        
                        file.MoveTo(destinationDir+@"\"+file.Name);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
            }
               
        }
        static void Main(string[] args)
        {
             Console.WriteLine("Введите исходную папку");
             string source = Console.ReadLine();
             Console.WriteLine("Введите конечую папку");
             string destination = Console.ReadLine();
             Console.WriteLine("Введите расширение");
             string extension = Console.ReadLine();
             
            MoveFiles(source,destination,extension);
        }
    }
}
