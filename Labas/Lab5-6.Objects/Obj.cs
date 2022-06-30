using System;

namespace Lab5_6.Objects {
    public abstract class Obj {
        public double CoordX { get; set; }
        public double CoordY { get; set; }
        public bool IsMoving { get; set; }
        public bool IsWorking { get; set; }

        public Action<string> Messages;
        public abstract void Start();

        public Obj(Action<string> messages) {
            Messages = messages;
        }
    }
}
