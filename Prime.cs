using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler {
    class Prime {

        public static long Gpf(long a) {
            long g = 0;
            for (long i = 2; i * i < a; i++) {
                if(a % i == 0) {
                    if (C(i) && i >= g) g = i;
                }
            }
            return g;
        }

        public static bool C(long a) {
            bool v = true;
            for (long i = 2; i * i < a; i++) {
                if (a % i == 0) v = false; 
            }
            return v;
        }

        //optimized

       public static long Ogpf(long a) {
            long nn = a;
            long lf = 0;

            int c = 2;

            while (c * c <= nn) {
                if (nn % c  == 0) {
                    nn = nn / c;
                    lf = c;
                } else {
                    c = (c == 2) ? 3 : c + 2;
                }
            }

            if (nn > lf) lf = nn;
            return lf;
        }

    }
}
