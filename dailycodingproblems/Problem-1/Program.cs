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
            //Get args into arrays
            int[] arr = Array.ConvertAll(args[0].Split(','), s => int.Parse(s));
            int total = int.Parse(args[1]);
            bool flag = false;
            //HashSet to Add numbers
            HashSet<int> hashSet = new HashSet<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (hashSet.Contains(total - arr[i]))
                { flag = true; continue; }
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
