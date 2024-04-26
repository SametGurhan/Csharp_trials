using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphsimGiris
{
    class Program
    {
        static void Main(string[] args)
        {//public virtual void ..
         //   publc override void
          //bir tip diğer tipleri kapsayabilip işlerini görüyor
            Hayvan hayvan = new Hayvan("Hayvan");
            hayvan.konus();
           
            Hayvan kedi = new kedi("Minnoş");//hayvan kediyi karşılayabildi . polymorphism
            kedi.konus();
           
            Köpek köpek = new Köpek("Karabaş");
            köpek.konus();

            Console.WriteLine("_____________________");
            hayvanlarikonustur(new kedi("minnoş"));
            hayvanlarikonustur(new Köpek("karabas"));
            Console.ReadLine();
        }
        public static void hayvanlarikonustur( Hayvan hayvan)//kısa yollu metot main dışı. 
        {
            hayvan.konus();
        }

       


    }
}
