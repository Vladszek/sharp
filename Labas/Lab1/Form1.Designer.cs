
namespace Lab1 {
    partial class Form1 {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            this.addStarButton = new System.Windows.Forms.Button();
            this.addPlanetButton = new System.Windows.Forms.Button();
            this.addMoonButton = new System.Windows.Forms.Button();
            this.starTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.planetsListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.planetTextBox = new System.Windows.Forms.TextBox();
            this.moonsListBox = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.planetsNumBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addStarButton
            // 
            this.addStarButton.Location = new System.Drawing.Point(199, 33);
            this.addStarButton.Name = "addStarButton";
            this.addStarButton.Size = new System.Drawing.Size(130, 25);
            this.addStarButton.TabIndex = 0;
            this.addStarButton.Text = "Добавить Звезду";
            this.addStarButton.UseVisualStyleBackColor = true;
            this.addStarButton.Click += new System.EventHandler(this.addStarButton_Click);
            // 
            // addPlanetButton
            // 
            this.addPlanetButton.Location = new System.Drawing.Point(199, 73);
            this.addPlanetButton.Name = "addPlanetButton";
            this.addPlanetButton.Size = new System.Drawing.Size(130, 25);
            this.addPlanetButton.TabIndex = 1;
            this.addPlanetButton.Text = "Добавить Планету";
            this.addPlanetButton.UseVisualStyleBackColor = true;
            this.addPlanetButton.Click += new System.EventHandler(this.addPlanetButton_Click);
            // 
            // addMoonButton
            // 
            this.addMoonButton.Location = new System.Drawing.Point(199, 112);
            this.addMoonButton.Name = "addMoonButton";
            this.addMoonButton.Size = new System.Drawing.Size(130, 25);
            this.addMoonButton.TabIndex = 2;
            this.addMoonButton.Text = "Добавить Спутник";
            this.addMoonButton.UseVisualStyleBackColor = true;
            this.addMoonButton.Click += new System.EventHandler(this.addMoonButton_Click);
            // 
            // starTextBox
            // 
            this.starTextBox.Location = new System.Drawing.Point(23, 33);
            this.starTextBox.Multiline = true;
            this.starTextBox.Name = "starTextBox";
            this.starTextBox.Size = new System.Drawing.Size(153, 86);
            this.starTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Звезда:";
            // 
            // planetsListBox
            // 
            this.planetsListBox.FormattingEnabled = true;
            this.planetsListBox.Location = new System.Drawing.Point(23, 170);
            this.planetsListBox.Name = "planetsListBox";
            this.planetsListBox.Size = new System.Drawing.Size(153, 134);
            this.planetsListBox.TabIndex = 5;
            this.planetsListBox.SelectedIndexChanged += new System.EventHandler(this.PlanetsListBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Планеты:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(196, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Информация о планете:";
            // 
            // planetTextBox
            // 
            this.planetTextBox.Location = new System.Drawing.Point(199, 170);
            this.planetTextBox.Multiline = true;
            this.planetTextBox.Name = "planetTextBox";
            this.planetTextBox.Size = new System.Drawing.Size(126, 134);
            this.planetTextBox.TabIndex = 8;
            // 
            // moonsListBox
            // 
            this.moonsListBox.FormattingEnabled = true;
            this.moonsListBox.Location = new System.Drawing.Point(351, 170);
            this.moonsListBox.Name = "moonsListBox";
            this.moonsListBox.Size = new System.Drawing.Size(120, 134);
            this.moonsListBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(348, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Список спутников:";
            // 
            // planetsNumBox
            // 
            this.planetsNumBox.Location = new System.Drawing.Point(436, 30);
            this.planetsNumBox.Name = "planetsNumBox";
            this.planetsNumBox.Size = new System.Drawing.Size(49, 20);
            this.planetsNumBox.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(348, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Кол-во планет:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 327);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.planetsNumBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.moonsListBox);
            this.Controls.Add(this.planetTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.planetsListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.starTextBox);
            this.Controls.Add(this.addMoonButton);
            this.Controls.Add(this.addPlanetButton);
            this.Controls.Add(this.addStarButton);
            this.Name = "Form1";
            this.Text = "Звездная система";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addStarButton;
        private System.Windows.Forms.Button addPlanetButton;
        private System.Windows.Forms.Button addMoonButton;
        private System.Windows.Forms.TextBox starTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox planetsListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox planetTextBox;
        private System.Windows.Forms.ListBox moonsListBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox planetsNumBox;
        private System.Windows.Forms.Label label5;
    }
}

