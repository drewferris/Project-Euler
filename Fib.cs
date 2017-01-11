using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProjectEuler {

    class Fib {
        public static int Gf() {
            int sum = 0;
            var fl = new List<int>(); // fibonacci 
            fl.Add(1);

            int c;
            int p;
            p = 1;
            c = 2;

            while (c < 4000000) {
                var t = c;
                c = c + p;
                p = t;
                fl.Add(c);
            }

            foreach (var i in fl) {
                if (i % 2 == 0) {
                    sum += i;
                }
            }
            sum += 2;
            return sum;

        }

        //optimized solution

        public static long Ogf()  {
            long[] fs = { 2, 0 };
            int i = 0;
            long summed = 0;

            while (fs[i] < 4000000) {
                summed += fs[i];
                i = (i + 1) % 2;
                fs[i] = 4 * fs[(i + 1) % 2] + fs[i];
            }
            return summed;
        }

    }



}
