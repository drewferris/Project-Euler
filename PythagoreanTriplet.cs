using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProjectEuler {

    class PythagoreanTriplet {

        public static void Get() {
            for (var i = 1000; i > 0; i--)	{
                var c = 1000 - i;
                for(var j = c; j > 0; j--) {
                    var b = c - j;
                    for(var k = b; k > 0; k--) {
                        var a = b - k;
                        if(a + b + c == 1000 && Math.Pow(a,2) + Math.Pow(b,2) == Math.Pow(c,2)) {
                            var p = a * b * c;
                        }
                    }
                }
            }
        }

    }
}
