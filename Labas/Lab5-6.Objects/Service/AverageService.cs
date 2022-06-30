using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_6.Objects.Service {
    public class AverageService : Service {
        public AverageService(double startX, double startY, Action<string> messages, List<Trolleybus> buses, object busLocker) : base(startX, startY, messages, buses, busLocker) {
            RepairSpeed = 2000;
            ServiceType = "Обычный сервис";
        }
    }
}
