
namespace Lab2 {
    partial class AddForm {
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
            this.brandBox = new System.Windows.Forms.TextBox();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.memoryBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.levelBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.simBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Марка";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Цена";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Объем памяти";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Кол-во SIM-карт";
            // 
            // brandBox
            // 
            this.brandBox.Location = new System.Drawing.Point(77, 10);
            this.brandBox.Name = "brandBox";
            this.brandBox.Size = new System.Drawing.Size(100, 20);
            this.brandBox.TabIndex = 4;
            // 
            // priceBox
            // 
            this.priceBox.Location = new System.Drawing.Point(77, 36);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(100, 20);
            this.priceBox.TabIndex = 5;
            // 
            // memoryBox
            // 
            this.memoryBox.Location = new System.Drawing.Point(116, 62);
            this.memoryBox.Name = "memoryBox";
            this.memoryBox.Size = new System.Drawing.Size(61, 20);
            this.memoryBox.TabIndex = 6;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(12, 144);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(165, 25);
            this.addButton.TabIndex = 8;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // levelBox
            // 
            this.levelBox.FormattingEnabled = true;
            this.levelBox.Location = new System.Drawing.Point(116, 117);
            this.levelBox.Name = "levelBox";
            this.levelBox.Size = new System.Drawing.Size(61, 21);
            this.levelBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Уровень";
            // 
            // simBox
            // 
            this.simBox.FormattingEnabled = true;
            this.simBox.Location = new System.Drawing.Point(116, 88);
            this.simBox.Name = "simBox";
            this.simBox.Size = new System.Drawing.Size(61, 21);
            this.simBox.TabIndex = 11;
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(193, 187);
            this.Controls.Add(this.simBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.levelBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.memoryBox);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.brandBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddForm";
            this.Text = "Add";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox brandBox;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.TextBox memoryBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ComboBox levelBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox simBox;
    }
}