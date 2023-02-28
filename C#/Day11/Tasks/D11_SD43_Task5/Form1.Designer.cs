namespace D11_SD43_Task5
{
    partial class Form1
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
            this.btnDrg = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDrg
            // 
            this.btnDrg.Location = new System.Drawing.Point(31, 47);
            this.btnDrg.Name = "btnDrg";
            this.btnDrg.Size = new System.Drawing.Size(32, 23);
            this.btnDrg.TabIndex = 0;
            this.btnDrg.Text = "---";
            this.btnDrg.UseVisualStyleBackColor = true;
            this.btnDrg.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnDrg_MouseDown);
            this.btnDrg.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnDrg_MouseMove);
            this.btnDrg.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnDrg_MouseUp);
            // 
            // btnClose
            // 
            this.btnClose.ForeColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(419, 47);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(32, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDrg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnDrg;
        private Button btnClose;
    }
}