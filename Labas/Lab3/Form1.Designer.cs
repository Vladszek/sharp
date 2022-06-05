
namespace Lab3 {
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.действияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.launchPlaneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.landPlaneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shipsListBox = new System.Windows.Forms.ListBox();
            this.infoTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.действияToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(526, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.addToolStripMenuItem.Text = "Добавить";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.deleteToolStripMenuItem.Text = "Удалить";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // действияToolStripMenuItem
            // 
            this.действияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.fireToolStripMenuItem,
            this.launchPlaneToolStripMenuItem,
            this.landPlaneToolStripMenuItem});
            this.действияToolStripMenuItem.Name = "действияToolStripMenuItem";
            this.действияToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.действияToolStripMenuItem.Text = "Действия";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.loadToolStripMenuItem.Text = "Загрузить";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // fireToolStripMenuItem
            // 
            this.fireToolStripMenuItem.Name = "fireToolStripMenuItem";
            this.fireToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.fireToolStripMenuItem.Text = "Залп";
            this.fireToolStripMenuItem.Click += new System.EventHandler(this.fireToolStripMenuItem_Click);
            // 
            // launchPlaneToolStripMenuItem
            // 
            this.launchPlaneToolStripMenuItem.Name = "launchPlaneToolStripMenuItem";
            this.launchPlaneToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.launchPlaneToolStripMenuItem.Text = "Запустить самолет";
            this.launchPlaneToolStripMenuItem.Click += new System.EventHandler(this.launchPlaneToolStripMenuItem_Click);
            // 
            // landPlaneToolStripMenuItem
            // 
            this.landPlaneToolStripMenuItem.Name = "landPlaneToolStripMenuItem";
            this.landPlaneToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.landPlaneToolStripMenuItem.Text = "Посадить самолет";
            this.landPlaneToolStripMenuItem.Click += new System.EventHandler(this.landPlaneToolStripMenuItem_Click);
            // 
            // shipsListBox
            // 
            this.shipsListBox.FormattingEnabled = true;
            this.shipsListBox.Location = new System.Drawing.Point(12, 27);
            this.shipsListBox.Name = "shipsListBox";
            this.shipsListBox.Size = new System.Drawing.Size(273, 316);
            this.shipsListBox.TabIndex = 1;
            this.shipsListBox.SelectedIndexChanged += new System.EventHandler(this.shipsListBox_SelectedIndexChanged);
            // 
            // infoTextBox
            // 
            this.infoTextBox.Location = new System.Drawing.Point(291, 27);
            this.infoTextBox.Multiline = true;
            this.infoTextBox.Name = "infoTextBox";
            this.infoTextBox.Size = new System.Drawing.Size(224, 316);
            this.infoTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 346);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Для просмотра полной информации о корабле, щелкните по нему в списке";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 370);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.infoTextBox);
            this.Controls.Add(this.shipsListBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Ships";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ListBox shipsListBox;
        private System.Windows.Forms.TextBox infoTextBox;
        private System.Windows.Forms.ToolStripMenuItem действияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem launchPlaneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem landPlaneToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}

