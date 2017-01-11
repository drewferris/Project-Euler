using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProjectEuler {
    class BitwiseManipulation {

        public static void Ops() {
            int x = 12, y = 23;
            Swap(ref x, ref y);

            var a = 15 & 10;
            var b = 12 & 9;

            var c = 15 | 10;
            var d = 12 | 9;

            var e = 15 ^ 10;
            var f = 12 ^ 9;

            var g = 15 << 2;
            var h = 10 << 2;


            //set bit at said index to value
            var i = a |= 1 << 0;
            //change bit to 0 at said index
            var j = b &= ~(1 << 3);
            //toggle bit at said index
            var k = e ^= 1 << 1;
            //checking a bit
            var bit = (f >> 1) & 1;
            //changing a bit to x
           var l = g ^= (-0 ^ g) & (1 << 3);



        }


        static void Swap(ref int x, ref int y) {
            x = x ^ y;
            y = y ^ x;
            x = x ^ y;
        }
    }
}
