using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Objects
{
    public class StarSystem
    {
        public Star mainStar;
        public List<Planet> allPlanets;
        public int numOfPlanets;

        public StarSystem() {
            mainStar = null;
            allPlanets = new List<Planet>();
            numOfPlanets = 0;
        }
    }
}
