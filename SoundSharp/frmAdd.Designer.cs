namespace SoundSharp
{
    partial class frmAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdd));
            btnCancel = new Button();
            btnOk = new Button();
            tbxBrand = new TextBox();
            tbxModel = new TextBox();
            tbxSize = new TextBox();
            tbxPrice = new TextBox();
            nudStock = new NumericUpDown();
            lblBrand = new Label();
            lblModel = new Label();
            lblSize = new Label();
            lblPrice = new Label();
            lblStock = new Label();
            pcbBrandImg = new PictureBox();
            pcbModelImg = new PictureBox();
            pcbSizeImg = new PictureBox();
            pcbPriceImg = new PictureBox();
            pcbStockImg = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)nudStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbBrandImg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbModelImg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbSizeImg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbPriceImg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbStockImg).BeginInit();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(73, 201);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(220, 201);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(94, 29);
            btnOk.TabIndex = 1;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            // 
            // tbxBrand
            // 
            tbxBrand.BackColor = Color.Magenta;
            tbxBrand.Location = new Point(179, 22);
            tbxBrand.Name = "tbxBrand";
            tbxBrand.Size = new Size(199, 27);
            tbxBrand.TabIndex = 2;
            // 
            // tbxModel
            // 
            tbxModel.BackColor = Color.Cyan;
            tbxModel.Location = new Point(179, 55);
            tbxModel.Name = "tbxModel";
            tbxModel.Size = new Size(199, 27);
            tbxModel.TabIndex = 3;
            // 
            // tbxSize
            // 
            tbxSize.BackColor = Color.Yellow;
            tbxSize.Location = new Point(179, 88);
            tbxSize.Name = "tbxSize";
            tbxSize.Size = new Size(199, 27);
            tbxSize.TabIndex = 4;
            // 
            // tbxPrice
            // 
            tbxPrice.BackColor = Color.Cyan;
            tbxPrice.Location = new Point(179, 121);
            tbxPrice.Name = "tbxPrice";
            tbxPrice.Size = new Size(199, 27);
            tbxPrice.TabIndex = 5;
            // 
            // nudStock
            // 
            nudStock.BackColor = Color.Magenta;
            nudStock.Location = new Point(179, 154);
            nudStock.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            nudStock.Name = "nudStock";
            nudStock.Size = new Size(199, 27);
            nudStock.TabIndex = 6;
            // 
            // lblBrand
            // 
            lblBrand.AutoSize = true;
            lblBrand.Location = new Point(18, 25);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(48, 20);
            lblBrand.TabIndex = 7;
            lblBrand.Text = "Brand";
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.Location = new Point(18, 58);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(52, 20);
            lblModel.TabIndex = 8;
            lblModel.Text = "Model";
            // 
            // lblSize
            // 
            lblSize.AutoSize = true;
            lblSize.Location = new Point(18, 91);
            lblSize.Name = "lblSize";
            lblSize.Size = new Size(36, 20);
            lblSize.TabIndex = 9;
            lblSize.Text = "Size";
            lblSize.Click += label3_Click;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(18, 124);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(41, 20);
            lblPrice.TabIndex = 10;
            lblPrice.Text = "Price";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(18, 156);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(45, 20);
            lblStock.TabIndex = 11;
            lblStock.Text = "Stock";
            // 
            // pcbBrandImg
            // 
            pcbBrandImg.Image = (Image)resources.GetObject("pcbBrandImg.Image");
            pcbBrandImg.Location = new Point(73, 22);
            pcbBrandImg.Name = "pcbBrandImg";
            pcbBrandImg.Size = new Size(100, 27);
            pcbBrandImg.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbBrandImg.TabIndex = 12;
            pcbBrandImg.TabStop = false;
            // 
            // pcbModelImg
            // 
            pcbModelImg.Image = (Image)resources.GetObject("pcbModelImg.Image");
            pcbModelImg.Location = new Point(73, 55);
            pcbModelImg.Name = "pcbModelImg";
            pcbModelImg.Size = new Size(100, 27);
            pcbModelImg.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbModelImg.TabIndex = 13;
            pcbModelImg.TabStop = false;
            // 
            // pcbSizeImg
            // 
            pcbSizeImg.Image = (Image)resources.GetObject("pcbSizeImg.Image");
            pcbSizeImg.Location = new Point(73, 88);
            pcbSizeImg.Name = "pcbSizeImg";
            pcbSizeImg.Size = new Size(100, 27);
            pcbSizeImg.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbSizeImg.TabIndex = 14;
            pcbSizeImg.TabStop = false;
            // 
            // pcbPriceImg
            // 
            pcbPriceImg.Image = (Image)resources.GetObject("pcbPriceImg.Image");
            pcbPriceImg.Location = new Point(73, 121);
            pcbPriceImg.Name = "pcbPriceImg";
            pcbPriceImg.Size = new Size(100, 27);
            pcbPriceImg.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbPriceImg.TabIndex = 15;
            pcbPriceImg.TabStop = false;
            // 
            // pcbStockImg
            // 
            pcbStockImg.Image = (Image)resources.GetObject("pcbStockImg.Image");
            pcbStockImg.Location = new Point(73, 154);
            pcbStockImg.Name = "pcbStockImg";
            pcbStockImg.Size = new Size(100, 27);
            pcbStockImg.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbStockImg.TabIndex = 16;
            pcbStockImg.TabStop = false;
            // 
            // frmAdd
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lime;
            ClientSize = new Size(395, 251);
            Controls.Add(pcbStockImg);
            Controls.Add(pcbPriceImg);
            Controls.Add(pcbSizeImg);
            Controls.Add(pcbModelImg);
            Controls.Add(pcbBrandImg);
            Controls.Add(lblStock);
            Controls.Add(lblPrice);
            Controls.Add(lblSize);
            Controls.Add(lblModel);
            Controls.Add(lblBrand);
            Controls.Add(nudStock);
            Controls.Add(tbxPrice);
            Controls.Add(tbxSize);
            Controls.Add(tbxModel);
            Controls.Add(tbxBrand);
            Controls.Add(btnOk);
            Controls.Add(btnCancel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmAdd";
            Text = "Add Phone";
            ((System.ComponentModel.ISupportInitialize)nudStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbBrandImg).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbModelImg).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbSizeImg).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbPriceImg).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbStockImg).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnOk;
        private TextBox tbxBrand;
        private TextBox tbxModel;
        private TextBox tbxSize;
        private TextBox tbxPrice;
        private NumericUpDown nudStock;
        private Label lblBrand;
        private Label lblModel;
        private Label lblSize;
        private Label lblPrice;
        private Label lblStock;
        private PictureBox pcbBrandImg;
        private PictureBox pcbModelImg;
        private PictureBox pcbSizeImg;
        private PictureBox pcbPriceImg;
        private PictureBox pcbStockImg;
    }
}