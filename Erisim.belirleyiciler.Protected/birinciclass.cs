using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erisim.belirleyiciler.Protected
{
    class birinciclass:ikinciclass
    {
        public birinciclass() 
        {
            protectedmetot();
            //privatemetot miras alınamaz başka classtan erişilemez
        }


    }
}
