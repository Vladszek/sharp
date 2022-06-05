using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Objects {
    public class Planet : Moon {
        public bool isHabitable;
        public List<Moon> allMoons;

        public Planet(string planetName, double planetMass, double planetRadius, bool state) : base(planetName, planetMass, planetRadius) {
            isHabitable = state;
            allMoons = new List<Moon>();
        }
    }
}
