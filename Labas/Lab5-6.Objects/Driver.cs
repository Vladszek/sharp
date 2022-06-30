using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_6.Objects {
    public class Driver : MoveObject {
        public Trolleybus Tbus { get; set; }

        public Driver(double X, double Y, Action<string> messages) : base(X, Y, messages) {
            CoordX = X;
            CoordY = Y;
            Tbus = null;
        }

        protected override void CheckEvents() {
            if (Tbus.AreBarsBroken) {
                Messages("Водитель троллейбуса \"" + Tbus.Name + "\" ставит штанги на место");
                MoveTask = BarsRepair;
                Tbus.AreBarsBroken = false;
            }
        }

        public async Task DriveTask() {
            Messages("Водитель ведет троллейбус \"" + Tbus.Name + "\"");
            await Tbus.Drive();
        }

        public async Task BarsRepair() {
            if (Tbus.AreBarsBroken) {
                Messages("Водитель троллейбуса \"" + Tbus.Name + "\" ставит штанги на место");
                await Task.Delay(1000);
                Tbus.AreBarsBroken = false;
            }
        }

        public override async void Start() {
            while (!IsWorking) {
                Messages("Поездка троллейбуса \"" + Tbus.Name + "\" начинается");
                await Task.Delay(3000);
                await DriveTask();
                await Task.Delay(6000);
            }
        }
    }
}
