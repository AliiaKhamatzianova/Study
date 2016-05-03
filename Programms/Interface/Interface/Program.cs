using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    
    class Program
    {
        public interface IFly
        {
            void Fly();
        }

        public interface ICria
        {
            void Cria();
        }

        public class Flyable : IFly
        {
            virtual public void Fly()
            {
                Console.WriteLine("Fly");
            }
        }

        public class NotFlyable : IFly
        {
            virtual public void Fly()
            {
                Console.WriteLine("I can't fly");
            }
        }

        public class Criaable : ICria
        {
            virtual public void Cria()
            {
                Console.WriteLine("Cria-cria");
            }
        }

        public class NotCriaable : ICria
        {
            virtual public void Cria()
            {
                Console.WriteLine("I can't cria-cria");
            }
        }


        public abstract class Duck
        {
            abstract public void Fly();
            abstract public void Cria();
            
        }

        public class NormalDuck : Duck
        {
            public IFly ifly = new Flyable();
            public override void Fly()
            {
                ifly.Fly();
                //Console.WriteLine("Fly");
            }

            public ICria icria=new Criaable();
            public override void Cria()
            {
                icria.Cria();
                //Console.WriteLine("Cria-Cria");
            }
        }

        public class RubberDuck:Duck
        {

            public IFly ifly = new NotFlyable();
            public override void Fly()
            {
                ifly.Fly();
                //Console.WriteLine("Fly");
            }

            public ICria icria=new NotCriaable();
            public override void Cria()
            {
                icria.Cria();
                //Console.WriteLine("Cria-Cria");
            }
        }

        public class RobotDuck : Duck
        {
            public IFly ifly = new NotFlyable();
            public override void Fly()
            {
                ifly.Fly();
                //Console.WriteLine("Fly");
            }

            public ICria icria = new Criaable();
            public override void Cria()
            {
                icria.Cria();
                //Console.WriteLine("Cria-Cria");
            }
        }

        public static void FlyDucks ( List <Duck> ducks)
        {
            foreach (var duck in ducks)
            {
                Console.WriteLine("________________________\nduck :{0}", duck.GetType().ToString());
                //if (duck is IFly)
                duck.Fly();
                Console.WriteLine("_______________________");
            }
        }

        public static void CriaDucks(List<Duck> ducks)
        {

            foreach (var duck in ducks)
            {
                Console.WriteLine("________________________\nduck :{0}", duck.GetType().ToString());
                //if (duck is ICria)
                duck.Cria();
                Console.WriteLine("_______________________");
            }
        }

        static void Main(string[] args)
        {
            List <Duck> ducks = new List<Duck>();
            ducks.Add(new NormalDuck());
            ducks.Add(new NormalDuck());
            ducks.Add(new RubberDuck());
            ducks.Add(new RobotDuck());
            FlyDucks(ducks);
            CriaDucks(ducks);

        }
    }
}
