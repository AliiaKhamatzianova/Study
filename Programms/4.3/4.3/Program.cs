using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _4._3
{
    class Program
    {
        public struct Point
        {
            public Point(double x, double y)
            {
                X = x;
                Y = y;
            }
            public double X { get; set; }
            public double Y { get; set; }

            public override string ToString()
            {
                return string.Format("{0},{1}", X, Y);
            }
        }

        public struct Line
        {
            
            public Line(Point start0, Point end0)
            {
                start = start0;
                end = end0;
            }

            public Point start
            {
                get;
                set;
            }
            public Point end { get; set; }

            public double Length
            {
                get
                {
                    return Math.Sqrt( Math.Pow((start.X-end.X),2)+Math.Pow((start.Y-end.Y),2));
               }
                private set { }
            }

        }

        public static Line[] ReadLines (StreamReader input)
        {
           
            using (input)
            {
                Line[] Lines = new Line[Int32.Parse(input.ReadLine())];
                int i = 0;
                while (!input.EndOfStream)
                {
                    var sr = input.ReadLine().Split(' ').ToArray();
                    Point point1 = new Point(Double.Parse(sr[0]), (Double.Parse(sr[1])));
                    Point point2 = new Point(Double.Parse(sr[2]), (Double.Parse(sr[3])));

                    Lines[i] = new Line(point1, point2);
                    i++;  

                }
                return Lines;
            }
                
        }

        public static void PrintLines(Line[] Lines)
        {
            var output_file = new FileInfo("output.txt");
            if (output_file.Exists)
            {
                output_file.Delete();
            }
            var output = new StreamWriter("output.txt", true);
            using (output)
            {
                for (int i=0; i<Lines.Length;i++)
                    output.WriteLine(Lines[i].start.ToString()+" "+Lines[i].end.ToString()+" "+Lines[i].Length);
            }
        }


        static void Main(string[] args)
        {
            var input = new StreamReader("input.txt");
            PrintLines(ReadLines(input));

        }
    }
}
