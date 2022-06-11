
namespace Lab4 {
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.classComboBox = new System.Windows.Forms.ComboBox();
            this.methodComboBox = new System.Windows.Forms.ComboBox();
            this.addButton = new System.Windows.Forms.Button();
            this.paramsButton = new System.Windows.Forms.Button();
            this.methodButton = new System.Windows.Forms.Button();
            this.propertiesListBox = new System.Windows.Forms.ListBox();
            this.methodsListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Класс:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Метод:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Свойства:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(272, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Параметры:";
            // 
            // classComboBox
            // 
            this.classComboBox.FormattingEnabled = true;
            this.classComboBox.Location = new System.Drawing.Point(59, 6);
            this.classComboBox.Name = "classComboBox";
            this.classComboBox.Size = new System.Drawing.Size(179, 21);
            this.classComboBox.TabIndex = 4;
            this.classComboBox.SelectedIndexChanged += new System.EventHandler(this.classComboBox_SelectedIndexChanged);
            // 
            // methodComboBox
            // 
            this.methodComboBox.FormattingEnabled = true;
            this.methodComboBox.Location = new System.Drawing.Point(59, 36);
            this.methodComboBox.Name = "methodComboBox";
            this.methodComboBox.Size = new System.Drawing.Size(179, 21);
            this.methodComboBox.TabIndex = 5;
            this.methodComboBox.SelectedIndexChanged += new System.EventHandler(this.methodComboBox_SelectedIndexChanged);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(253, 9);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 40);
            this.addButton.TabIndex = 6;
            this.addButton.Text = "Создать";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // paramsButton
            // 
            this.paramsButton.Location = new System.Drawing.Point(343, 9);
            this.paramsButton.Name = "paramsButton";
            this.paramsButton.Size = new System.Drawing.Size(75, 40);
            this.paramsButton.TabIndex = 7;
            this.paramsButton.Text = "Ввести параметры";
            this.paramsButton.UseVisualStyleBackColor = true;
            this.paramsButton.Click += new System.EventHandler(this.paramsButton_Click);
            // 
            // methodButton
            // 
            this.methodButton.Location = new System.Drawing.Point(434, 9);
            this.methodButton.Name = "methodButton";
            this.methodButton.Size = new System.Drawing.Size(75, 40);
            this.methodButton.TabIndex = 8;
            this.methodButton.Text = "Выполнить";
            this.methodButton.UseVisualStyleBackColor = true;
            this.methodButton.Click += new System.EventHandler(this.methodButton_Click);
            // 
            // propertiesListBox
            // 
            this.propertiesListBox.FormattingEnabled = true;
            this.propertiesListBox.Location = new System.Drawing.Point(37, 83);
            this.propertiesListBox.Name = "propertiesListBox";
            this.propertiesListBox.Size = new System.Drawing.Size(223, 147);
            this.propertiesListBox.TabIndex = 9;
            // 
            // methodsListBox
            // 
            this.methodsListBox.FormattingEnabled = true;
            this.methodsListBox.Location = new System.Drawing.Point(275, 83);
            this.methodsListBox.Name = "methodsListBox";
            this.methodsListBox.Size = new System.Drawing.Size(219, 147);
            this.methodsListBox.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 243);
            this.Controls.Add(this.methodsListBox);
            this.Controls.Add(this.propertiesListBox);
            this.Controls.Add(this.methodButton);
            this.Controls.Add(this.paramsButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.methodComboBox);
            this.Controls.Add(this.classComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox classComboBox;
        private System.Windows.Forms.ComboBox methodComboBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button paramsButton;
        private System.Windows.Forms.Button methodButton;
        private System.Windows.Forms.ListBox propertiesListBox;
        private System.Windows.Forms.ListBox methodsListBox;
    }
}

