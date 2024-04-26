using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _87._12._1_interfaceler_giris
{
    class Program
    {
        static void Main(string[] args)
        {
            //InterfacesIntro();
            //DemoManagerServers();
            ICustomerDal[] customerDals = new ICustomerDal[2] 
            { 
                new SqlServerCustomerDal(),
                new OracleServerCustomerDal() 
            };
            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }
            Console.ReadLine();
        }
        private static void DemoManagerServers()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new OracleServerCustomerDal());
        }
        private static void InterfacesIntro()
        {
            PersonManager manager = new PersonManager();
            // manager.Add(new Customer {Id=1,FirstName="Samet",LastName="Gürhan",Adress="Kocaeli" });
            //veya
            Customer customer = new Customer
            {
                Id = 1,
                FirstName = "Samet",
                LastName = "Gürhan",
                Adress = "Kocaeli"
            };

            Student student = new Student
            {
                Id = 2,
                FirstName = "Emel",
                LastName = "Sayın",
                Departmant = "C.E."
            };

            manager.Add(customer);
            manager.Add(student);

        }

        interface Iperson
        {
            int Id { get; set; }
            string FirstName { get; set; }
            string LastName { get; set; }
        }

        class Customer : Iperson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Adress { get; set; }
        }

        class Student : Iperson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Departmant { get; set; }
        }

        class Worker : Iperson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Departmant { get; set; }
        }
        class PersonManager
        {
            public void Add(Iperson person)
            {
                Console.WriteLine(person.FirstName);
            }
        }
    }
}
