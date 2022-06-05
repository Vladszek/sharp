using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Phones {
    public class SecondPhone : FirstPhone {
        public int numOfSIM { get; set; }

        public SecondPhone() => numOfSIM = 1;

        public SecondPhone(string brand, int price, int memory, int SIMnum) : base(brand, price, memory) => numOfSIM = SIMnum;

        public override double quality() => base.quality() * numOfSIM;

        public override string displayInfo() => base.displayInfo() + "\r\nКоличесво SIM-карт:" + numOfSIM;
    }
}
