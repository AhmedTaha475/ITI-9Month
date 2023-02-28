namespace KryptonToolKitDemo
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
            this.close = new MaterialSkin.Controls.MaterialButton();
            this.Save = new MaterialSkin.Controls.MaterialButton();
            this.Open = new MaterialSkin.Controls.MaterialButton();
            this.materialButton4 = new MaterialSkin.Controls.MaterialButton();
            this.color = new MaterialSkin.Controls.MaterialButton();
            this.font = new MaterialSkin.Controls.MaterialButton();
            this.rtb = new System.Windows.Forms.RichTextBox();
            this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.dlgSave = new System.Windows.Forms.SaveFileDialog();
            this.dlgColor = new System.Windows.Forms.ColorDialog();
            this.dlgFont = new System.Windows.Forms.FontDialog();
            this.SuspendLayout();
            // 
            // close
            // 
            this.close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.close.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.close.Depth = 0;
            this.close.HighEmphasis = true;
            this.close.Icon = null;
            this.close.Location = new System.Drawing.Point(951, 70);
            this.close.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.close.MouseState = MaterialSkin.MouseState.HOVER;
            this.close.Name = "close";
            this.close.NoAccentTextColor = System.Drawing.Color.Empty;
            this.close.Size = new System.Drawing.Size(66, 36);
            this.close.TabIndex = 3;
            this.close.Text = "Close";
            this.close.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.close.UseAccentColor = false;
            this.close.UseVisualStyleBackColor = true;
            // 
            // Save
            // 
            this.Save.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Save.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Save.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Save.Depth = 0;
            this.Save.HighEmphasis = true;
            this.Save.Icon = null;
            this.Save.Location = new System.Drawing.Point(492, 70);
            this.Save.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Save.MouseState = MaterialSkin.MouseState.HOVER;
            this.Save.Name = "Save";
            this.Save.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Save.Size = new System.Drawing.Size(64, 36);
            this.Save.TabIndex = 2;
            this.Save.Text = "Save";
            this.Save.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Save.UseAccentColor = false;
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Open
            // 
            this.Open.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Open.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Open.Depth = 0;
            this.Open.HighEmphasis = true;
            this.Open.Icon = null;
            this.Open.Location = new System.Drawing.Point(33, 70);
            this.Open.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Open.MouseState = MaterialSkin.MouseState.HOVER;
            this.Open.Name = "Open";
            this.Open.NoAccentTextColor = System.Drawing.Color.Empty;
            this.Open.Size = new System.Drawing.Size(64, 36);
            this.Open.TabIndex = 1;
            this.Open.Text = "Open";
            this.Open.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Open.UseAccentColor = false;
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // materialButton4
            // 
            this.materialButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.materialButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton4.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton4.Depth = 0;
            this.materialButton4.HighEmphasis = true;
            this.materialButton4.Icon = null;
            this.materialButton4.Location = new System.Drawing.Point(937, 479);
            this.materialButton4.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton4.Name = "materialButton4";
            this.materialButton4.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton4.Size = new System.Drawing.Size(81, 36);
            this.materialButton4.TabIndex = 6;
            this.materialButton4.Text = "Custom";
            this.materialButton4.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton4.UseAccentColor = false;
            this.materialButton4.UseVisualStyleBackColor = true;
            this.materialButton4.Click += new System.EventHandler(this.materialButton4_Click);
            // 
            // color
            // 
            this.color.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.color.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.color.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.color.Depth = 0;
            this.color.HighEmphasis = true;
            this.color.Icon = null;
            this.color.Location = new System.Drawing.Point(483, 479);
            this.color.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.color.MouseState = MaterialSkin.MouseState.HOVER;
            this.color.Name = "color";
            this.color.NoAccentTextColor = System.Drawing.Color.Empty;
            this.color.Size = new System.Drawing.Size(68, 36);
            this.color.TabIndex = 5;
            this.color.Text = "Color";
            this.color.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.color.UseAccentColor = false;
            this.color.UseVisualStyleBackColor = true;
            this.color.Click += new System.EventHandler(this.color_Click);
            // 
            // font
            // 
            this.font.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.font.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.font.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.font.Depth = 0;
            this.font.HighEmphasis = true;
            this.font.Icon = null;
            this.font.Location = new System.Drawing.Point(33, 479);
            this.font.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.font.MouseState = MaterialSkin.MouseState.HOVER;
            this.font.Name = "font";
            this.font.NoAccentTextColor = System.Drawing.Color.Empty;
            this.font.Size = new System.Drawing.Size(64, 36);
            this.font.TabIndex = 4;
            this.font.Text = "Font";
            this.font.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.font.UseAccentColor = false;
            this.font.UseVisualStyleBackColor = true;
            this.font.Click += new System.EventHandler(this.font_Click);
            // 
            // rtb
            // 
            this.rtb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtb.Location = new System.Drawing.Point(33, 124);
            this.rtb.Name = "rtb";
            this.rtb.Size = new System.Drawing.Size(985, 346);
            this.rtb.TabIndex = 0;
            this.rtb.Text = "";
            // 
            // frm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 524);
            this.Controls.Add(this.rtb);
            this.Controls.Add(this.font);
            this.Controls.Add(this.color);
            this.Controls.Add(this.materialButton4);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.close);
            this.MinimumSize = new System.Drawing.Size(1060, 524);
            this.Name = "frm1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rich Text Box";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm1_FormClosing);
            this.Load += new System.EventHandler(this.frm1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton close;
        private MaterialSkin.Controls.MaterialButton Save;
        private MaterialSkin.Controls.MaterialButton Open;
        private MaterialSkin.Controls.MaterialButton materialButton4;
        private MaterialSkin.Controls.MaterialButton color;
        private MaterialSkin.Controls.MaterialButton font;
        private RichTextBox rtb;
        private OpenFileDialog dlgOpen;
        private SaveFileDialog dlgSave;
        private ColorDialog dlgColor;
        private FontDialog dlgFont;
    }
}