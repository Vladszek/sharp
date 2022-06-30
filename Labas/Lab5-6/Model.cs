using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Lab5_6.Objects;

namespace Lab5_6 {
    public class Model : ObjectCoords {
        public Obj Element { get; }
        public override double CoordinateX { get => Element.CoordX; }
        public override double CoordinateY { get => Element.CoordY; }

        public Model(Obj model, Image image) : base(image) {
            Element = model;
        }
    }
}
