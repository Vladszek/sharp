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
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        public List<IShip> ships = new List<IShip>();

        private void addToolStripMenuItem_Click(object sender, EventArgs e) {
            IShip newShip = new AircraftCarrier();
            getInfoForm add = new getInfoForm(newShip);
            if (add.ShowDialog() == DialogResult.OK) {
                ships.Add(newShip);
                shipsListBox.Items.Add(newShip.getName());
            }
            add.Dispose();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e) {
            if (shipsListBox.SelectedIndex == -1) {
                MessageBox.Show("Выберите элемент из списка");
            } 
            else {
                ships.RemoveAt(shipsListBox.SelectedIndex);
                shipsListBox.Items.RemoveAt(shipsListBox.SelectedIndex);
            }
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e) {
            if (shipsListBox.SelectedIndex == -1) {
                MessageBox.Show("Выберите элемент из списка");
            }
            else {
                loadForm lForm = new loadForm();
                if (lForm.ShowDialog() == DialogResult.OK) {
                    AircraftCarrier Carrier = ships[shipsListBox.SelectedIndex] as AircraftCarrier;
                    MessageBox.Show(Carrier.load(lForm.getCargo()));
                    infoTextBox.Text = Carrier.getInfo();
                }
                lForm.Dispose();
            }
        }

        private void fireToolStripMenuItem_Click(object sender, EventArgs e) {
            if (shipsListBox.SelectedIndex == -1) {
                MessageBox.Show("Выберите элемент из списка");
            }
            else {
                AircraftCarrier Carrier = ships[shipsListBox.SelectedIndex] as AircraftCarrier;
                MessageBox.Show(Carrier.fireAllGuns());
                infoTextBox.Text = Carrier.getInfo();
            }
        }

        private void launchPlaneToolStripMenuItem_Click(object sender, EventArgs e) {
            if (shipsListBox.SelectedIndex == -1) {
                MessageBox.Show("Выберите элемент из списка");
            }
            else {
                AircraftCarrier Carrier = ships[shipsListBox.SelectedIndex] as AircraftCarrier;
                MessageBox.Show(Carrier.launchPlane());
                infoTextBox.Text = Carrier.getInfo();
            }
        }

        private void landPlaneToolStripMenuItem_Click(object sender, EventArgs e) {
            if (shipsListBox.SelectedIndex == -1) {
                MessageBox.Show("Выберите элемент из списка");
            }
            else {
                AircraftCarrier Carrier = ships[shipsListBox.SelectedIndex] as AircraftCarrier;
                MessageBox.Show(Carrier.landPlane());
                infoTextBox.Text = Carrier.getInfo();
            }
        }

        private void shipsListBox_SelectedIndexChanged(object sender, EventArgs e) {
            if (shipsListBox.SelectedIndex != -1) {
                infoTextBox.Text = ships[shipsListBox.SelectedIndex].getInfo();
            }
        }
    }
}
