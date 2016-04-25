using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._6
{
    /// <summary>
    /// Программа содержит метод выводящий информацию обо всех седловых точках матрицы
    /// </summary>
    class Program
    {
       
        /// <summary>
        /// Эта функция находит минимальное значение в строке матрицы
        /// </summary>
        /// <param name="array_row">
        /// Матрица, минимальное значение строки которой нужно найти
        /// </param>
        ///  <param name="i">
        /// Номер строки, минимальное значение которой нужно найти
        /// </param>
        /// <returns></returns>
        static int MinValueInRow (int [,] array_row, int i)
        {
            int min = array_row[i,0];

            for (int j = 0; j < array_row.GetLength(1); j++)
                if (array_row[i, j] < min)
                    min = array_row[i,j];

            return min;
        }

        /// <summary>
        /// Эта функция находит максимальное значение в столбце матрицы
        /// </summary>
        /// <param name="array_row">
        /// Матрица, максимальное значение столбца которого нужно найти
        /// </param>
        ///  <param name="j">
        /// Номер столбца, максимальное значение которого нужно найти
        /// </param>
        /// <returns></returns>
        static int MaxValueInColumn(int[,] array_row, int j)
        {
            int max = array_row[0, j];

            for (int i = 0; i < array_row.GetLength(0); i++)
                if (array_row[i, j] > max)
                    max = array_row[i, j];

            return max;
        }

        /// <summary>
        /// Эта функция находит минимальные значения в каждой строке
        /// </summary>
        /// <param name="matrix">
        /// Эта матрица, минимальные значения строк которой нужно найти
        /// </param>
        /// <returns>
        /// Возвращается true - если элемент минимальный в строке, иначе - false  
        /// </returns>
        static bool [,] MinInRow (int [,] matrix)
        {
            bool [,] min_in_row = new bool [matrix.GetLength(0),matrix.GetLength(1)]; 

            for (int i=0; i< min_in_row.GetLength(0); i++)
            {
                int min = MinValueInRow(matrix,i);

                for (int j=0; j< min_in_row.GetLength(1); j++)
                {
                    if (matrix[i, j] == min)
                    {
                        min_in_row[i, j] = true;
                    }
                    else
                        min_in_row[i, j] = false;
                }
            }

            return min_in_row;
        }

        /// <summary>
        /// Эта функция находит максимальные значения в каждом столбце
        /// </summary>
        /// <param name="matrix">
        /// Эта матрица, максимальные значения столбца которой нужно найти
        /// </param>
        /// <returns>
        /// Возвращается true - если элемент максимальный в строке, иначе - false  
        /// </returns>
        static bool[,] MaxInColumn(int[,] matrix)
        {
            bool[,] max_in_column = new bool[matrix.GetLength(0), matrix.GetLength(1)];

            for (int j = 0; j < max_in_column.GetLength(1); j++)
            {
                int max = MaxValueInColumn(matrix,j);

                for (int i = 0; i < max_in_column.GetLength(0); i++)
                {
                    if (matrix[i, j] == max)
                    {
                        max_in_column[i, j] = true;
                    }
                    else
                        max_in_column[i, j] = false;
                }
            }

            return max_in_column;
        }


        /// <summary>
        /// Выводит информацию обо всех седловых точках матрицы
        /// </summary>
        /// <param name="matrix">Матрица</param>
        static void SaddlePoint (int [,]matrix)
        {
            bool[,] min = MinInRow(matrix);
            bool[,] max = MaxInColumn(matrix);
            string result = "";
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                    if (min[i, j] == true && max[i, j] == true)
                        result+="Седловая точка " + matrix[i, j] + " расположена в строке " + i + " и столбце " + j + "\n";
            }

            if (result != "")
                Console.WriteLine(result);
            else
                Console.WriteLine("Данная матрица не имеет седловых точек");
        }

        //удалаяем лишние знаки
        static void DeleteExtraSpaces (ref string string_array)
        {

            for (int i = 0; i < string_array.Length; i++)
                if ((string_array[i] < '0' || string_array[i] > '9') && (string_array[i] != '-') && (string_array[i] != '\n'))
                {
                    string_array = string_array.Replace(string_array[i], ' ');

                    if ((i + 1 < string_array.Length) && ((string_array[i + 1] < '0' || string_array[i + 1] > '9') && (string_array[i + 1] != '-') && (string_array[i + 1] != '\n')))
                    {
                        string_array = string_array.Remove(i + 1, 1);
                        i--;
                    }
                }

        }

        //из строки получаем строку матрицы
        static void Get_array_from_string(string string_array, int [,] matrix, int i)
        {
            int n = 0;

            //if (string_array.Contains("  "))
                //throw new Exception("Веедены не корректные символы!");
            if (string_array.Length !=0 && string_array.Last() == ' ')
                string_array = string_array.Remove(string_array.Length - 1, 1);
            if (string_array.Length != 0 && string_array.First() == ' ')
                string_array = string_array.Remove(0, 1);


            foreach (char c in string_array)
            {

                if (c == ' ')
                    n++;
                else
                    if ((c < '0' || c > '9') && c != '-')
                    throw new Exception("Веедены не корректные символы!");
            }

            //int[] array = new int[n + 1];
            int j = 0;
            string tmp = "";

            foreach (char c in string_array)
            {
                if (c != ' ')
                {
                    tmp += c;
                }
                else
                {
                    if (j < matrix.GetLength(1))
                    {
                        if (tmp == "")
                            matrix[i, j] = 0;
                        else
                        {
                            matrix[i, j] = Int32.Parse(tmp);
                            tmp = "";
                        }
                        j++;
                    }
                }
            }
              if  (j < matrix.GetLength(1))
                if (tmp == "")
                    matrix[i, j] = 0;
                else
                    matrix[i,j] = Int32.Parse(tmp);

           // return array;
        }


        static void Main(string[] args)
        {
            /* int[,] matrix = new int[3, 4];
             //Fill matrix
             Random rand = new Random();
             for (int i = 0; i < matrix.GetLength(0); i++)
                 for (int j = 0; j < matrix.GetLength(1); j++)
                     matrix[i, j] = rand.Next(-5,10);
             //

             //Print matrix
             for (int i = 0; i < matrix.GetLength(0); i++)
             {
                 for (int j = 0; j < matrix.GetLength(1); j++)
                     Console.Write(matrix[i, j]+"\t");
                 Console.WriteLine();
             }
             Console.WriteLine();
             //

             //Print MinInRow
             bool[,] min = MinInRow(matrix);

             for (int i = 0; i < min.GetLength(0); i++)
             {
                 for (int j = 0; j < min.GetLength(1); j++)
                     Console.Write(min[i, j] + "\t");
                 Console.WriteLine();
             }
             Console.WriteLine();
             //


             //Print MaxInColumn
             bool[,] max = MaxInColumn(matrix);

             for (int i = 0; i < max.GetLength(0); i++)
             {
                 for (int j = 0; j < max.GetLength(1); j++)
                     Console.Write(max[i, j] + "\t");
                 Console.WriteLine();
             }
             Console.WriteLine();
             //

             SaddlePoint(matrix);
             */
            Console.WriteLine("Введите количество строк в матрице");
            int n = 0;
            n = GetNumberFromConsole();

            Console.WriteLine("Введите количество столцбов в матрице");
            int m = GetNumberFromConsole();
            int[,] matrixx = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                //Console.WriteLine("Введите {0} строку",i);
                string string_array = Console.ReadLine();
                DeleteExtraSpaces(ref string_array);
                Get_array_from_string(string_array, matrixx, i);

            }


            for (int i = 0; i < matrixx.GetLength(0); i++)
            {
                for (int j = 0; j < matrixx.GetLength(1); j++)
                    Console.Write(matrixx[i, j] + "\t");
                Console.WriteLine();
            }
            Console.WriteLine();


            SaddlePoint(matrixx);
        }

        static int iEx = 0;
        private static int GetNumberFromConsole()
        {
            string[] exArray = new string[2];
            exArray[0] = "Не умничай!!!";
            exArray[1] = "Написано же не умничай!!!";
            int n;
            
            while (!Int32.TryParse(Console.ReadLine(), out n))
            {
                Write(exArray[iEx], ConsoleColor.Red);
                iEx = (iEx == 0) ? 1 : 0;
            }

            return n;
        }

        private static void Write(string v, ConsoleColor color= ConsoleColor.Black)
        {
            System.Console.ForegroundColor = color;
            System.Console.WriteLine(v);
            Console.ResetColor();
        }
    }
}
