
using System.Drawing;

namespace Lab5_6 {
    public class ObjectCoords {
        public Image Image { get; set; }
        public virtual double CoordinateX { get; set; }
        public virtual double CoordinateY { get; set; }

        public ObjectCoords(Image image) {
            Image = image;
        }

        public ObjectCoords(Image image, double coordinateX, double coordinateY) {
            Image = image;
            CoordinateX = coordinateX;
            CoordinateY = coordinateY;
        }
    }
}
