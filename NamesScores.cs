using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace ProjectEuler {

    class NamesScores {

        public static int Get() {
            var r = 0;
            string t = System.IO.File.ReadAllText(@"W:\ddf\Code\ProjectEuler\Names.txt");
            var ns = t.Split(',');
            var rgx = new Regex("[^a-zA-Z0-9 -]");
            for (int i = 0; i < ns.Length; i++) {
                ns[i] = rgx.Replace(ns[i], "");
            }
            Array.Sort(ns, StringComparer.InvariantCulture);

            for(var j = 0; j < ns.Length; j++) {            
                var nv = 0;
                for (int i = 0; i < ns[j].Length; i++) {
                    var v = char.ToUpper(ns[j][i]) - 64;
                    nv += v;
                }
                var ind = Array.FindIndex(ns, nm => nm.Equals(ns[j]));
                var s = nv * (ind + 1);
                r += s;
            }
            return r;
        }
    }
}
