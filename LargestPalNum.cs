using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler {
    class LargestPalNum {
        public static int Get() {
            int p;
            int r = 0;
            for (int i = 100; i < 1000; i++) {
                for (int j = 100; j < 1000; j++) {
                    p = i * j;
                    if (Check(p) && p > r) r = p;
                }

            }
            return r;
        }

        public static bool Check(int a) {
            int r = int.Parse( Reverse(a.ToString()));
            return r == a;
        }

        public static string Reverse(string s) {
            char[] cs = s.ToCharArray();
            Array.Reverse(cs);
            return new string(cs);
        }

        //optimized solution

        private static int MakePalindrome(int firstHalf) {
            char[] reversed = firstHalf.ToString().Reverse().ToArray();
            return Convert.ToInt32(firstHalf + new string(reversed));
        }

        public static int GetO() {
            int firstHalf = 998, palin = 0;
            int[] factors = new int[2];

            while(true) {
                firstHalf--;
                palin = MakePalindrome(firstHalf);
                for (int i = 999; i > 99; i--) {
                    if((palin/i) > 999 || i * i < palin) break;

                    if((palin % i == 0)) {
                        factors[0] = palin / i;
                        factors[1] = i;
                        break;
                    }
                }
            }
        }

    }
}
