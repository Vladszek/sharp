using System;
using System.Threading.Tasks;

namespace Lab5_6.Objects {
    public class Trolleybus : MoveObject {
        private readonly object TbusLocker;
        public bool WaitingForService { get; set; }
        public bool IsBroken { get; set; }
        public bool AreBarsBroken { get; set; }

        public Trolleybus(object tbusLocker, double startX, double startY, Action<string> messages) :
            base(startX, startY, messages) {
            TbusLocker = tbusLocker;
            AreBarsBroken = false;
        }

        public void StartDriving() {
            lock (TbusLocker) {
                MoveToY = StartY;
                IsMoving = true;
            }
        }

        public void EndDriving() {
            Messages("Поездка троллейбуса \"" + Name + "\" окончена, скоро начнется новая");
            lock (TbusLocker) {
                MoveToY = StartY;
                MoveToX = StartX;
            }
        }

        private async Task BreakEvent() {
            bool TbusIsDown = false;
            while (!TbusIsDown) {
                await Task.Delay(100);
                lock (TbusLocker) {
                    TbusIsDown = EndOfWork();
                }
            }
        }

        public async Task RandomBreak() {
            Random rnd = new Random();
            if (rnd.Next(0, 100) < 20) {
                await BreakEvent();
                Messages("Троллейбус \"" + Name + "\" сломан");
                IsBroken = true;
                WaitingForService = false;
            }
            if (rnd.Next(0, 100) > 80) {
                await BreakEvent();
                Messages("У троллейбуса \"" + Name + "\" отошли штанги");
                AreBarsBroken = true;
            }
        }

        protected override void CheckEvents() {
            if (!IsMoving) {
                MoveToX = StartX;
                MoveToY = StartY;
            }
        }

        public async Task WaitingRepair() {
            do {
                await Task.Delay(100);
            } while (IsBroken);
            StartDriving();
        }

        public async Task WaitingDriver() {
            while (AreBarsBroken) {
                await Task.Delay(3000);
                AreBarsBroken = false;
                Messages("Водитель троллейбуса \"" + Name + "\" поставил штанги на место");
            }
            StartDriving();
        }

        public async Task Drive() {
            StartDriving();
            Messages("Троллейбус \"" + Name + "\" начал поездку");
            var rand = new Random();
            for (int i = 0; i < 6; i++) {
                MoveToX = rand.Next(100, 600);
                MoveToY = rand.Next((int)StartY - 10, (int)StartY + 10);
                await Task.Delay(400);
                await RandomBreak();
                await WaitingRepair();
                await WaitingDriver();
            }
            EndDriving();
            IsWorking = false;
        }
    }
}