namespace D12_SD43_Task2
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.quanBox = new System.Windows.Forms.TextBox();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.disBox = new System.Windows.Forms.TextBox();
            this.idBox = new System.Windows.Forms.NumericUpDown();
            this.priceBox = new System.Windows.Forms.NumericUpDown();
            this.orderBox = new System.Windows.Forms.NumericUpDown();
            this.stockBox = new System.Windows.Forms.NumericUpDown();
            this.levelBox = new System.Windows.Forms.NumericUpDown();
            this.catCombo = new System.Windows.Forms.ComboBox();
            this.suppCombo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.idBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.levelBox)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(94, 104);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(16, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "ID";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(94, 174);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(70, 19);
            this.materialLabel2.TabIndex = 4;
            this.materialLabel2.Text = "SupplerID";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(94, 209);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(79, 19);
            this.materialLabel3.TabIndex = 6;
            this.materialLabel3.Text = "CategoryID";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(94, 244);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(117, 19);
            this.materialLabel4.TabIndex = 8;
            this.materialLabel4.Text = "QuntatityPerUnit";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(94, 279);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(64, 19);
            this.materialLabel5.TabIndex = 10;
            this.materialLabel5.Text = "UnitPrice";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(94, 139);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(98, 19);
            this.materialLabel6.TabIndex = 2;
            this.materialLabel6.Text = "ProductName";
            // 
            // nameBox
            // 
            this.nameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameBox.Location = new System.Drawing.Point(249, 139);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(261, 23);
            this.nameBox.TabIndex = 3;
            // 
            // quanBox
            // 
            this.quanBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.quanBox.Location = new System.Drawing.Point(249, 244);
            this.quanBox.Name = "quanBox";
            this.quanBox.Size = new System.Drawing.Size(261, 23);
            this.quanBox.TabIndex = 9;
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.Location = new System.Drawing.Point(94, 314);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(82, 19);
            this.materialLabel7.TabIndex = 12;
            this.materialLabel7.Text = "UnitInStock";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.Location = new System.Drawing.Point(94, 419);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(94, 19);
            this.materialLabel8.TabIndex = 18;
            this.materialLabel8.Text = "Discontinued";
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.Location = new System.Drawing.Point(94, 384);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(92, 19);
            this.materialLabel9.TabIndex = 16;
            this.materialLabel9.Text = "ReorderLevel";
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel10.Location = new System.Drawing.Point(94, 349);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(88, 19);
            this.materialLabel10.TabIndex = 14;
            this.materialLabel10.Text = "UnitsInOrder";
            // 
            // disBox
            // 
            this.disBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.disBox.Location = new System.Drawing.Point(249, 419);
            this.disBox.Name = "disBox";
            this.disBox.Size = new System.Drawing.Size(261, 23);
            this.disBox.TabIndex = 19;
            // 
            // idBox
            // 
            this.idBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.idBox.Location = new System.Drawing.Point(249, 104);
            this.idBox.Maximum = new decimal(new int[] {
            1874919423,
            2328306,
            0,
            0});
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(261, 23);
            this.idBox.TabIndex = 1;
            // 
            // priceBox
            // 
            this.priceBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.priceBox.Location = new System.Drawing.Point(249, 279);
            this.priceBox.Maximum = new decimal(new int[] {
            -1981284353,
            -1966660860,
            0,
            0});
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(261, 23);
            this.priceBox.TabIndex = 11;
            // 
            // orderBox
            // 
            this.orderBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.orderBox.Location = new System.Drawing.Point(249, 349);
            this.orderBox.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            0});
            this.orderBox.Name = "orderBox";
            this.orderBox.Size = new System.Drawing.Size(261, 23);
            this.orderBox.TabIndex = 15;
            // 
            // stockBox
            // 
            this.stockBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stockBox.Location = new System.Drawing.Point(249, 314);
            this.stockBox.Maximum = new decimal(new int[] {
            1874919423,
            2328306,
            0,
            0});
            this.stockBox.Name = "stockBox";
            this.stockBox.Size = new System.Drawing.Size(261, 23);
            this.stockBox.TabIndex = 13;
            // 
            // levelBox
            // 
            this.levelBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.levelBox.Location = new System.Drawing.Point(249, 384);
            this.levelBox.Maximum = new decimal(new int[] {
            -1981284353,
            -1966660860,
            0,
            0});
            this.levelBox.Name = "levelBox";
            this.levelBox.Size = new System.Drawing.Size(261, 23);
            this.levelBox.TabIndex = 17;
            // 
            // catCombo
            // 
            this.catCombo.FormattingEnabled = true;
            this.catCombo.Location = new System.Drawing.Point(249, 209);
            this.catCombo.Name = "catCombo";
            this.catCombo.Size = new System.Drawing.Size(261, 23);
            this.catCombo.TabIndex = 20;
            // 
            // suppCombo
            // 
            this.suppCombo.FormattingEnabled = true;
            this.suppCombo.Location = new System.Drawing.Point(249, 174);
            this.suppCombo.Name = "suppCombo";
            this.suppCombo.Size = new System.Drawing.Size(261, 23);
            this.suppCombo.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 493);
            this.Controls.Add(this.suppCombo);
            this.Controls.Add(this.catCombo);
            this.Controls.Add(this.levelBox);
            this.Controls.Add(this.stockBox);
            this.Controls.Add(this.orderBox);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.disBox);
            this.Controls.Add(this.materialLabel10);
            this.Controls.Add(this.materialLabel9);
            this.Controls.Add(this.materialLabel8);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.quanBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.MinimumSize = new System.Drawing.Size(800, 493);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.idBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.levelBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private TextBox nameBox;
        private TextBox quanBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private TextBox disBox;
        private NumericUpDown idBox;
        private NumericUpDown priceBox;
        private NumericUpDown orderBox;
        private NumericUpDown stockBox;
        private NumericUpDown levelBox;
        private ComboBox catCombo;
        private ComboBox suppCombo;
    }
}