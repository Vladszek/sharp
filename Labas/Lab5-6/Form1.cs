using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab5_6.Objects;
using Lab5_6.Objects.Service;

namespace Lab5_6 {
    public partial class Form1 : Form {
        const int MaxCountOfServices = 4;
        const int MaxCountOfTbuses = 4;

        public List<ObjectCoords> ViewObjects { get; set; }
        public object ViewObjectsLocker { get; set; }
        public List<Model> ViewModels { get; set; }
        public object ViewModelsLocker { get; set; }
        public object TbusLocker { get; set; }
        public CreateObject Creator { get; set; }
        public List<Driver> Drivers { get; set; }
        public List<Trolleybus> Tbuses { get; set; }
        public List<string> Messages { get; set; }
        public int CountOfService { get; set; }

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            CountOfService = 0;
            ViewObjects = new List<ObjectCoords>();
            ViewObjectsLocker = new object();
            ViewModels = new List<Model>();
            ViewModelsLocker = new object();
            TbusLocker = new object();
            Tbuses = new List<Trolleybus>();
            Drivers = new List<Driver>();
            Messages = new List<string>();
            Creator = new CreateObject(pictureBox1, Properties.Resources.back, ViewObjects, ViewObjectsLocker, ViewModels, ViewModelsLocker);
            Creator.TimerStart();
        }


        private void Message(string message) {
            textBox1.Invoke((MethodInvoker)delegate {
                Messages.Add(message);
                textBox1.Text += message + "\r\n";
                textBox1.SelectionStart = textBox1.Text.Length;
                textBox1.ScrollToCaret();
            });
        }

        private string Input(string message) {
            AddForm addForm = new AddForm(message);
            addForm.ShowDialog();
            this.Enabled = true;
            return addForm.Result;
        }

        private void trolleyToolStripMenuItem_Click(object sender, EventArgs e) {
            float coordX = 100;
            float coordY = 50 + Drivers.Count * 70;
            Drivers.Add(new Driver(coordX, coordY, Message));


            Drivers[Drivers.Count() - 1].Tbus = new Trolleybus(TbusLocker, Drivers[Drivers.Count() - 1].CoordX,
                Drivers[Drivers.Count() - 1].CoordY, Message);
            Drivers[Drivers.Count() - 1].Tbus.Name = Input("Введите номер или название троллейбуса:");
            Task.Run(Drivers[Drivers.Count() - 1].Start);

            lock (ViewModels) {
                ViewModels.Add(new Model(Drivers[Drivers.Count() - 1].Tbus, Properties.Resources.Tbus));
                Tbuses.Add(Drivers[Drivers.Count() - 1].Tbus);
            }

            if (Drivers.Count() > MaxCountOfTbuses)
                serviceToolStripMenuItem.Enabled = false;
            Task.Run(Drivers[Drivers.Count() - 1].Tbus.Start);
        }

        private void slowToolStripMenuItem_Click(object sender, EventArgs e) {
            SlowService serv = Activator.CreateInstance(typeof(SlowService),
                new object[] { 650, 50 + CountOfService * 70, (Action<string>)Message, Tbuses, TbusLocker }) as SlowService;
            CreateMechanic(serv);
        }

        private void averageToolStripMenuItem_Click(object sender, EventArgs e) {
            AverageService serv = Activator.CreateInstance(typeof(AverageService),
                new object[] { 650, 50 + CountOfService * 70, (Action<string>)Message, Tbuses, TbusLocker }) as AverageService;
            CreateMechanic(serv);
        }

        private void fastToolStripMenuItem_Click(object sender, EventArgs e) {
            FastService serv = Activator.CreateInstance(typeof(FastService),
                new object[] { 650, 50 + CountOfService * 70, (Action<string>)Message, Tbuses, TbusLocker }) as FastService;
            CreateMechanic(serv);
        }

        private void CreateMechanic(Service service) {
            CountOfService++;
            service.Name = Input("Введите название сервиса:");

            lock (ViewModelsLocker) {
                ViewModels.Add(new Model(service, Properties.Resources.service));
            }

            if (CountOfService > MaxCountOfServices)
                serviceToolStripMenuItem.Enabled = false;
            Task.Run(service.Start);
        }
    }
}
