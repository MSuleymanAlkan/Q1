using System;

namespace LoodosQ1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First String:");
            string str1 = Console.ReadLine();
            Console.WriteLine("Enter Second String:");
            string str2 = Console.ReadLine();

            IComparePermutation compareService = new ComparePermutation();
            bool result = compareService.Compare(str1, str2);

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
