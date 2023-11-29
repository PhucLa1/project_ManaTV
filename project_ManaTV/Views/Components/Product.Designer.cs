namespace project_ManaTV.Views.Components
{
    partial class Product
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Product));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.ImageProduct = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.priceTxt = new Bunifu.UI.WinForms.BunifuTextBox();
            this.productNumber = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.productLb = new Bunifu.UI.WinForms.BunifuLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ImageProduct
            // 
            this.ImageProduct.Enabled = true;
            this.ImageProduct.Interval = 500;
            this.ImageProduct.Tick += new System.EventHandler(this.ImageProduct_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.panel1.Controls.Add(this.bunifuPictureBox1);
            this.panel1.Controls.Add(this.priceTxt);
            this.panel1.Controls.Add(this.productNumber);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.bunifuLabel1);
            this.panel1.Controls.Add(this.bunifuLabel2);
            this.panel1.Controls.Add(this.bunifuLabel3);
            this.panel1.Controls.Add(this.productLb);
            this.panel1.Location = new System.Drawing.Point(-3, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(681, 154);
            this.panel1.TabIndex = 3;
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox1.AutoSizeHeight = true;
            this.bunifuPictureBox1.BorderRadius = 11;
            this.bunifuPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuPictureBox1.Image")));
            this.bunifuPictureBox1.IsCircle = true;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(653, 3);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(22, 22);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 4;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            this.bunifuPictureBox1.Click += new System.EventHandler(this.bunifuPictureBox1_Click);
            // 
            // priceTxt
            // 
            this.priceTxt.AcceptsReturn = false;
            this.priceTxt.AcceptsTab = false;
            this.priceTxt.AnimationSpeed = 200;
            this.priceTxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.priceTxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.priceTxt.BackColor = System.Drawing.Color.Transparent;
            this.priceTxt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("priceTxt.BackgroundImage")));
            this.priceTxt.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.priceTxt.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.priceTxt.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.priceTxt.BorderColorIdle = System.Drawing.Color.Silver;
            this.priceTxt.BorderRadius = 1;
            this.priceTxt.BorderThickness = 1;
            this.priceTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.priceTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.priceTxt.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.priceTxt.DefaultText = "";
            this.priceTxt.FillColor = System.Drawing.Color.White;
            this.priceTxt.HideSelection = true;
            this.priceTxt.IconLeft = null;
            this.priceTxt.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.priceTxt.IconPadding = 10;
            this.priceTxt.IconRight = null;
            this.priceTxt.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.priceTxt.Lines = new string[0];
            this.priceTxt.Location = new System.Drawing.Point(457, 98);
            this.priceTxt.MaxLength = 32767;
            this.priceTxt.MinimumSize = new System.Drawing.Size(1, 1);
            this.priceTxt.Modified = false;
            this.priceTxt.Multiline = false;
            this.priceTxt.Name = "priceTxt";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.priceTxt.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.priceTxt.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.priceTxt.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.priceTxt.OnIdleState = stateProperties4;
            this.priceTxt.Padding = new System.Windows.Forms.Padding(3);
            this.priceTxt.PasswordChar = '\0';
            this.priceTxt.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.priceTxt.PlaceholderText = "Enter the bill price";
            this.priceTxt.ReadOnly = false;
            this.priceTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.priceTxt.SelectedText = "";
            this.priceTxt.SelectionLength = 0;
            this.priceTxt.SelectionStart = 0;
            this.priceTxt.ShortcutsEnabled = true;
            this.priceTxt.Size = new System.Drawing.Size(179, 36);
            this.priceTxt.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.priceTxt.TabIndex = 3;
            this.priceTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.priceTxt.TextMarginBottom = 0;
            this.priceTxt.TextMarginLeft = 3;
            this.priceTxt.TextMarginTop = 0;
            this.priceTxt.TextPlaceholder = "Enter the bill price";
            this.priceTxt.UseSystemPasswordChar = false;
            this.priceTxt.WordWrap = true;
            this.priceTxt.TextChanged += new System.EventHandler(this.priceTxt_TextChanged);
            
            // 
            // productNumber
            // 
            this.productNumber.Location = new System.Drawing.Point(241, 104);
            this.productNumber.Name = "productNumber";
            this.productNumber.Size = new System.Drawing.Size(100, 22);
            this.productNumber.TabIndex = 2;
            this.productNumber.ValueChanged += new System.EventHandler(this.productNumber_ValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.CursorType = null;
            this.bunifuLabel1.Font = new System.Drawing.Font("Times New Roman", 10.8F);
            this.bunifuLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuLabel1.Location = new System.Drawing.Point(167, 104);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(68, 20);
            this.bunifuLabel1.TabIndex = 1;
            this.bunifuLabel1.Text = "Number : ";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.CursorType = null;
            this.bunifuLabel2.Font = new System.Drawing.Font("Times New Roman", 10.8F);
            this.bunifuLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuLabel2.Location = new System.Drawing.Point(394, 106);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(46, 20);
            this.bunifuLabel2.TabIndex = 1;
            this.bunifuLabel2.Text = "Price : ";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AllowParentOverrides = false;
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.CursorType = null;
            this.bunifuLabel3.Font = new System.Drawing.Font("Times New Roman", 10.8F);
            this.bunifuLabel3.ForeColor = System.Drawing.Color.White;
            this.bunifuLabel3.Location = new System.Drawing.Point(167, 14);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(57, 20);
            this.bunifuLabel3.TabIndex = 1;
            this.bunifuLabel3.Text = "Product";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // productLb
            // 
            this.productLb.AllowParentOverrides = false;
            this.productLb.AutoEllipsis = false;
            this.productLb.CursorType = null;
            this.productLb.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.productLb.ForeColor = System.Drawing.SystemColors.Control;
            this.productLb.Location = new System.Drawing.Point(167, 40);
            this.productLb.Name = "productLb";
            this.productLb.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.productLb.Size = new System.Drawing.Size(483, 26);
            this.productLb.TabIndex = 1;
            this.productLb.Text = "Tivi + Manufacture + Screen + ScreenSize + Design ";
            this.productLb.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.productLb.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // Product
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panel1);
            this.Name = "Product";
            this.Size = new System.Drawing.Size(675, 156);
            this.Load += new System.EventHandler(this.Product_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer ImageProduct;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuTextBox priceTxt;
        private System.Windows.Forms.NumericUpDown productNumber;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
        private Bunifu.UI.WinForms.BunifuLabel productLb;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
    }
}
