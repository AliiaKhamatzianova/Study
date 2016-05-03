using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _4._4
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
                    return Math.Sqrt(Math.Pow((start.X - end.X), 2) + Math.Pow((start.Y - end.Y), 2));
                }
                private set { }
            }

        }

        public struct Triangle
        {
            public Triangle(Point pt1,Point pt2,Point pt3) 
            {
                point1 = pt1;
                point2 = pt2;
                point3 = pt3;

                line1 = new Line(point1,point2);
                line2 = new Line(point2, point3);
                line3 = new Line(point3, point1);

            }
            private Point point1 { get; set; }
            private Point point2 { get; set; }
            private Point point3 { get; set; }

            private readonly Line line1;
            private readonly Line line2;
            private readonly Line line3;

            private double Perimeter()
            {
                return line1.Length + line2.Length + line3.Length;
            }

            private double HalfPerimeter()
            {
                return this.Perimeter()/2;
            }
            private double Square ()
            {
                return Math.Sqrt(HalfPerimeter()*(HalfPerimeter()-line1.Length)*(HalfPerimeter()-line2.Length)*(HalfPerimeter()-line3.Length));
            }
            public bool IsTriangle ()
            {
                if (line1.Length < line2.Length + line3.Length)
                    if (line2.Length < line1.Length + line3.Length)
                        if (line3.Length < line1.Length + line2.Length)
                            return true;
                        else
                            return false;
                    else
                        return false;
                else
                    return false; 

            }

            public void PrintTriangle (StreamWriter output)
            {
                    output.WriteLine(point1.ToString()+" "+point2.ToString()+" "+point3.ToString()+" "+Square()+" "+Perimeter());
            }
        }

        public static List <Triangle> ReadTriangle (StreamReader input)
        {
            using (input)
            {
                List<Triangle> triangles = new List<Triangle>();
                while (!input.EndOfStream)
                {
                    var sr = input.ReadLine().Split(' ').ToArray();
                    Point point1 = new Point(Double.Parse(sr[0]), (Double.Parse(sr[1])));
                    Point point2 = new Point(Double.Parse(sr[2]), (Double.Parse(sr[3])));
                    Point point3 = new Point(Double.Parse(sr[4]), (Double.Parse(sr[5])));
                    triangles.Add(new Triangle (point1,point2,point3));
                }
                return triangles; 
            }
        }
        static void Main(string[] args)
        {
            var input = new StreamReader("input.txt");
            List<Triangle> triangles = ReadTriangle(input);
            var output_file = new FileInfo("output.txt");
            if (output_file.Exists)
            {
                output_file.Delete();
            }
            var output = new StreamWriter("output.txt", true);
            using (output)
            {
                for (int i = 0; i < triangles.Count(); i++)
                    if (triangles[i].IsTriangle() == true)
                        triangles[i].PrintTriangle(output);
            }
        }
    }
}
