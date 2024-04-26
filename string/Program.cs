using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @string
{
    class Program
    {
        static void Main(string[] args)
        {
            //string içeerisinde metin tutabilir.
            /*string içerisine veri "" ile tanımlanır
            string 16byte yer kaplar
            */
            //string isim = "samedov";
            //string soyisim = "Gürhanova";
            //string a = "deneme yapıyorum=)";
            //Console.WriteLine(isim);   
            //Console.WriteLine(soyisim);
            //Console.WriteLine(a);
            //_____________________________________
            string sentence = "ben samet gürhan as";
            var result = sentence.Length;
            var result2 = sentence.Clone();
            bool result3 = sentence.StartsWith("ben");
            bool result4 = sentence.EndsWith("sa");
            var result5 = sentence.IndexOf("samet");
            var result6 = sentence.LastIndexOf("ben");
            var result7= sentence.Insert(0,"sa, ");
            var result8= sentence.Substring(3);
            var result9= sentence.Replace(" ","-");
            var result10= sentence.Remove(3,6);//3.den sonra 6tane siler gerisini yazar
            var result11= sentence.Remove(3);//3.den sonrasını siler
           // sentence = "ben samet gürhan değilim";
            Console.WriteLine(sentence);
            Console.WriteLine("sentence öğemiz "+result+" adet birim içeriyor.");
            Console.WriteLine(result2);       
            Console.WriteLine("sentence öğemiz 'ben' ile mi başlıyor: "+result3);
            Console.WriteLine("sentence öğemiz 'sa' ile mi bitiyor: "+result4);
            Console.WriteLine("sentence öğemizde 'samet'in indexi :"+result5);
            Console.WriteLine("sentence öğemizde 'samet'in indexi :"+ result6);
            Console.WriteLine(result7);
            Console.WriteLine(result8);
            Console.WriteLine(result9);
            Console.WriteLine(result10);
            Console.WriteLine(result11);
            Console.ReadLine();
        }
    }
}
