using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Ships {
    public interface IShip {
        int Capacity { get; set; }

        bool CanLoad(int cargo);

        string Load(int cargo);

        string GetName();

        string GetInfo();
    }
}
