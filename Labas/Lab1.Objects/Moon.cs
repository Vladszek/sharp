using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Objects {
    public class Moon{
        public string name;
        public double mass;
        public double radius;

        public Moon(string moonName, double moonMass, double moonRadius) {
            name = moonName;
            mass = moonMass;
            radius = moonRadius;
        }
    }
}
