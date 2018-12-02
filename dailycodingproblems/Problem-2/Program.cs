using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Array.ConvertAll(args[0].Split(','), s => int.Parse(s));

            int[] result = new int[arr.Length];

            int Product = arr.Aggregate(1, (a, b) => a * b);

            for(int i=0;i< arr.Length; i++)
            {
                //result[i] = Product / arr[i];
                result[i] = arr.Where(s=> s!= arr[i]).Aggregate(1, (a, b) => a * b);
            }

            Console.WriteLine(string.Join(",",result));

            Console.ReadKey();
        }
    }
}
