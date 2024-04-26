using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace property.kulllanımı
{
    public class Musteri
    {
        /* açık saçık hali:
         private int kilo; // erisemiyorum  o yüzden propery kullanıcam
            //açık hali(kapalı hali prop+tab+tab)
          //public int KİLO 

          {
              get
              {
                  return kilo;
              }
              set 
              {
                  kilo = value;
              }
          }
        */
        // public int kilo1 { get; set; } // kısa property hali 
        //public int kilo2;//değişken
        public int Id { get; set; }
        
        //Encapsulation yapalım açalım yani.
        private string _name;
        public string name {
            get {return "Mr. or Mrs." + _name; }
            set { _name = value; } 
        }
        public string lastName { get; set; }
        public string city { get; set; }



    }
}
