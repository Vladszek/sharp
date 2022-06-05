using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1 {
    public partial class addPlanetForm : Form {
        public addPlanetForm() {
            InitializeComponent();
            radBox.KeyPress += radBox_KeyPress;
            massBox.KeyPress += massBox_KeyPress;
        }

        private void radBox_KeyPress(object sender, KeyPressEventArgs e) => e.Handled = !((char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || !(e.KeyChar == (char)Keys.Oemcomma)));

        private void massBox_KeyPress(object sender, KeyPressEventArgs e) => e.Handled = !((char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || !(e.KeyChar == (char)Keys.Oemcomma)));

        private void addButton_Click(object sender, EventArgs e) => DialogResult = DialogResult.OK;

        public string getName() => nameBox.Text;

        public double getMass() => massBox.Text.Length == 0? 0 : Convert.ToDouble(massBox.Text);

        public double getRadius() => radBox.Text.Length == 0 ? 0 : Convert.ToDouble(radBox.Text);

        public bool getHabitable() => habitableButton.Checked;
    }
}
