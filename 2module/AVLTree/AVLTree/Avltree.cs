using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVLTree
{
    public class AVLTree<T>
    {
        private IComparer<T> _comparer;

        public AVLTree(IComparer<T> comparer)
        {
            _comparer = comparer;
        }

        private class TreeNote<T>
        {
            public T data { get; set; }
            public TreeNote<T> left;
            public TreeNote<T> right;
            public int lengthleft { get { return (left != null) ? left.length : 0; } }
            public int lengthright
            { get { return (right != null) ? right.length : 0; } }
            public int length = 1;
            public TreeNote<T> up;

            public int GetLength()
            {
                length = Math.Max(lengthleft, lengthright) + 1;
                return length;
            }
        }

        private void PrintTree(TreeNote<T> current, int left = 30, int top = 0)
        {
            Console.SetCursorPosition(left, top);
            //Console.Write("{0}({1},{2}) u{3}",current.data, current.lengthleft, current.lengthright, current.up.data);
            Console.Write("{0}", current.data);

            if (current.left != null)
                PrintTree(current.left, left - 5, top + 1);

            if (current.right != null)
                PrintTree(current.right, left + 5, top + 1);
            Console.WriteLine();
        }

        public void PrintTree()
        {
          //  Console.Clear();
          //  PrintTree(_root);
        }

        private TreeNote<T> _root;

        private void Add(ref TreeNote<T> current, T item, TreeNote<T> up)
        {
            if (current == null)
            {
                current = new TreeNote<T>();
                current.data = item;
                if (up != null)
                    current.up = up;
                return;
            }
            if (_comparer.Compare(item, current.data) <= 0)
            {//item <= curent.data
                Add(ref current.left, item, current);
            }
            else
            {//item > curent.data
                Add(ref current.right, item, current);
            }
            PrintTree();
            current.GetLength();
            Balance(ref current);
        }

        public void Add(T item)
        {
            TreeNote<T> temp = null;
            if (_root == null)
                temp = new TreeNote<T>();
            Add(ref _root, item, temp);
        }

        private TreeNote<T> Search(TreeNote<T> root, T data)
        {
            if (_comparer.Compare(data, root.data) < 0)
                //ищем слева от корня
                return (root.left != null) ? Search(root.left, data) : null;
            else
                if (_comparer.Compare(data, root.data) > 0)
                //ищем справа
                return (root.right != null) ? Search(root.right, data) : null;
            else
                return root;
        }

        public bool Search(T data)
        {
            if (Search(_root, data) != null)
                return true;
            else
                return false;
        }

        private TreeNote<T> SearchMin(TreeNote<T> root)
        {
            if (root.left != null)
                return SearchMin(root.left);
            else
                return root;
        }

        public T SearchMin()
        {
            return SearchMin(_root).data;
        }
        //удаление первого вхождения
        private bool DeleteData(T data)
        {
            TreeNote<T> root = Search(_root, data);
            if (root != null)
            {

                //удаляем элемент
                if (root.right != null)
                {
                    TreeNote<T> minright = SearchMin(root.right);
                    root.data = minright.data;
                    minright.up.left = null;
                    //DecLeftLength(ref minright);
                    DeleteBalance(ref minright.up);
                    return true;
                }
                else
                {
                    if (root.up.left == root)
                    {
                        root.up.left = root.left;//заменяем удаляемое значение на левое от удаляемого 
                        DeleteBalance(ref root.up);
                    }
                    else
                    {
                        root.up.right = root.right;//заменяем удаляемое значение на левое от удаляемого 
                        DeleteBalance(ref root.up);
                    }
                    return true;
                }
            }
            else
                return false;
        }

        public void Delete(T data)
        {
            if (DeleteData(data))
                Console.WriteLine("Элемент {0} успешно удален", data);
            else
                Console.WriteLine("Элемент {0} не удален, так как он не найден", data);
        }

        private void DeleteBalance(ref TreeNote<T> current)
        {
            Balance(ref current);
            if (current != _root)
                DeleteBalance(ref current.up);
        }

        private void Balance(ref TreeNote<T> current)
        {
            if (current.lengthleft > current.lengthright + 1)
            {
                //либо левый-левый, либо левый-правый
                TreeNote<T> downleft = current.left;
                if (downleft.lengthleft > downleft.lengthright)
                    //левый-левый
                    RightRotate(ref current);
                //левый-правый
                else
                    LeftRightRotate(ref current);
            }
            else
                if (current.lengthright > current.lengthleft + 1)
            //либо правый-правый, либо правый-левый
            {
                TreeNote<T> downright = current.right;
                if (downright.lengthright > downright.lengthleft)
                    //правый-правый
                    LeftRotate(ref current);
                //правый-левый
                else
                    RightLeftRotate(ref current);
            }
        }

        private void RightLeftRotate(ref TreeNote<T> current)
        {
            RightRotate(ref current.right);
            PrintTree();
            LeftRotate(ref current);
            PrintTree();

        }

        private void LeftRightRotate(ref TreeNote<T> current)
        {
            LeftRotate(ref current.left);
            PrintTree();

            RightRotate(ref current);
            PrintTree();
        }

        private void LeftRotate(ref TreeNote<T> current)
        {
            this.Change(ref current, ref current.right);
            PrintTree();
        }

        private void Change(ref TreeNote<T> current, ref TreeNote<T> down)
        {
            TreeNote<T> tmp_cur = current;
            TreeNote<T> tmp = null;
            if (current.right == down)
                tmp = down.left;
            else
                tmp = down.right;
            TreeNote<T> tmp_down = down;

            down.up = current.up;

            if (current.up.right == current)
                current.up.right = down;
            else if (current.up.left == current)
                current.up.left = down;
            else if (_root == current)
                _root = down;
            else
                throw (new Exception("???"));

            if (tmp_cur.right == down)
            {
                tmp_cur.right = down.left;
                tmp_down.left = tmp_cur;
                if (tmp_cur.right != null)
                    tmp_cur.right.up = tmp_cur;
            }
            else
            {
                tmp_cur.left = down.right;
                tmp_down.right = tmp_cur;
                if (tmp_cur.left != null)
                    tmp_cur.left.up = tmp_cur;
            }


            tmp_cur.up = tmp_down;

            if (tmp != null)
                tmp.up = tmp_cur;


            tmp_cur.up = current;

            PrintTree();

            if (down != null)
                down.GetLength();
            if (current != null)
                current.GetLength();
        }

        private void RightRotate(ref TreeNote<T> current)
        {
            this.Change(ref current, ref current.left);
            PrintTree();
        }

        public void Print()
        {
            Print(_root);
        }

        private void Print(TreeNote<T> current)
        {
            if (current.left != null)
                Print(current.left);
            Console.Write(current.data + " ");
            if (current.right != null)
                Print(current.right);
        }
    }
}
