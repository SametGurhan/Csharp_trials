using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _100._20._1_Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string[] students = new string[3] {"Engin","Derin","Salih"};
                students[3] = "Samet";

            }
            catch(IndexOutOfRangeException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (DivideByZeroException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            Console.ReadLine();

        }
    }
}
