using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Lab5_6 {
    public class CreateObject {
        public Bitmap Bitmap { get; set; }
        private Graphics Graphics { get; set; }
        public Timer Timer { get; set; }

        public CreateObject(PictureBox pictureBox, Image backgroundImage, List<ObjectCoords> viewObjects, object viewObjectsLocker,
                        List<Model> viewModels, object viewModelsLocker) {
            Bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
            Graphics = Graphics.FromImage(Bitmap);
            Timer = new Timer();
            Timer.Interval = 30;
            Timer.Tick += new EventHandler((obj, e) =>
            {
                Graphics.Clear(Color.White);
                Graphics.DrawImage(backgroundImage, 0, 0);

                lock (viewObjectsLocker) {
                    foreach (var item in viewObjects) {
                        Draw(item);
                    }
                }

                lock (viewModelsLocker) {
                    foreach (var item in viewModels) {
                        Draw(item);
                    }
                }

                pictureBox.Image = Bitmap;
            });
        }

        public void Draw(ObjectCoords viewObject) {
            Graphics.DrawImage(viewObject.Image,
                (float)viewObject.CoordinateX - viewObject.Image.Width / 2, (float)viewObject.CoordinateY - viewObject.Image.Height / 2);
        }

        public void TimerStart() {
            Timer.Start();
        }

        public void TimerStop() {
            Timer.Stop();
        }
    }
}
