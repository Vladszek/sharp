using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_6.Objects.Service {
    public abstract class Service : MoveObject, IService {
        private readonly List<Trolleybus> Buses;
        private readonly object TbusLocker;
        private Trolleybus BrokenTbus { get; set; }
        protected int RepairSpeed { get; set; }
        protected string ServiceType { get; set; }
        public int RepNum { get; set; }

        public Service(double startX, double startY, Action<string> messages, List<Trolleybus> buses, object busLocker) : base(startX, startY, messages) {
            RepNum = 0;
            Buses = buses;
            TbusLocker = busLocker;
        }

        protected override void CheckEvents() {
            if (!IsMoving) {
                lock (TbusLocker) {
                    BrokenTbus = Buses.FirstOrDefault(Tbus => Tbus.IsBroken && !Tbus.WaitingForService);
                    if (BrokenTbus != null) {
                        BrokenTbus.WaitingForService = true;
                        MoveToX = BrokenTbus.CoordX + 10;
                        MoveToY = BrokenTbus.CoordY + 40;
                        IsMoving = true;
                        MoveTask = Repair;
                        Messages(ServiceType + " \"" + Name + "\" начал двигаться для починки троллейбуса \"" + BrokenTbus.Name + "\"");
                    }
                }
            }
        }

        protected async Task Repair() {
            if (EndOfWork()) {
                Messages(ServiceType + " \"" + Name + "\" производит ремонт троллейбуса \"" + BrokenTbus.Name + "\"");
                RepNum++;
                await Task.Delay(RepairSpeed);
                BrokenTbus.IsBroken = false;
                BrokenTbus.IsMoving = true;
                Messages("Троллейбус \"" + BrokenTbus.Name + "\" починен!>");
                Messages(ServiceType + " \"" + Name + "\" починил " + RepNum + " троллейбус");
                MoveTask = null;
                IsMoving = false;
                MoveToX = StartX;
                MoveToY = StartY;
            }
        }
    }
}
