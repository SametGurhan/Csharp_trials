using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _88._12._2_interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[3]
            {
                new Manager(),
                new Worker(),
                new Robot()
            };

            foreach(var worker in workers)
            {
                worker.Work();
                Console.WriteLine("----------------------");
            }

            IEat[] eats = new IEat[2]
            {
                new Worker(),
            new Manager()
            };
            foreach (var eat in eats)
            {
                Console.WriteLine("______________________");
                eat.Eat();
            }

            Console.ReadLine();
        }
    }





    interface IWorker
    {
        void Work();
    }
    interface IEat
    {
        void Eat();
    }
    interface ISalary
    {
        void Salary();
    }
    class Manager : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            Console.WriteLine("Manager ate own meal.");
        }

        public void Salary()
        {
            Console.WriteLine("Manager got salary.");
        }

        public void Work()
        {
            Console.WriteLine("Manager still works...");
        }
    }
    class Worker : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            Console.WriteLine("Worker ate own meal.");
        }

        public void Salary()
        {
            Console.WriteLine("Worker got salary.");
        }

        public void Work()
        {
            Console.WriteLine("Worker still works...");
        }

    }

    class Robot:IWorker
    {

        public void Work()
        {
            Console.WriteLine("Robot still works...");
        }
    }

}
