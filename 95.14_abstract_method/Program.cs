using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _95._14_abstract_method
{
    class Program
    {
        static void Main(string[] args)
        {
            Database database = new Oracle();

            database.Add();
            database.Delete();

            Database database2 = new SqlServer();

            database2.Add();
            database2.Delete();
            Console.ReadLine();

        }
    }
    //abstract classlarda inheritance kapsamında iş görür bir sınıftır
    abstract class Database
    {// tamamlanmamış metholar oluşturabilirsin interfaceler aksine.
        //deletelerde farklı işlem görüldü dikkat.
        public void Add()
        {
            Console.WriteLine("Added by default");
        }
        public abstract void Delete();
    }
    class SqlServer:Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by sql");
        }
    }
    class Oracle :Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by oracle");
            
        }
    }
}
