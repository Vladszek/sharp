
namespace Lab2 {
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
            this.button1 = new System.Windows.Forms.Button();
            this.InfoBox = new System.Windows.Forms.TextBox();
            this.qualityBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 25);
            this.button1.TabIndex = 0;
            this.button1.Text = "Добавить телефон";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // InfoBox
            // 
            this.InfoBox.Location = new System.Drawing.Point(12, 27);
            this.InfoBox.Multiline = true;
            this.InfoBox.Name = "InfoBox";
            this.InfoBox.Size = new System.Drawing.Size(165, 80);
            this.InfoBox.TabIndex = 1;
            // 
            // qualityBox
            // 
            this.qualityBox.Location = new System.Drawing.Point(77, 128);
            this.qualityBox.Name = "qualityBox";
            this.qualityBox.Size = new System.Drawing.Size(100, 20);
            this.qualityBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Информация";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Качество:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(196, 209);
            this.Controls.Add(this.InfoBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.qualityBox);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Phone";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox InfoBox;
        private System.Windows.Forms.TextBox qualityBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

