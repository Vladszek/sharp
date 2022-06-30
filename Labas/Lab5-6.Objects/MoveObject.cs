using System;
using System.Threading.Tasks;

namespace Lab5_6.Objects {
    public abstract class MoveObject : Obj {
        protected const int Speed = 7;
        public Func<Task> MoveTask { get; set; }
        public double StartX { get; set; }
        public double StartY { get; set; }
        public double MoveToX { get; set; }
        public double MoveToY { get; set; }
        public string Name { get; set; }

        public MoveObject(double startX, double startY, Action<string> messages) : base(messages) {
            StartX = startX;
            StartY = startY;
            CoordX = startX;
            CoordY = startY;
            MoveToX = startX;
            MoveToY = startY;
            MoveTask = null;
        }

        protected abstract void CheckEvents();

        public async override void Start() {
            while (!IsWorking) {
                CheckEvents();
                Move();
                if (MoveTask != null)
                    await MoveTask();
                await Task.Delay(30);
            }
        }

        public bool EndOfWork() {
            return Math.Abs(CoordX - MoveToX) < 5 && Math.Abs(CoordY - MoveToY) < 5;
        }

        public void Move() {
            if (!EndOfWork()) {
                if (Math.Abs(CoordX - MoveToX) > 2) {
                    CoordY += (3 * (MoveToY - CoordY) / Math.Abs(CoordX - MoveToX)) % Speed;
                    CoordX += (3 * Math.Sign(MoveToX - CoordX)) % Speed;
                }
                else {
                    CoordX += (3 * (MoveToX - CoordX) / Math.Abs(CoordY - MoveToY)) % Speed;
                    CoordY += (3 * Math.Sign(MoveToY - CoordY)) % Speed;
                }
            }
        }
    }
}
