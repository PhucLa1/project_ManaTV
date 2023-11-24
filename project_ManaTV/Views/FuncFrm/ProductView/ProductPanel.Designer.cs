namespace project_ManaTV.Views.FuncFrm.ProductView
{
    partial class ProductPanel
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
            this.wrapperProduct = new System.Windows.Forms.TabControl();
            this.tabProductList = new System.Windows.Forms.TabPage();
            this.panelProducts = new System.Windows.Forms.Panel();
            this.tabBrand = new System.Windows.Forms.TabPage();
            this.panelBrand = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.tabDesign = new System.Windows.Forms.TabPage();
            this.tabColor = new System.Windows.Forms.TabPage();
            this.tabScreen = new System.Windows.Forms.TabPage();
            this.tabScreenSize = new System.Windows.Forms.TabPage();
            this.tabOrigin = new System.Windows.Forms.TabPage();
            this.wrapperProduct.SuspendLayout();
            this.tabProductList.SuspendLayout();
            this.tabBrand.SuspendLayout();
            this.SuspendLayout();
            // 
            // wrapperProduct
            // 
            this.wrapperProduct.Controls.Add(this.tabProductList);
            this.wrapperProduct.Controls.Add(this.tabBrand);
            this.wrapperProduct.Controls.Add(this.tabDesign);
            this.wrapperProduct.Controls.Add(this.tabColor);
            this.wrapperProduct.Controls.Add(this.tabScreen);
            this.wrapperProduct.Controls.Add(this.tabScreenSize);
            this.wrapperProduct.Controls.Add(this.tabOrigin);
            this.wrapperProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wrapperProduct.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wrapperProduct.Location = new System.Drawing.Point(0, 0);
            this.wrapperProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.wrapperProduct.Name = "wrapperProduct";
            this.wrapperProduct.Padding = new System.Drawing.Point(20, 5);
            this.wrapperProduct.SelectedIndex = 0;
            this.wrapperProduct.Size = new System.Drawing.Size(1217, 671);
            this.wrapperProduct.TabIndex = 3;
            this.wrapperProduct.SelectedIndexChanged += new System.EventHandler(this.wrapperProduct_SelectedIndexChanged);
            // 
            // tabProductList
            // 
            this.tabProductList.Controls.Add(this.panelProducts);
            this.tabProductList.Location = new System.Drawing.Point(4, 36);
            this.tabProductList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabProductList.Name = "tabProductList";
            this.tabProductList.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabProductList.Size = new System.Drawing.Size(1209, 631);
            this.tabProductList.TabIndex = 0;
            this.tabProductList.Text = "List Products";
            this.tabProductList.UseVisualStyleBackColor = true;
            // 
            // panelProducts
            // 
            this.panelProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelProducts.Location = new System.Drawing.Point(3, 2);
            this.panelProducts.Name = "panelProducts";
            this.panelProducts.Size = new System.Drawing.Size(1203, 627);
            this.panelProducts.TabIndex = 0;
            // 
            // tabBrand
            // 
            this.tabBrand.Controls.Add(this.panelBrand);
            this.tabBrand.Controls.Add(this.label3);
            this.tabBrand.Location = new System.Drawing.Point(4, 36);
            this.tabBrand.Margin = new System.Windows.Forms.Padding(0);
            this.tabBrand.Name = "tabBrand";
            this.tabBrand.Size = new System.Drawing.Size(1209, 631);
            this.tabBrand.TabIndex = 1;
            this.tabBrand.Text = "List Manufacturers";
            this.tabBrand.UseVisualStyleBackColor = true;
            // 
            // panelBrand
            // 
            this.panelBrand.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBrand.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.panelBrand.Location = new System.Drawing.Point(0, 0);
            this.panelBrand.Margin = new System.Windows.Forms.Padding(0);
            this.panelBrand.Name = "panelBrand";
            this.panelBrand.Size = new System.Drawing.Size(1209, 631);
            this.panelBrand.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 33);
            this.label3.TabIndex = 13;
            // 
            // tabDesign
            // 
            this.tabDesign.Location = new System.Drawing.Point(4, 36);
            this.tabDesign.Name = "tabDesign";
            this.tabDesign.Padding = new System.Windows.Forms.Padding(3);
            this.tabDesign.Size = new System.Drawing.Size(1209, 631);
            this.tabDesign.TabIndex = 2;
            this.tabDesign.Text = "List Designs";
            this.tabDesign.UseVisualStyleBackColor = true;
            // 
            // tabColor
            // 
            this.tabColor.Location = new System.Drawing.Point(4, 36);
            this.tabColor.Name = "tabColor";
            this.tabColor.Padding = new System.Windows.Forms.Padding(3);
            this.tabColor.Size = new System.Drawing.Size(1209, 631);
            this.tabColor.TabIndex = 3;
            this.tabColor.Text = "List Colors";
            this.tabColor.UseVisualStyleBackColor = true;
            // 
            // tabScreen
            // 
            this.tabScreen.Location = new System.Drawing.Point(4, 36);
            this.tabScreen.Name = "tabScreen";
            this.tabScreen.Padding = new System.Windows.Forms.Padding(3);
            this.tabScreen.Size = new System.Drawing.Size(1209, 631);
            this.tabScreen.TabIndex = 4;
            this.tabScreen.Text = "List Screen";
            this.tabScreen.UseVisualStyleBackColor = true;
            // 
            // tabScreenSize
            // 
            this.tabScreenSize.Location = new System.Drawing.Point(4, 36);
            this.tabScreenSize.Name = "tabScreenSize";
            this.tabScreenSize.Padding = new System.Windows.Forms.Padding(3);
            this.tabScreenSize.Size = new System.Drawing.Size(1209, 631);
            this.tabScreenSize.TabIndex = 5;
            this.tabScreenSize.Text = "List Screen Size";
            this.tabScreenSize.UseVisualStyleBackColor = true;
            // 
            // tabOrigin
            // 
            this.tabOrigin.Location = new System.Drawing.Point(4, 36);
            this.tabOrigin.Name = "tabOrigin";
            this.tabOrigin.Padding = new System.Windows.Forms.Padding(3);
            this.tabOrigin.Size = new System.Drawing.Size(1209, 631);
            this.tabOrigin.TabIndex = 6;
            this.tabOrigin.Text = "List Origins";
            this.tabOrigin.UseVisualStyleBackColor = true;
            // 
            // ProductPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 671);
            this.Controls.Add(this.wrapperProduct);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ProductPanel";
            this.Text = "ProductPanel";
            this.wrapperProduct.ResumeLayout(false);
            this.tabProductList.ResumeLayout(false);
            this.tabBrand.ResumeLayout(false);
            this.tabBrand.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl wrapperProduct;
        private System.Windows.Forms.TabPage tabBrand;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabProductList;
        private System.Windows.Forms.TabPage tabDesign;
        private System.Windows.Forms.TabPage tabColor;
        private System.Windows.Forms.TabPage tabScreen;
        private System.Windows.Forms.TabPage tabScreenSize;
        private System.Windows.Forms.TabPage tabOrigin;
        private System.Windows.Forms.Panel panelProducts;
        private System.Windows.Forms.Panel panelBrand;
    }
}