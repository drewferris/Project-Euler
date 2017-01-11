using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProjectEuler {

    class SumSquareDiff {

        //brute force
        public static void Get() {
            int sum = 0;
            int sum2 = 0;

            for (int i = 1; i < 101; i++) {
                sum += i * i;
                sum2 += i;
            }

            int diff = sum2 * sum2 - sum;
        }

        //opitimized

        public static int GetO(int N) {
            int sum, squared;
            sum = N * (N + 1) / 2;
            squared = (N * (N + 1) * (2 * N + 1)) / 6;
            int ret = (sum * sum) -squared;
            return ret;
        }
    }
}
