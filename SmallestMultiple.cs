using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler {
    class SmallestMultiple {
        
        //brute force
        public static int Get() {
            int i = 20;
            while (i % 2 != 0 || i % 3 != 0 || i % 4 != 0 || i % 5 != 0 ||
           i % 6 != 0 || i % 7 != 0 || i % 8 != 0 || i % 9 != 0 ||
           i % 10 != 0 || i % 11 != 0 || i % 12 != 0 || i % 13 != 0 ||
           i % 14 != 0 || i % 15 != 0 || i % 16 != 0 || i % 17 != 0 ||
           i % 18 != 0 || i % 19 != 0 || i % 20 != 0) {
                i += 20;
            }
            return i;
        }

        public static int Get2() {
            var i = 20;
            while(!Check(i)) {
                i += 20;
            }
            return i;
        }

        public static bool Check(int n) {
            for (var i = 1; i <= 20; i++) {
                if (n % i != 0) return false;
            }
            return true;
        }

        //optimized

    }
}
