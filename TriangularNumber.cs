using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProjectEuler {

    class TriangularNumber {

        public static void Get(int n) {

            var c = 0;
            var fl = new List<int>();
            var tnl = new List<int>();
            var i = 1;
            var l = 0;

            while (l < 501) {
                c += i;
                tnl.Add(c);
                fl.Add(c);
                var cfl = new List<int>();
                for (var j = 0; j < fl.Count; j++) {
                    var f = fl[j];
                    var fp = c / f;
                    if (c % f == 0) {
                        cfl.Add(fp);
                        if (!fl.Contains(fp)) {
                            fl.Add(fp);
                        }
                    }
                }
                l = cfl.Count;
                i++;
            }
            
        }
    }
}
