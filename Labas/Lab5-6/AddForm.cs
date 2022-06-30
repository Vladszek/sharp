using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5_6 {
    public partial class AddForm : Form {
        public AddForm(string message) {
            InitializeComponent();
            label1.Text = message;
        }

        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams {
            get {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }

        public string Result { get; set; }

        private void button1_Click(object sender, EventArgs e) {
            if (textBox1.Text == "")
                MessageBox.Show("Для начала введите данные!");
            else {
                Result = textBox1.Text;
                this.Close();
            }
        }
    }
}
