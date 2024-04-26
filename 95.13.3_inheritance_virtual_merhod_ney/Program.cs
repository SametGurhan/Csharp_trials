using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _95._13._3_inheritance_virtual_merhod_ney
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlServer sqlServer = new SqlServer();
            sqlServer.Add();
            MySql mySql = new MySql();
            mySql.Add();
            Console.ReadLine();
        }
    }
    class Dataase
    {// virtual sql serverları baglama icin kullanılmalıdır ,normal add delete update gibi islem görmedigi icin.
        public virtual void Add()
        {
            Console.WriteLine("Added by default");
        }
        public virtual void Delete()
        {
            Console.WriteLine("Deleted by default");

        }

    }
    class SqlServer:Dataase
    {
        //override yazıca otomatik gelir
        public override void Add()
        {
            Console.WriteLine("Added by sql server");
            base.Add();
        }
    }

    class MySql:Dataase
    {

    }

}
