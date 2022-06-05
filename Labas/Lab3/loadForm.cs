using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3 {
    public partial class loadForm : Form {
        public loadForm() {
            InitializeComponent();
            cargoBox.KeyPress += cargoBox_KeyPress;
        }

        private void cargoBox_KeyPress(object sender, KeyPressEventArgs e) => e.Handled = !((char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)));

        private void addButton_Click(object sender, EventArgs e) => DialogResult = DialogResult.OK;

        public int getCargo() => Convert.ToInt32(cargoBox.Text);
    }
}
