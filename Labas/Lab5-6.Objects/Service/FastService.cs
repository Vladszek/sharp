using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_6.Objects.Service {
    public class FastService : Service {
        public FastService(double startX, double startY, Action<string> messages, List<Trolleybus> buses, object busLocker) : base(startX, startY, messages, buses, busLocker) {
            RepairSpeed = 1000;
            ServiceType = "Срочный сервис";
        }
    }
}
