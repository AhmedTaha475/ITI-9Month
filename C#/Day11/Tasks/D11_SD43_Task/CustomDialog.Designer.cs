namespace D11_SD43_Task
{
    partial class CustomDialog
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
            this.btnOk = new MaterialSkin.Controls.MaterialButton();
            this.btnCancel = new MaterialSkin.Controls.MaterialButton();
            this.txt = new MaterialSkin.Controls.MaterialTextBox2();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOk.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnOk.Depth = 0;
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.HighEmphasis = true;
            this.btnOk.Icon = null;
            this.btnOk.Location = new System.Drawing.Point(7, 150);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnOk.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnOk.Name = "btnOk";
            this.btnOk.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnOk.Size = new System.Drawing.Size(64, 36);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "Ok";
            this.btnOk.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnOk.UseAccentColor = false;
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCancel.Depth = 0;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.HighEmphasis = true;
            this.btnCancel.Icon = null;
            this.btnCancel.Location = new System.Drawing.Point(351, 150);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCancel.Size = new System.Drawing.Size(77, 36);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCancel.UseAccentColor = false;
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // txt
            // 
            this.txt.AnimateReadOnly = false;
            this.txt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt.Depth = 0;
            this.txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt.HideSelection = true;
            this.txt.LeadingIcon = null;
            this.txt.Location = new System.Drawing.Point(7, 87);
            this.txt.MaxLength = 32767;
            this.txt.MouseState = MaterialSkin.MouseState.OUT;
            this.txt.Name = "txt";
            this.txt.PasswordChar = '\0';
            this.txt.PrefixSuffixText = null;
            this.txt.ReadOnly = false;
            this.txt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt.SelectedText = "";
            this.txt.SelectionLength = 0;
            this.txt.SelectionStart = 0;
            this.txt.ShortcutsEnabled = true;
            this.txt.Size = new System.Drawing.Size(502, 48);
            this.txt.TabIndex = 2;
            this.txt.TabStop = false;
            this.txt.Text = "Type Here";
            this.txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt.TrailingIcon = null;
            this.txt.UseSystemPasswordChar = false;
            // 
            // CustomDialog
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(516, 195);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomDialog";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Write Your Text";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnOk;
        private MaterialSkin.Controls.MaterialButton btnCancel;
        private MaterialSkin.Controls.MaterialTextBox2 txt;
    }
}