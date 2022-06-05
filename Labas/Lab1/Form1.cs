using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab1.Objects;

namespace Lab1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            addPlanetButton.Enabled = false;
            addMoonButton.Visible = false;
            planetTextBox.Visible = false;
            moonsListBox.Visible = false;
            planetsNumBox.Enabled = false;
            starTextBox.Enabled = false;
            planetTextBox.Enabled = false;
            moonsListBox.Enabled = false;
        }

        StarSystem starSystem = new StarSystem();

        private void planetsNumToForm() => planetsNumBox.Text = starSystem.numOfPlanets.ToString();


        private void starInfoToForm() {
            starTextBox.Text = "Название: " + starSystem.mainStar.name + "\r\nМасса: " + starSystem.mainStar.mass + "\r\nРадиус: " + starSystem.mainStar.radius + "\r\nСветимость: " + starSystem.mainStar.luminocity;
        }

        private void planetsToForm() {
            planetsListBox.Items.Clear();
            foreach (Planet p in starSystem.allPlanets) {
                planetsListBox.Items.Add(p.name);
            }
        }

        private void planetInfoToForm(Planet p) {
            planetTextBox.Text = "Название: " + p.name + "\r\nМасса: " + p.mass + "\r\nРадиус: " + p.radius + "\r\nПригодность для жизни: ";
            planetTextBox.Text += p.isHabitable ? "да" : "нет";
            planetTextBox.Visible = true;
            moonsListBox.Visible = true;
        }

        private void moonsToForm(Planet p) {
            moonsListBox.Items.Clear();
            foreach (Moon m in p.allMoons) {
                moonsListBox.Items.Add(m.name);
            }
        }

        private void addStarButton_Click(object sender, EventArgs e) {
            addStarForm add = new addStarForm();
            if (add.ShowDialog() == DialogResult.OK) {
                Star newStar = new Star(add.getName(), add.getMass(), add.getRadius(), add.getLuminocity());
                starSystem.mainStar = newStar;
                addStarButton.Enabled = false;
                addPlanetButton.Enabled = true;
            }
            add.Dispose();
            starInfoToForm();
        }

        private void addPlanetButton_Click(object sender, EventArgs e) {
            addPlanetForm add = new addPlanetForm();
            if (add.ShowDialog() == DialogResult.OK) {
                Planet newPlanet = new Planet(add.getName(), add.getMass(), add.getRadius(), add.getHabitable());
                starSystem.allPlanets.Add(newPlanet);
                planetInfoToForm(newPlanet);
                starSystem.numOfPlanets++;
                planetsNumToForm();
            }
            add.Dispose();
            planetsToForm();
        }

        private void PlanetsListBox_SelectedIndexChanged(object sender, EventArgs e) {
            if (planetsListBox.SelectedIndex >= 0) {
                addMoonButton.Visible = true;
                moonsToForm(starSystem.allPlanets[planetsListBox.SelectedIndex]);
                planetInfoToForm(starSystem.allPlanets[planetsListBox.SelectedIndex]);
            }
        }

        private void addMoonButton_Click(object sender, EventArgs e) {
            addMoonForm add = new addMoonForm();
            if (add.ShowDialog() == DialogResult.OK) {
                Moon newMoon = new Moon(add.getName(), add.getMass(), add.getRadius());
                starSystem.allPlanets[planetsListBox.SelectedIndex].allMoons.Add(newMoon);
                moonsToForm(starSystem.allPlanets[planetsListBox.SelectedIndex]);
            }
            add.Dispose();
        }
    }
}
