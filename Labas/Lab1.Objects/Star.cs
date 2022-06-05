using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Objects {
    public class Star : Moon {
        public double luminocity;

        public Star(string starName, double starMass, double starRadius, int lum) : base(starName, starMass, starRadius) {
            luminocity = lum;
        }

    }
}
