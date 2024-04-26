using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kapsülleme.ödev
{
    public class personel
    {
        private string tckimlikno;
        public string TCKİMLİKNO
        {
            get 
            {
                return tckimlikno.Substring(0, 5)+"******";
            }

            set 
            {
                bool kontrol = false;


                if(value.Length==11)
                {
                    for(int i=0;i<value.Length;i++)
                    {
                        bool sayimi = char.IsNumber(value[i]);//123a56789
                        if(sayimi)
                        {
                            //bişi yapmasın
                        }

                        else
                        {
                            kontrol = true;
                            break;
                        }

                    }
                    
                    if(kontrol)
                    {
                        Console.WriteLine("TC kimlik nonuzda geçersiz karakter bulundu.");
                    }
                    else
                    {
                        tckimlikno = value;
                    }

                }
                else 
                {
                    Console.WriteLine("Girdiğiniz tc kimlik no 11 haneli değildir...");
                }
            }
        }
        




    }
}
