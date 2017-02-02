using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;


namespace ProjectEuler {

    class FactorialSum {

        public static int Get(BigInteger n) {
            BigInteger r = 1;

            for (BigInteger i = n; i > 0; i--) {
                r *= i;
            }

            BigInteger s = 0;
            BigInteger t = 10;
            while (r != 0) {
                s += r % t;
                r /= 10;
            }

            return 1;
        }
    }
}
