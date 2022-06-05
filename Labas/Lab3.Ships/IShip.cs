using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Ships {
    public interface IShip {
        int capacity { get; set; }

        bool canLoad(int cargo);

        string load(int cargo);

        string getName();

        string getInfo();
    }
}
