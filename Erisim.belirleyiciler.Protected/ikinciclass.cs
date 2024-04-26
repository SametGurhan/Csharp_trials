using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erisim.belirleyiciler.Protected
{
    public class ikinciclass
    {
        private void privatemetot()
        {
            Console.WriteLine("Private metot çalıştı.");
        }

        protected void protectedmetot()
        {
            Console.WriteLine("Protected metot çalıştı..");
        }



    }
}
