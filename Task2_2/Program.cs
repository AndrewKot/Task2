using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello it is 'Taks2_2'");

            List<string> dictionary = new List<string> { };
            //char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            string alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            string a = null;
            int flag = -1;
            do
            {
                Console.Clear();
                if (flag == -2)
                {
                    Console.WriteLine("error");
                }
                try
                {
                    a = Console.ReadLine();
                    flag = 0;
                }
                catch (Exception)
                {
                    Console.WriteLine("error");
                }
                if (a=="")
                {
                    flag = -2;
                    Console.WriteLine("error");
                }
            } while (flag!=0);
            Console.Clear();

            //int flag = 0;
            //char[] temp_a = new char[a.Length];
            //for (int i = 0; i < a.Length; i++)
            //{
            //    temp_a[i] = a[i];
            //}

            for (int i = 0; i < a.Length; i++)
            {
                if (alpha.ToLower().Contains(a[i]))
                {
                    Console.WriteLine("!");
                }
                else
                {
                    Console.WriteLine("-!");
                }
                
            }
            
            Console.WriteLine(flag);

            //Console.WriteLine(Convert.ToString(-15, 2));
            //Console.WriteLine(Convert.ToString(15, 2));
            //Console.WriteLine(Convert.ToString(1, 2));
            //Console.WriteLine(Convert.ToString(-1, 2));
            //Console.WriteLine(Convert.ToString(31, 2));

            Console.ReadLine();
        }
    }
}
