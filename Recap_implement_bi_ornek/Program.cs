using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recap_implement_bi_ornek
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager1 = new CustomerManager();
            customerManager1.Logger = new DatabaseLogger();
            customerManager1.Add();
            Console.WriteLine("-----------------------------");
            CustomerManager customerManager2 = new CustomerManager();
            customerManager2.Logger = new SmsLogger();
            customerManager2.Add();   
            Console.WriteLine("-----------------------------");
            CustomerManager customerManager3 = new CustomerManager();
            customerManager3.Logger = new FileLogger();
            customerManager3.Add();
            Console.ReadLine();
        }
    }

    class CustomerManager
    {
        public Ilogger Logger { get; set; }
        public void Add()
        {
            Logger.Log();
            Console.WriteLine("Customer Added ++");
        }
    }
    class DatabaseLogger:Ilogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to database!");
        }
    }
    class FileLogger:Ilogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to file!");
        }
    }
    class SmsLogger : Ilogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to Sms!");
        }
    }
    interface Ilogger
    {
        void Log();
    }
}
