using System;
using System.Reflection;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab4.Ships;

namespace Lab4 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            methodComboBox.Enabled = false;
            addButton.Enabled = false;
            paramsButton.Enabled = false;
            methodButton.Enabled = false;
        }

        Assembly assembly;
        Type curType;
        IEnumerable<Type> types;
        object curObj;
        object[] methodParams;
        MethodInfo curMethod;
        
        private void Form1_Load(object sender, EventArgs e) {
            assembly = Assembly.Load("Lab4.Ships");
            types = assembly.GetTypes().Where(type => !type.IsAbstract && type.GetInterface("IShip") != null);
            classComboBox.Items.AddRange(types.Select(type => type.Name).ToArray());
        }
        private void classComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            propertiesListBox.Items.Clear();
            methodsListBox.Items.Clear();
            methodComboBox.Items.Clear();
            paramsButton.Enabled = false;
            methodButton.Enabled = false;
            curType = types.First(type => type.Name == classComboBox.SelectedItem.ToString());
            curObj = null;

            IEnumerable<string> objectMethods = (new object()).GetType().GetMethods().Select(method => method.Name);
            methodComboBox.Items.AddRange(curType.GetMethods().Where(
                method => !objectMethods.Contains(method.Name) && !method.Name.Contains("get_") && !method.Name.Contains("set_")).Select(method => method.Name).ToArray()
                );

            methodComboBox.Enabled = false;
            addButton.Enabled = true;
        }

        private void methodComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            curMethod = curType.GetMethods().First(method => method.Name == methodComboBox.SelectedItem.ToString());
            methodParams = null;

            if (curMethod.GetParameters().Length == 0) {
                paramsButton.Enabled = false;
                methodButton.Enabled = curObj != null;
            }
            else {
                paramsButton.Enabled = true;
                methodButton.Enabled = false;
            }
            methodsListBox.Items.Clear();
            foreach (ParameterInfo info in curMethod.GetParameters()) {
                methodsListBox.Items.Add(info.Name);
            }
        }

        private void addButton_Click(object sender, EventArgs e) {
            propertiesListBox.Items.Clear();
            methodComboBox.Enabled = true;
            methodButton.Enabled = false;
            paramsButton.Enabled = false;
            object newObject = Activator.CreateInstance(curType);
            Form add = new Form();
            add.ClientSize = new Size(200, 300);
            add.MaximizeBox = false;
            add.MinimizeBox = false;
            add.FormBorderStyle = FormBorderStyle.FixedSingle;
            int pos = 10;
            foreach (PropertyInfo info in newObject.GetType().GetProperties()) {
                Label label = new Label { Top = pos, Left = 10, Width = 90, Height = 20 };
                label.Text = info.Name;
                TextBox textBox = new TextBox { Top = pos, Left = label.Width + 20, Width = label.Width - 10, Height = 20 };
                textBox.Text = "1";
                add.Controls.Add(label);
                add.Controls.Add(textBox);
                pos += label.Height + 5;
            }

            add.Controls.Add(new Button() { Top = pos + 10, Left = 10, Width = 100, Height = 50, Text = "Добавить" });
            add.Controls[add.Controls.Count - 1].Click += new EventHandler((object sender2, EventArgs e2) => { add.DialogResult = DialogResult.OK; add.Close(); });

            if (add.ShowDialog() == DialogResult.OK) {
                PropertyInfo[] properties = newObject.GetType().GetProperties();
                for (int i = 1, j = 0; i < add.Controls.Count; i += 2, j++) {
                    string value = add.Controls[i].Text;
                    if (value.Length != 0) {
                        if (properties[j].PropertyType.Name == "Int32") {
                            properties[j].SetValue(newObject, Int32.Parse(value));
                        }
                        else {
                            properties[j].SetValue(newObject, value);
                        }
                    }
                }
            }

            curObj = newObject;
            foreach (PropertyInfo info in curType.GetProperties()) {
                propertiesListBox.Items.Add(info.Name + ": " + info.GetValue(curObj));
            }
        }

        private void paramsButton_Click(object sender, EventArgs e) {
            methodsListBox.Items.Clear();
            Form add = new Form();
            add.ClientSize = new Size(200, 100);
            add.MaximizeBox = false;
            add.MinimizeBox = false;
            add.FormBorderStyle = FormBorderStyle.FixedSingle;

            int pos = 10;
            foreach (ParameterInfo info in curMethod.GetParameters()) {
                Label label = new Label { Top = pos, Left = 10, Width = 90, Height = 20 };
                label.Text = info.Name;
                TextBox textBox = new TextBox { Top = pos, Left = label.Width + 10, Width = label.Width - 10, Height = 20 };
                textBox.Text = "1";
                add.Controls.Add(label);
                add.Controls.Add(textBox);
                pos += label.Height + 5;
            }

            add.Controls.Add(new Button() { Top = pos, Left = 10, Width = 100, Height = 50, Text = "Подтвердить" });
            add.Controls[add.Controls.Count - 1].Click += new EventHandler((object sender1, EventArgs e1) => { add.DialogResult = DialogResult.OK; add.Close(); });
            if (add.ShowDialog() == DialogResult.OK) {
                List<object> curParameters = new List<object>();
                for (int i = 1; i < add.Controls.Count - 1; i += 2) {
                    try {
                        string value = add.Controls[i].Text;
                        curParameters.Add(int.Parse(value));
                        methodsListBox.Items.Add(add.Controls[i - 1].Text + ": " + value);
                        methodButton.Enabled = true;
                    }
                    catch {
                        MessageBox.Show("Повторите ввод");
                        methodsListBox.Items.Add(add.Controls[i - 1].Text);
                        methodButton.Enabled = false;
                    }
                }
                methodParams = curParameters.ToArray();
            }

        }

        private void methodButton_Click(object sender, EventArgs e) {
            if (methodsListBox.Text.Length == 0 || methodsListBox.SelectedIndex != -1) {
                if (curMethod.GetParameters().Length != 0 && methodParams == null) {
                    MessageBox.Show("Введите параметры");
                }
                else {
                    if (curMethod.ReturnType == typeof(void)) {
                        curMethod.Invoke(curObj, methodParams);
                    }
                    else {
                        MessageBox.Show(curMethod.Invoke(curObj, methodParams).ToString());
                    }

                    propertiesListBox.Items.Clear();
                    foreach (PropertyInfo info in curType.GetProperties()) {
                        propertiesListBox.Items.Add(info.Name + ": " + info.GetValue(curObj));
                    }
                }
            }
        }
    }
    
}
