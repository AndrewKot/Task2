using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FindingNumber;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            List<int> _int = new List<int>
            {
                1,2,3,4,5,6,9,8,7,5,1,2,3,6,5,4,3,2,1
            };

            List<int> _int2 = new List<int>
            {
                1,2,3,4,5,4,3,2,1,0,0,9
            };

            Console.WriteLine(FindingNumber.FundingNumberClass.LeftSum(_int, 3));
            Console.WriteLine(FindingNumber.FundingNumberClass.RightSum(_int, 3));

            Console.WriteLine();

            Console.WriteLine(FindingNumber.FundingNumberClass.Number(_int2));

            Console.ReadLine();
        }
    }
}
