namespace D12_SD43_Task
{
    partial class frm1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grd = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.saveMenu = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grd
            // 
            this.grd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd.Location = new System.Drawing.Point(0, 24);
            this.grd.Name = "grd";
            this.grd.RowTemplate.Height = 25;
            this.grd.Size = new System.Drawing.Size(800, 426);
            this.grd.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadMenu,
            this.saveMenu});
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.loadToolStripMenuItem.Text = "Menu";
            // 
            // loadMenu
            // 
            this.loadMenu.Name = "loadMenu";
            this.loadMenu.Size = new System.Drawing.Size(100, 22);
            this.loadMenu.Text = "Load";
            this.loadMenu.Click += new System.EventHandler(this.loadMenu_Click);
            // 
            // saveMenu
            // 
            this.saveMenu.Name = "saveMenu";
            this.saveMenu.Size = new System.Drawing.Size(100, 22);
            this.saveMenu.Text = "Save";
            this.saveMenu.Click += new System.EventHandler(this.saveMenu_Click);
            // 
            // frm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grd);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.grd)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView grd;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem loadToolStripMenuItem;
        private ToolStripMenuItem loadMenu;
        private ToolStripMenuItem saveMenu;
    }
}