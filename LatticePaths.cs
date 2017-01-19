using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProjectEuler {

    class LatticePaths {

        //Dynamic Programming Method
        public static void GetPaths() {
            const int gs = 20;
            var g = new long[gs + 1, gs + 1];

            //Initialise the grid with boundary conditions
            for (int i = 0; i < gs; i++) {
                g[i, gs] = 1;
                g[gs, i] = 1;
            }
            for (int i = gs - 1; i >= 0; i--) {
                for (int j = gs - 1; j >= 0; j--) {
                    g[i, j] = g[i + 1, j] + g[i, j + 1];
                }
            }
            Console.WriteLine(g[0,0]);
        }
    }
}
