using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab3.Ships;

namespace Lab3 {
    public partial class getInfoForm : Form {
        public getInfoForm(IShip Ship) {
            if(Ship is AircraftCarrier) {
                Carrier = Ship as AircraftCarrier;
            }
            InitializeComponent();
            gunsBox.KeyPress += gunsBox_KeyPress;
            capacityBox.KeyPress += capacityBox_KeyPress;
            planesBox.KeyPress += planesBox_KeyPress;
            projectileWeightBox.KeyPress += projectileWeightBox_KeyPress;
            planeWeightBox.KeyPress += planeWeightBox_KeyPress;

            nameBox.Text = "Не указано";
            capacityBox.Text = "1";
            gunsBox.Text = "0";
            planesBox.Text = "0";
            projectileWeightBox.Text = "1";
            planeWeightBox.Text = "1";
        }

        AircraftCarrier Carrier = new AircraftCarrier();

        private void capacityBox_KeyPress(object sender, KeyPressEventArgs e) => e.Handled = !((char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)));

        private void planesBox_KeyPress(object sender, KeyPressEventArgs e) => e.Handled = !((char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)));

        private void gunsBox_KeyPress(object sender, KeyPressEventArgs e) => e.Handled = !((char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)));

        private void projectileWeightBox_KeyPress(object sender, KeyPressEventArgs e) => e.Handled = !((char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)));

        private void planeWeightBox_KeyPress(object sender, KeyPressEventArgs e) => e.Handled = !((char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)));

        private int getCurCapacity() => Convert.ToInt32(planesBox.Text) * Convert.ToInt32(planeWeightBox.Text);

        private void addButton_Click(object sender, EventArgs e) {
            if (getCurCapacity() > Convert.ToInt32(capacityBox.Text)) {
                MessageBox.Show("Общий вес текущей нагрузки превышает вместимость, корабль утонет. Измените параметры");
            }
            else {
                Carrier.name = getName();
                Carrier.capacity = getCapacity();
                Carrier.numOfGuns = getGunsNum();
                Carrier.projectileWeight = getProjectileWeight();
                Carrier.numOfPlanes = getPlanesNum();
                Carrier.planeWeight = getPlaneWeight();
                DialogResult = DialogResult.OK;
            }
        }

        public string getName() => nameBox.Text;

        public int getCapacity() => Convert.ToInt32(capacityBox.Text);

        public int getGunsNum() => Convert.ToInt32(gunsBox.Text);

        public int getProjectileWeight() => Convert.ToInt32(projectileWeightBox.Text);

        public int getPlanesNum() => Convert.ToInt32(planesBox.Text);

        public int getPlaneWeight() => Convert.ToInt32(planeWeightBox.Text);
    }
}
