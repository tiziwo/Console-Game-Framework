using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameworkExamples
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static int ReadInt()
        {
            int result = 0;
            do
            {
                Console.WriteLine("Введите число:");
            }
            while (int.TryParse(Console.ReadLine(), out result) == false);

            return result;
        }
    }
}
