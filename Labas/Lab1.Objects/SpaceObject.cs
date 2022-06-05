using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Objects {
    public class SpaceObject {
        public string name;
        public double mass;
        public double radius;

        public SpaceObject(string Name, double Mass, double Radius) {
            name = Name;
            mass = Mass;
            radius = Radius;
        }
    }
}
