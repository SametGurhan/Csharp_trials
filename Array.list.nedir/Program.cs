using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array.list.nedir
{
    class Program
    {
        static void Main(string[] args)
        {//arraylist nedir...
            /* string[] isimler = { "Enes", "Ahmet", "Yusuf", "Ercan" };
             foreach(string a in isimler)
             {
                 Console.WriteLine(a);
             }
             Console.ReadLine();
            */
            ArrayList koleksiyon = new ArrayList();
            koleksiyon.Add("Samet");//add dizix sonuna istenen elemanı ekler
            koleksiyon.Add("Ahmet");
            koleksiyon.Add("Yunus");
            koleksiyon.Add("Selim");
            koleksiyon.Add("Mert");
            koleksiyon.Add("Mehmet");

            //koleksiyon.Remove("Mehmet"); direkt çıkartır

            //int count = koleksiyon.Count; //yazdırmalıdır.Veri sayısını yazdırır 

            //koleksiyon.Clear(); direkt ful siler

            //bool kontrol = koleksiyon.Contains("Samet");  //yazdırmalı aranan içerik aratır

            //int index=  koleksiyon.IndexOf("Yunus");//index sırası yazdırır arananın.

            // koleksiyon.Insert(3, "Sercan");// istenen indexli eleman atar diziye

            //koleksiyon.Reverse(); direkt diziyi tepe taklak eder, ters çevirir


            /*   foreach (var a in koleksiyon)
               {
                   Console.WriteLine(a);
               }

               Console.WriteLine("Dizinin eleman sayisi:"+count);
               Console.WriteLine("aranan var ifadesi doğru mu ?="+kontrol);
               Console.WriteLine("Yunusun indeks değeri:"+index);
               Console.ReadLine();
            */
            ArrayList rakamlar = new ArrayList();
            rakamlar.Add(31);
            rakamlar.Add(21);
            rakamlar.Add(54);
            rakamlar.Add(5);
            rakamlar.Add(7);

            rakamlar.Sort();//küçükten büyüğe sıralar
            foreach(int a in rakamlar)
            {
                Console.WriteLine(a);
            }
            /*
             int a=10;
            string b= a.ToString(); stringe cevirip yazdırabilirsin. bu bir hatırlatmaydı
             
             
             */
            Console.ReadLine();








        }
    }
}
