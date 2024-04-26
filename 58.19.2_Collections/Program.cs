using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _58._19._2_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //tek veri tipinde çalışmak istenmiyorsa arraylist mantıklıdır. Object aldığı için 
            //ArrayList();

            //tek veri tipinde çalışmak istiyosak Tip güvenlişk ile çalışmak gerek. 


            //List<Customer> customers = new List<Customer>();
            //customers.Add(new Customer { Id = 1, FirstName = "Samet" });
            //customers.Add(new Customer { Id = 2, FirstName = "Aylin" });
            //veya
            //ListStr();
            //ArrayList();
            //CollectionOzellik();
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("book","kitap");
            dictionary.Add("table","masa");
            dictionary.Add("computer","bilgisayar");

            Console.WriteLine(dictionary["book"]);
            Console.WriteLine(dictionary["table"]);

            Console.WriteLine("-----------------------------");
            foreach(var item in dictionary)
            {
                Console.WriteLine(item.Key); 
                Console.WriteLine(item.Value);
                Console.WriteLine(item);
                Console.WriteLine("__________________");
            }
            Console.WriteLine(dictionary.ContainsKey("glass"));
            Console.WriteLine(dictionary.ContainsKey("table"));
            Console.ReadLine();

        }


        private static void ListStr()
        {
            //string[] cities = new string[2] { "Ankara", "İstanbul" };
            //cities = new string[3];
            //Console.WriteLine(cities[0]);
            // boş yazdırır eski değergleri emptylenmiştir bu yüzden Collection kullanmak gerek
            List<string> cities = new List<string>();
            cities.Add("Ankara");
            cities.Add("İstanbul");

            if (cities.Contains("Ankara") == true)
            {
                Console.WriteLine("şehirlerde ankara var");

            }
            else
            {
                Console.WriteLine(" şehirlerde Ankara yook");
            }

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }
            Console.WriteLine("------------------");
        }
        private static void ArrayList()
        {
            ArrayList cities = new ArrayList();
            cities.Add("Ankara");
            cities.Add("Adana");
            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }
            cities.Add("İstanbul");
            cities.Add(1);//object
            cities.Add(true);//
            Console.WriteLine(cities[2]);
            Console.WriteLine(cities[3]);
            Console.WriteLine(cities[4]);
        }
    
        private static void CollectionOzellik() 
        {
            List<string> cities = new List<string>();
            cities.Add("Ankara");
            cities.Add("İstanbul");

            if (cities.Contains("Ankara") == true)
            {
                Console.WriteLine("şehirlerde ankara var");

            }
            else
            {
                Console.WriteLine(" şehirlerde Ankara yook");
            }

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }
            Console.WriteLine("------------------");

            //List<Customer> customers = new List<Customer>();
            //customers.Add(new Customer { Id = 1, FirstName = "Samet" });
            //customers.Add(new Customer { Id = 2, FirstName = "Aylin" });
            //veya
            List<Customer> customers = new List<Customer>
            {
               new Customer { Id = 1, FirstName = "Samet" },
               new Customer { Id = 2, FirstName = "Aylin" }
            };
            var customer2 = new Customer
            {
                Id = 3,
                FirstName = "Salih"
            };
            customers.Add(customer2);
            customers.AddRange(new Customer[2] {

                new Customer { Id=4,FirstName="Ali"},
                new Customer { Id=5,FirstName="Ayşe"}
            });


            Console.WriteLine(customers.Contains(new Customer { Id = 1, FirstName = "Engin" }));//yeni ref.
            Console.WriteLine(customers.Contains(customer2));
            Console.WriteLine("------------------");
            // customers.Clear();
            var index = customers.IndexOf(customer2);
            Console.WriteLine("3.üyenin Index:" + index);

            var index2 = customers.LastIndexOf(customer2);
            Console.WriteLine("3.üyenin (tersten aranarak) Index:" + index2);

            customers.Insert(0, customer2);

            //customers.Remove(customer2);//ilkini siler
            //customers.RemoveAll(c=>c.FirstName=="Salih");

            foreach (var customer in customers)
            {
                Console.WriteLine(customer.FirstName);
            }
            Console.WriteLine("------------------");
            var count = customers.Count;
            Console.WriteLine("Count : {0}", count);
        }
    
    
    
    }

   
    class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }


    }
}
