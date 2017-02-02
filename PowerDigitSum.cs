using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;



namespace ProjectEuler {

    class PowerDigitSum {

        public static void PDSGet(int i) {
            var a = 2;
            var b = BigInteger.Pow(a, i);
            BigInteger s = 0;
            while (b != 0) {
                s += b % 10;
                b /= 10;
            }
            Console.WriteLine(s);
        }


    }
}
