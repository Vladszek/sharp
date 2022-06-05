using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2 {
    public partial class AddForm : Form {
        public AddForm() {
            InitializeComponent();
            levelBox.Items.AddRange(new string[] { "1", "2" });
            simBox.Items.AddRange(new string[] { "1", "2" });
            simBox.DropDownStyle = ComboBoxStyle.DropDownList;
            levelBox.DropDownStyle = ComboBoxStyle.DropDownList;
            priceBox.KeyPress += priceBox_KeyPress;
            memoryBox.KeyPress += memoryBox_KeyPress;
            levelBox.SelectedValueChanged += levelBox_SelectedIndexChanged;
            label4.Visible = false;
            simBox.Visible = false;
            levelBox.SelectedItem = "1";
            simBox.SelectedItem = "1";
        }

        private void levelBox_SelectedIndexChanged(object sender, EventArgs e) {
            if (getLevel() == 2) {
                label4.Visible = true;
                simBox.Visible = true;
            }
            else {
                label4.Visible = false;
                simBox.Visible = false;
            }
        }

        private void priceBox_KeyPress(object sender, KeyPressEventArgs e) => e.Handled = !((char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)));

        private void memoryBox_KeyPress(object sender, KeyPressEventArgs e) => e.Handled = !((char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)));

        private void addButton_Click(object sender, EventArgs e) => DialogResult = DialogResult.OK;

        public string getBrand() => brandBox.Text;

        public int getPrice() => Convert.ToInt32(priceBox.Text);

        public int getMemory() => Convert.ToInt32(memoryBox.Text);

        public int getNumOfSIM() => Convert.ToInt32(simBox.SelectedItem);

        public int getLevel() => Convert.ToInt32(levelBox.SelectedItem);
    }
}
