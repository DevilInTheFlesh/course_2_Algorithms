namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.SourceText = new System.Windows.Forms.TextBox();
            this.Result = new System.Windows.Forms.TextBox();
            this.Exit = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.выбратьФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chooseFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayTreeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeTheTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveResultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addWordToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SourceText
            // 
            this.SourceText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.SourceText.Location = new System.Drawing.Point(12, 60);
            this.SourceText.Multiline = true;
            this.SourceText.Name = "SourceText";
            this.SourceText.ReadOnly = true;
            this.SourceText.Size = new System.Drawing.Size(356, 378);
            this.SourceText.TabIndex = 1;
            // 
            // Result
            // 
            this.Result.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Result.Location = new System.Drawing.Point(432, 60);
            this.Result.Multiline = true;
            this.Result.Name = "Result";
            this.Result.ReadOnly = true;
            this.Result.Size = new System.Drawing.Size(356, 378);
            this.Result.TabIndex = 2;
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(639, 5);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(149, 23);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выбратьФайлToolStripMenuItem,
            this.addWordToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // выбратьФайлToolStripMenuItem
            // 
            this.выбратьФайлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chooseFileToolStripMenuItem,
            this.displayTreeToolStripMenuItem,
            this.makeTheTaskToolStripMenuItem,
            this.saveResultToolStripMenuItem});
            this.выбратьФайлToolStripMenuItem.Name = "выбратьФайлToolStripMenuItem";
            this.выбратьФайлToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.выбратьФайлToolStripMenuItem.Text = "Task...";
            // 
            // chooseFileToolStripMenuItem
            // 
            this.chooseFileToolStripMenuItem.Name = "chooseFileToolStripMenuItem";
            this.chooseFileToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.chooseFileToolStripMenuItem.Text = "Choose File";
            this.chooseFileToolStripMenuItem.Click += new System.EventHandler(this.chooseFileToolStripMenuItem_Click);
            // 
            // displayTreeToolStripMenuItem
            // 
            this.displayTreeToolStripMenuItem.Name = "displayTreeToolStripMenuItem";
            this.displayTreeToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.displayTreeToolStripMenuItem.Text = "Display Tree";
            this.displayTreeToolStripMenuItem.Click += new System.EventHandler(this.displayTreeToolStripMenuItem_Click);
            // 
            // makeTheTaskToolStripMenuItem
            // 
            this.makeTheTaskToolStripMenuItem.Name = "makeTheTaskToolStripMenuItem";
            this.makeTheTaskToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.makeTheTaskToolStripMenuItem.Text = "Make The Task";
            this.makeTheTaskToolStripMenuItem.Click += new System.EventHandler(this.makeTheTaskToolStripMenuItem_Click);
            // 
            // saveResultToolStripMenuItem
            // 
            this.saveResultToolStripMenuItem.Name = "saveResultToolStripMenuItem";
            this.saveResultToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.saveResultToolStripMenuItem.Text = "Save Result";
            this.saveResultToolStripMenuItem.Click += new System.EventHandler(this.saveResultToolStripMenuItem_Click);
            // 
            // addWordToolStripMenuItem1
            // 
            this.addWordToolStripMenuItem1.Name = "addWordToolStripMenuItem1";
            this.addWordToolStripMenuItem1.Size = new System.Drawing.Size(87, 24);
            this.addWordToolStripMenuItem1.Text = "Add word";
            this.addWordToolStripMenuItem1.Click += new System.EventHandler(this.addWordToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.SourceText);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox SourceText;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem выбратьФайлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chooseFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayTreeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeTheTaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveResultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addWordToolStripMenuItem1;
    }
}

