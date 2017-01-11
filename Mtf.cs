using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProjectEuler
{
    class Mtf
    {
        //O(n) solution
        public static int Mult3_5()
        {
            List<int> ml = new List<int>();

            for (int i = 0; i < 1000; i++)
            {
                if(i % 3 == 0 || i % 5 == 0)
                {
                    ml.Add(i);
                }
            }

            int sum = ml.Sum();
            Console.Write(sum);
            return ml.Sum();
        }

        //O(1) solution
        private static int Sdb(int n, int p)
        {
            return n * (p / n) * ((p / n) + 1) / 2;
        }

        public static void Solve()
        {
            int result = Sdb(3, 999) + Sdb(5, 999) - Sdb(15, 999);
            Console.Write(result);
        }
    }
}
