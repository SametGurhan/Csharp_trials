using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erisim.belirleyicinternal.test
{
    public class musteri
    {
        public void publicmetot()
        { 
            Console.WriteLine("public metot çalişti"); 
        }
        internal void internalmetot()
        {
            Console.WriteLine("İnternal metot çalişti");
        }

    }
}
