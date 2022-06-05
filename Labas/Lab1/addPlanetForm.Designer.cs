
namespace Lab1 {
    partial class addPlanetForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.OkButton = new System.Windows.Forms.Button();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.massBox = new System.Windows.Forms.TextBox();
            this.radBox = new System.Windows.Forms.TextBox();
            this.habitableButton = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Масса";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Радиус";
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(28, 171);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(115, 32);
            this.OkButton.TabIndex = 3;
            this.OkButton.Text = "Добавить";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(72, 11);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(100, 20);
            this.nameBox.TabIndex = 4;
            // 
            // massBox
            // 
            this.massBox.Location = new System.Drawing.Point(72, 52);
            this.massBox.Name = "massBox";
            this.massBox.Size = new System.Drawing.Size(45, 20);
            this.massBox.TabIndex = 5;
            // 
            // radBox
            // 
            this.radBox.Location = new System.Drawing.Point(72, 95);
            this.radBox.Name = "radBox";
            this.radBox.Size = new System.Drawing.Size(45, 20);
            this.radBox.TabIndex = 6;
            // 
            // habitableButton
            // 
            this.habitableButton.AutoSize = true;
            this.habitableButton.Location = new System.Drawing.Point(12, 139);
            this.habitableButton.Name = "habitableButton";
            this.habitableButton.Size = new System.Drawing.Size(147, 17);
            this.habitableButton.TabIndex = 7;
            this.habitableButton.TabStop = true;
            this.habitableButton.Text = "Пригодность для жизни";
            this.habitableButton.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(123, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "* 10^4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(123, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "*10^25";
            // 
            // addPlanetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(189, 225);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.habitableButton);
            this.Controls.Add(this.radBox);
            this.Controls.Add(this.massBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "addPlanetForm";
            this.Text = "Планета";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox massBox;
        private System.Windows.Forms.TextBox radBox;
        private System.Windows.Forms.RadioButton habitableButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}