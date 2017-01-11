using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProjectEuler {
    class SummationOfPrimes {

        public static bool IsPrime(long n) {
            if ((n & 1) == 0) return n == 2;

            for (var i = 3; i <= (int)Math.Sqrt(n); i += 2) {
                if (n % i == 0) return false;
            }
            return true;
        }

        public static long Get(int n) {
            var  pl = new List<long>();
            for (long i = 0; i < n; i++) {
                if (IsPrime(i)) pl.Add(i);
            }
            var sum = pl.Sum();
            return sum; //functions correctly but need to minus 1
        }
    }
}
