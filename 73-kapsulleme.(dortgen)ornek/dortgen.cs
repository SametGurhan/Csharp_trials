using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _73_kapsulleme._dortgen_ornek
{
    class dortgen
    {

        private int boy;

        public int Boy
        {
            get { return boy; }
            set
            {
                if (value < 0)
                { boy = 0; }
                else
                { boy = value; }
            }
        }
        private int en;


        public int En
        {
            get { return en; }
            set
            {
                if (value < 0)
                { en = 0; }
                else
                { en = value; }

            }
        }

        public int alan()
        {
            int sonuc = 0;
            sonuc = en * boy;
            return sonuc;
        }


    }
}
