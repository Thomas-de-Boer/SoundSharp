namespace SoundSharp
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            lstStock = new ListBox();
            ckbName = new CheckBox();
            pcbBottomImg = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pcbBottomImg).BeginInit();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Magenta;
            btnAdd.Location = new Point(33, 32);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(190, 103);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Plus";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.Cyan;
            btnEdit.Location = new Point(33, 141);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(190, 103);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Change";
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Yellow;
            btnDelete.Location = new Point(33, 250);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(190, 103);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // lstStock
            // 
            lstStock.FormattingEnabled = true;
            lstStock.Location = new Point(229, 55);
            lstStock.Name = "lstStock";
            lstStock.Size = new Size(446, 304);
            lstStock.TabIndex = 3;
            lstStock.SelectedIndexChanged += lstStock_SelectedIndexChanged;
            // 
            // ckbName
            // 
            ckbName.AutoSize = true;
            ckbName.Location = new Point(229, 32);
            ckbName.Name = "ckbName";
            ckbName.RightToLeft = RightToLeft.Yes;
            ckbName.Size = new Size(67, 24);
            ckbName.TabIndex = 5;
            ckbName.Text = "Stock";
            ckbName.UseVisualStyleBackColor = true;
            // 
            // pcbBottomImg
            // 
            pcbBottomImg.Image = (Image)resources.GetObject("pcbBottomImg.Image");
            pcbBottomImg.Location = new Point(33, 359);
            pcbBottomImg.Name = "pcbBottomImg";
            pcbBottomImg.Size = new Size(642, 288);
            pcbBottomImg.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbBottomImg.TabIndex = 6;
            pcbBottomImg.TabStop = false;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lime;
            ClientSize = new Size(708, 650);
            Controls.Add(pcbBottomImg);
            Controls.Add(ckbName);
            Controls.Add(lstStock);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            ForeColor = SystemColors.ControlText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmMain";
            Text = "SoundSharp";
            Load += frmMain_Load;
            ((System.ComponentModel.ISupportInitialize)pcbBottomImg).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private ListBox lstStock;
        private CheckBox ckbName;
        private PictureBox pcbBottomImg;
    }
}
