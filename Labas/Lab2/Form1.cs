using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab2.Phones;

namespace Lab2 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            InfoBox.Enabled = false;
            qualityBox.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e) {
            AddForm add = new AddForm();
            if (add.ShowDialog() == DialogResult.OK) {
                if (add.getLevel() == 1) {
                    FirstPhone Phone = new FirstPhone(add.getBrand(), add.getPrice(), add.getMemory());
                    InfoBox.Text = Phone.displayInfo();
                    qualityBox.Text = Phone.quality().ToString();
                }
                else {
                    SecondPhone Phone = new SecondPhone(add.getBrand(), add.getPrice(), add.getMemory(), add.getNumOfSIM());
                    InfoBox.Text = Phone.displayInfo();
                    qualityBox.Text = Phone.quality().ToString();
                }
            }
            add.Dispose();
        }
    }
}
