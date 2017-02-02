using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProjectEuler {

    class AmicableNumbers {

        public static int Get(int n) {
            var ans = 0;
            for (int i = n-1; i > 0; i--) {
                if (i == Test(Test(i)) && i != Test(i)) {
                    ans += i;
                }
            }
            var t = Test(220);
            return ans;
        }

        private static int Test(int n) {
            var s = 0;
            var ds = new List<int>();
            for (int j = 1; j < n; j++) {
                if (n % j == 0) ds.Add(j);
            }
            s = ds.Sum();
            return s;
        }
    }
}
