using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication2
{
    public static class SomeMethods
    {
        public static bool IsPrime(this int number)
        {
            if (number < 2)
                return false;
            for (int i = 2; i < number / 2 + 1; i++)
                if (number % i == 0)
                    return false;
            return true;
        }
    }
    class Program
    {
        public struct Point
        {
            public double X { get; set; }
            public double Y { get; set; }

            public override string ToString()
            {
                //string interpolation
                return string.Format("{0},{1}", X, Y);//$"((x),(y))";
            }
        }

        static void Main(string[] args)
        {
            #region
            /*var drives = DriveInfo.GetDrives();
            foreach (var drive in drives)
            {
                Console.WriteLine(drive.Name+" "+drive.DriveType);
            }

            var d = new DirectoryInfo("C:\\");
            if (d.Exists)
            {
                var Directories =d.GetDirectories();
                foreach (var dir in Directories)
                Console.WriteLine(dir.FullName);
            }

            FileInfo f = new FileInfo("C:\\runonce.reg");
            if (f.Exists)
            {
                //Console.WriteLine(f.FullName);
                Console.WriteLine(f.Directory.Root.Name);
            }
            */
            #endregion

            using (var sr = new StreamReader("input.txt"))
            {
                try
                {
                    int n = Int32.Parse(sr.ReadLine());
                    var points = new Point[n];

                    for (int i = 0; i < n; i++)
                    {
                        //var coord = sr.ReadLine().Split(' ').Select(x=>double.Parse(x)) ;
                        var coord = sr.ReadLine().Split(' ').ToArray();
                        points[i] = new Point({ X = double.Parse(coord[0]) ,  Y = double.Parse(coord[1])});
                     }

                    #region
                    /*
                    while (!sr.EndOfStream)
                    {
                        var numbers = sr.ReadLine().Split(" \n\t\r".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                        
                        int[] x = new int[numbers.Length];

                        for (int i = 0; i < x.Length; i++)
                        {
                            x[i] = Int32.Parse(numbers[i]);

                        }
                        Array.Sort(x);
                        foreach (var v in x)
                            Console.Write(v + " ");
                        Console.WriteLine();
                    }*/
                    #endregion
                }

                catch (Exception ex)
                {
                    if (ex is System.FormatException)
                        Console.WriteLine(ex.Message);
                }
            }
            }
    

        }
    }
}
