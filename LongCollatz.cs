using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProjectEuler {
    class LongCollatz {

        public static void Get() {
            var l = 1;
            var i = 1;
            long s = 1;
            while (i < 1000000) {
                var cl = GetColl(i);
                if (cl.Count > l) {
                    s = cl[0];
                    l = cl.Count;
                }
                i++;
            }
            Console.WriteLine(s);
        }

        public static long IsOdd(long i) {
            return 3 * i + 1;
        }

        public static long IsEven(long i) {
            return i / 2;
        }

        public static List<long> GetColl(long i) {
            var s = new List<long>();
            while (i != 1) {
                s.Add(i);
                if (i % 2 == 0) {
                    i = IsEven(i);
                }
                else {
                    i = IsOdd(i);
                }
            }
            return s;
        }
    }
}
