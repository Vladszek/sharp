
namespace Lab3 {
    partial class getInfoForm {
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.capacityBox = new System.Windows.Forms.TextBox();
            this.gunsBox = new System.Windows.Forms.TextBox();
            this.projectileWeightBox = new System.Windows.Forms.TextBox();
            this.planesBox = new System.Windows.Forms.TextBox();
            this.planeWeightBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Вместимость";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Количество орудий";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(233, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Вес снаряда";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Количество самолетов";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(226, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Вес самолета";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(75, 6);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(154, 20);
            this.nameBox.TabIndex = 6;
            // 
            // capacityBox
            // 
            this.capacityBox.Location = new System.Drawing.Point(94, 38);
            this.capacityBox.Name = "capacityBox";
            this.capacityBox.Size = new System.Drawing.Size(59, 20);
            this.capacityBox.TabIndex = 7;
            // 
            // gunsBox
            // 
            this.gunsBox.Location = new System.Drawing.Point(142, 87);
            this.gunsBox.Name = "gunsBox";
            this.gunsBox.Size = new System.Drawing.Size(52, 20);
            this.gunsBox.TabIndex = 8;
            // 
            // projectileWeightBox
            // 
            this.projectileWeightBox.Location = new System.Drawing.Point(310, 87);
            this.projectileWeightBox.Name = "projectileWeightBox";
            this.projectileWeightBox.Size = new System.Drawing.Size(52, 20);
            this.projectileWeightBox.TabIndex = 9;
            // 
            // planesBox
            // 
            this.planesBox.Location = new System.Drawing.Point(142, 120);
            this.planesBox.Name = "planesBox";
            this.planesBox.Size = new System.Drawing.Size(52, 20);
            this.planesBox.TabIndex = 10;
            // 
            // planeWeightBox
            // 
            this.planeWeightBox.Location = new System.Drawing.Point(310, 120);
            this.planeWeightBox.Name = "planeWeightBox";
            this.planeWeightBox.Size = new System.Drawing.Size(52, 20);
            this.planeWeightBox.TabIndex = 11;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(245, 6);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(117, 52);
            this.addButton.TabIndex = 12;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // getInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 157);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.planeWeightBox);
            this.Controls.Add(this.planesBox);
            this.Controls.Add(this.projectileWeightBox);
            this.Controls.Add(this.gunsBox);
            this.Controls.Add(this.capacityBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "getInfoForm";
            this.Text = "getInfoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox capacityBox;
        private System.Windows.Forms.TextBox gunsBox;
        private System.Windows.Forms.TextBox projectileWeightBox;
        private System.Windows.Forms.TextBox planesBox;
        private System.Windows.Forms.TextBox planeWeightBox;
        private System.Windows.Forms.Button addButton;
    }
}