namespace D11_SD43_Task3
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
            this.color = new MaterialSkin.Controls.MaterialButton();
            this.dlgColor = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // color
            // 
            this.color.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.color.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.color.Depth = 0;
            this.color.HighEmphasis = true;
            this.color.Icon = null;
            this.color.Location = new System.Drawing.Point(13, 399);
            this.color.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.color.MouseState = MaterialSkin.MouseState.HOVER;
            this.color.Name = "color";
            this.color.NoAccentTextColor = System.Drawing.Color.Empty;
            this.color.Size = new System.Drawing.Size(77, 36);
            this.color.TabIndex = 0;
            this.color.Text = "Colors";
            this.color.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.color.UseAccentColor = false;
            this.color.UseVisualStyleBackColor = true;
            this.color.Click += new System.EventHandler(this.color_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.color);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton color;
        private ColorDialog dlgColor;
    }
}