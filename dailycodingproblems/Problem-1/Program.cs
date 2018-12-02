using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Array.ConvertAll(args[0].Split(','), s => int.Parse(s));
            int result = int.Parse(args[1]);
            bool flag = false;
            HashSet<int> hashSet = new HashSet<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (hashSet.Contains(result - arr[i])) flag = true;
                hashSet.Add(arr[i]);
            }
            if (flag)
            {
                Console.WriteLine("Present");
            }
            else
            {
                Console.WriteLine("Not Present");
            }
        }
    }
}
