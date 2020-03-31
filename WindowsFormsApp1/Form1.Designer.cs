namespace WindowsFormsApp1
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.таблиціБДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.birdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.continentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eggsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.адмініструванняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calcMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.таблиціБДToolStripMenuItem,
            this.адмініструванняToolStripMenuItem,
            this.calcMenu,
            this.aboutProgramToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(494, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // таблиціБДToolStripMenuItem
            // 
            this.таблиціБДToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.birdToolStripMenuItem,
            this.continentsToolStripMenuItem,
            this.eggsToolStripMenuItem});
            this.таблиціБДToolStripMenuItem.Name = "таблиціБДToolStripMenuItem";
            this.таблиціБДToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.таблиціБДToolStripMenuItem.Text = "Таблиці БД";
            // 
            // birdToolStripMenuItem
            // 
            this.birdToolStripMenuItem.Name = "birdToolStripMenuItem";
            this.birdToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.birdToolStripMenuItem.Text = "Птахи";
            this.birdToolStripMenuItem.Click += new System.EventHandler(this.birdToolStripMenuItem_Click);
            // 
            // continentsToolStripMenuItem
            // 
            this.continentsToolStripMenuItem.Name = "continentsToolStripMenuItem";
            this.continentsToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.continentsToolStripMenuItem.Text = "Континенти";
            this.continentsToolStripMenuItem.Click += new System.EventHandler(this.continentsToolStripMenuItem_Click);
            // 
            // eggsToolStripMenuItem
            // 
            this.eggsToolStripMenuItem.Name = "eggsToolStripMenuItem";
            this.eggsToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.eggsToolStripMenuItem.Text = "Яйця";
            this.eggsToolStripMenuItem.Click += new System.EventHandler(this.eggsToolStripMenuItem_Click);
            // 
            // адмініструванняToolStripMenuItem
            // 
            this.адмініструванняToolStripMenuItem.Name = "адмініструванняToolStripMenuItem";
            this.адмініструванняToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.адмініструванняToolStripMenuItem.Text = "Адміністрування";
            // 
            // calcMenu
            // 
            this.calcMenu.Name = "calcMenu";
            this.calcMenu.Size = new System.Drawing.Size(89, 20);
            this.calcMenu.Text = "Калькулятор";
            this.calcMenu.Click += new System.EventHandler(this.calcMenu_Click);
            // 
            // aboutProgramToolStripMenuItem
            // 
            this.aboutProgramToolStripMenuItem.Name = "aboutProgramToolStripMenuItem";
            this.aboutProgramToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.aboutProgramToolStripMenuItem.Text = "Про програму";
            this.aboutProgramToolStripMenuItem.Click += new System.EventHandler(this.aboutProgramToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Птахи";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem таблиціБДToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem birdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem continentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eggsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem адмініструванняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calcMenu;
        private System.Windows.Forms.ToolStripMenuItem aboutProgramToolStripMenuItem;
    }
}

