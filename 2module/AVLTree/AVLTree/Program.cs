using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVLTree
{
    
    class Program
    {
        static void Main(string[] args)
        {

            AVLTree<int> avletree = new AVLTree<int>(Comparer<int>.Default);

            avletree.Add(1);

            avletree.PrintTree();

            avletree.Add(2);
            avletree.PrintTree();
            avletree.Add(3);
            avletree.PrintTree();
            avletree.Add(4);
            avletree.PrintTree();
            avletree.Add(5);
            avletree.PrintTree();


            
            avletree.Add(4);

            avletree.Add(3);
            avletree.PrintTree();

            avletree.Delete(3);
            avletree.PrintTree();



            avletree.Add(1);
            avletree.PrintTree();

            avletree.Add(6);
            avletree.PrintTree();


            avletree.Add(5);
            avletree.PrintTree();

            avletree.Add(2);
            avletree.PrintTree();

            bool exist =  avletree.Search(5);
            Console.WriteLine("exist = ", exist);

            int min = avletree.SearchMin();
            Console.WriteLine("min = ", min);

            //       avletree.Add(4);
            //        avletree.PrintTree();

            //       avletree.Add(3);
            //       avletree.PrintTree();

            //       avletree.Add(2);
            //       avletree.PrintTree();



            //  avletree.Print();
            //  avletree.Delete(1);
            //  avletree.Print();

        }
    }
}
