namespace project_ManaTV.Views.FuncFrm.BrandView
{
    partial class FrmListBrands
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListBrands));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges7 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tvManagementDataSet1 = new project_ManaTV.TVManagementDataSet();
            this.snackBarTab = new Bunifu.UI.WinForms.BunifuSnackbar(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.dpPageSize = new Bunifu.UI.WinForms.BunifuDropdown();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNext = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnThirdPage = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnSecondPage = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnFirstPage = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnPrev = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddNew = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.flowFilter = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSearch = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.dpFilter = new Bunifu.UI.WinForms.BunifuDropdown();
            this.txtSearch = new Bunifu.UI.WinForms.BunifuTextBox();
            this.gridData = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actionDetails = new System.Windows.Forms.DataGridViewImageColumn();
            this.actionUpdate = new System.Windows.Forms.DataGridViewImageColumn();
            this.actionDelete = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tvManagementDataSet1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridData)).BeginInit();
            this.SuspendLayout();
            // 
            // tvManagementDataSet1
            // 
            this.tvManagementDataSet1.DataSetName = "TVManagementDataSet";
            this.tvManagementDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // snackBarTab
            // 
            this.snackBarTab.AllowDragging = false;
            this.snackBarTab.AllowMultipleViews = true;
            this.snackBarTab.ClickToClose = true;
            this.snackBarTab.DoubleClickToClose = true;
            this.snackBarTab.DurationAfterIdle = 3000;
            this.snackBarTab.ErrorOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.snackBarTab.ErrorOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.snackBarTab.ErrorOptions.ActionBorderRadius = 1;
            this.snackBarTab.ErrorOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.snackBarTab.ErrorOptions.ActionForeColor = System.Drawing.Color.Black;
            this.snackBarTab.ErrorOptions.BackColor = System.Drawing.Color.White;
            this.snackBarTab.ErrorOptions.BorderColor = System.Drawing.Color.White;
            this.snackBarTab.ErrorOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(199)))));
            this.snackBarTab.ErrorOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.snackBarTab.ErrorOptions.ForeColor = System.Drawing.Color.Black;
            this.snackBarTab.ErrorOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon")));
            this.snackBarTab.ErrorOptions.IconLeftMargin = 12;
            this.snackBarTab.FadeCloseIcon = false;
            this.snackBarTab.Host = Bunifu.UI.WinForms.BunifuSnackbar.Hosts.FormOwner;
            this.snackBarTab.InformationOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.snackBarTab.InformationOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.snackBarTab.InformationOptions.ActionBorderRadius = 1;
            this.snackBarTab.InformationOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.snackBarTab.InformationOptions.ActionForeColor = System.Drawing.Color.Black;
            this.snackBarTab.InformationOptions.BackColor = System.Drawing.Color.White;
            this.snackBarTab.InformationOptions.BorderColor = System.Drawing.Color.White;
            this.snackBarTab.InformationOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.snackBarTab.InformationOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.snackBarTab.InformationOptions.ForeColor = System.Drawing.Color.Black;
            this.snackBarTab.InformationOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon1")));
            this.snackBarTab.InformationOptions.IconLeftMargin = 12;
            this.snackBarTab.Margin = 0;
            this.snackBarTab.MaximumSize = new System.Drawing.Size(0, 0);
            this.snackBarTab.MaximumViews = 7;
            this.snackBarTab.MessageRightMargin = 15;
            this.snackBarTab.MinimumSize = new System.Drawing.Size(0, 0);
            this.snackBarTab.ShowBorders = false;
            this.snackBarTab.ShowCloseIcon = true;
            this.snackBarTab.ShowIcon = true;
            this.snackBarTab.ShowShadows = true;
            this.snackBarTab.SuccessOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.snackBarTab.SuccessOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.snackBarTab.SuccessOptions.ActionBorderRadius = 1;
            this.snackBarTab.SuccessOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.snackBarTab.SuccessOptions.ActionForeColor = System.Drawing.Color.Black;
            this.snackBarTab.SuccessOptions.BackColor = System.Drawing.Color.White;
            this.snackBarTab.SuccessOptions.BorderColor = System.Drawing.Color.White;
            this.snackBarTab.SuccessOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(255)))), ((int)(((byte)(237)))));
            this.snackBarTab.SuccessOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.snackBarTab.SuccessOptions.ForeColor = System.Drawing.Color.Black;
            this.snackBarTab.SuccessOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon2")));
            this.snackBarTab.SuccessOptions.IconLeftMargin = 12;
            this.snackBarTab.ViewsMargin = 7;
            this.snackBarTab.WarningOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.snackBarTab.WarningOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.snackBarTab.WarningOptions.ActionBorderRadius = 1;
            this.snackBarTab.WarningOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.snackBarTab.WarningOptions.ActionForeColor = System.Drawing.Color.Black;
            this.snackBarTab.WarningOptions.BackColor = System.Drawing.Color.White;
            this.snackBarTab.WarningOptions.BorderColor = System.Drawing.Color.White;
            this.snackBarTab.WarningOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(143)))));
            this.snackBarTab.WarningOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.snackBarTab.WarningOptions.ForeColor = System.Drawing.Color.Black;
            this.snackBarTab.WarningOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon3")));
            this.snackBarTab.WarningOptions.IconLeftMargin = 12;
            this.snackBarTab.ZoomCloseIcon = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.dpPageSize);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(8, 538);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(317, 49);
            this.flowLayoutPanel1.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Records per view";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dpPageSize
            // 
            this.dpPageSize.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dpPageSize.BackColor = System.Drawing.Color.Transparent;
            this.dpPageSize.BackgroundColor = System.Drawing.Color.White;
            this.dpPageSize.BorderColor = System.Drawing.Color.Silver;
            this.dpPageSize.BorderRadius = 1;
            this.dpPageSize.Color = System.Drawing.Color.Silver;
            this.dpPageSize.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.dpPageSize.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dpPageSize.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.dpPageSize.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dpPageSize.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.dpPageSize.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.dpPageSize.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.dpPageSize.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.dpPageSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dpPageSize.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.dpPageSize.FillDropDown = true;
            this.dpPageSize.FillIndicator = false;
            this.dpPageSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dpPageSize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dpPageSize.ForeColor = System.Drawing.Color.Black;
            this.dpPageSize.FormattingEnabled = true;
            this.dpPageSize.Icon = null;
            this.dpPageSize.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.dpPageSize.IndicatorColor = System.Drawing.Color.Gray;
            this.dpPageSize.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.dpPageSize.ItemBackColor = System.Drawing.Color.White;
            this.dpPageSize.ItemBorderColor = System.Drawing.Color.White;
            this.dpPageSize.ItemForeColor = System.Drawing.Color.Black;
            this.dpPageSize.ItemHeight = 26;
            this.dpPageSize.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.dpPageSize.ItemHighLightForeColor = System.Drawing.Color.White;
            this.dpPageSize.Items.AddRange(new object[] {
            "10",
            "25",
            "50",
            "100"});
            this.dpPageSize.ItemTopMargin = 3;
            this.dpPageSize.Location = new System.Drawing.Point(147, 4);
            this.dpPageSize.Margin = new System.Windows.Forms.Padding(4);
            this.dpPageSize.Name = "dpPageSize";
            this.dpPageSize.Size = new System.Drawing.Size(120, 32);
            this.dpPageSize.TabIndex = 1;
            this.dpPageSize.Text = null;
            this.dpPageSize.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.dpPageSize.TextLeftMargin = 5;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel3.Controls.Add(this.btnNext);
            this.flowLayoutPanel3.Controls.Add(this.btnThirdPage);
            this.flowLayoutPanel3.Controls.Add(this.btnSecondPage);
            this.flowLayoutPanel3.Controls.Add(this.btnFirstPage);
            this.flowLayoutPanel3.Controls.Add(this.btnPrev);
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(935, 537);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(257, 53);
            this.flowLayoutPanel3.TabIndex = 19;
            // 
            // btnNext
            // 
            this.btnNext.AllowAnimations = true;
            this.btnNext.AllowMouseEffects = true;
            this.btnNext.AllowToggling = false;
            this.btnNext.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnNext.AnimationSpeed = 200;
            this.btnNext.AutoGenerateColors = false;
            this.btnNext.AutoRoundBorders = false;
            this.btnNext.AutoSizeLeftIcon = true;
            this.btnNext.AutoSizeRightIcon = true;
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.BackColor1 = System.Drawing.Color.Transparent;
            this.btnNext.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNext.BackgroundImage")));
            this.btnNext.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnNext.ButtonText = "";
            this.btnNext.ButtonTextMarginLeft = 0;
            this.btnNext.ColorContrastOnClick = 45;
            this.btnNext.ColorContrastOnHover = 45;
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnNext.CustomizableEdges = borderEdges1;
            this.btnNext.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnNext.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnNext.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnNext.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnNext.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnNext.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNext.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnNext.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnNext.IconMarginLeft = 11;
            this.btnNext.IconPadding = 10;
            this.btnNext.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNext.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnNext.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnNext.IconSize = 25;
            this.btnNext.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btnNext.IdleBorderRadius = 5;
            this.btnNext.IdleBorderThickness = 1;
            this.btnNext.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnNext.IdleIconLeftImage = global::project_ManaTV.Properties.Resources.angle_right_solid;
            this.btnNext.IdleIconRightImage = null;
            this.btnNext.IndicateFocus = false;
            this.btnNext.Location = new System.Drawing.Point(209, 4);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4);
            this.btnNext.Name = "btnNext";
            this.btnNext.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnNext.OnDisabledState.BorderRadius = 5;
            this.btnNext.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnNext.OnDisabledState.BorderThickness = 1;
            this.btnNext.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnNext.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnNext.OnDisabledState.IconLeftImage = null;
            this.btnNext.OnDisabledState.IconRightImage = null;
            this.btnNext.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnNext.onHoverState.BorderRadius = 5;
            this.btnNext.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnNext.onHoverState.BorderThickness = 1;
            this.btnNext.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnNext.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnNext.onHoverState.IconLeftImage = null;
            this.btnNext.onHoverState.IconRightImage = null;
            this.btnNext.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnNext.OnIdleState.BorderRadius = 5;
            this.btnNext.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnNext.OnIdleState.BorderThickness = 1;
            this.btnNext.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.btnNext.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnNext.OnIdleState.IconLeftImage = global::project_ManaTV.Properties.Resources.angle_right_solid;
            this.btnNext.OnIdleState.IconRightImage = null;
            this.btnNext.OnPressedState.BorderColor = System.Drawing.Color.Transparent;
            this.btnNext.OnPressedState.BorderRadius = 5;
            this.btnNext.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnNext.OnPressedState.BorderThickness = 1;
            this.btnNext.OnPressedState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnNext.OnPressedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnNext.OnPressedState.IconLeftImage = null;
            this.btnNext.OnPressedState.IconRightImage = null;
            this.btnNext.Size = new System.Drawing.Size(44, 41);
            this.btnNext.TabIndex = 5;
            this.btnNext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNext.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnNext.TextMarginLeft = 0;
            this.btnNext.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnNext.UseDefaultRadiusAndThickness = true;
            // 
            // btnThirdPage
            // 
            this.btnThirdPage.AllowAnimations = true;
            this.btnThirdPage.AllowMouseEffects = false;
            this.btnThirdPage.AllowToggling = false;
            this.btnThirdPage.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnThirdPage.AnimationSpeed = 200;
            this.btnThirdPage.AutoGenerateColors = false;
            this.btnThirdPage.AutoRoundBorders = false;
            this.btnThirdPage.AutoSizeLeftIcon = true;
            this.btnThirdPage.AutoSizeRightIcon = true;
            this.btnThirdPage.BackColor = System.Drawing.Color.Transparent;
            this.btnThirdPage.BackColor1 = System.Drawing.Color.Transparent;
            this.btnThirdPage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThirdPage.BackgroundImage")));
            this.btnThirdPage.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnThirdPage.ButtonText = "3";
            this.btnThirdPage.ButtonTextMarginLeft = 0;
            this.btnThirdPage.ColorContrastOnClick = 45;
            this.btnThirdPage.ColorContrastOnHover = 45;
            this.btnThirdPage.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnThirdPage.CustomizableEdges = borderEdges2;
            this.btnThirdPage.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnThirdPage.DisabledBorderColor = System.Drawing.Color.Transparent;
            this.btnThirdPage.DisabledFillColor = System.Drawing.Color.Transparent;
            this.btnThirdPage.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnThirdPage.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Hover;
            this.btnThirdPage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThirdPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnThirdPage.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThirdPage.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnThirdPage.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnThirdPage.IconMarginLeft = 11;
            this.btnThirdPage.IconPadding = 10;
            this.btnThirdPage.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThirdPage.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnThirdPage.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnThirdPage.IconSize = 25;
            this.btnThirdPage.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btnThirdPage.IdleBorderRadius = 5;
            this.btnThirdPage.IdleBorderThickness = 1;
            this.btnThirdPage.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnThirdPage.IdleIconLeftImage = null;
            this.btnThirdPage.IdleIconRightImage = null;
            this.btnThirdPage.IndicateFocus = false;
            this.btnThirdPage.Location = new System.Drawing.Point(159, 4);
            this.btnThirdPage.Margin = new System.Windows.Forms.Padding(4);
            this.btnThirdPage.Name = "btnThirdPage";
            this.btnThirdPage.OnDisabledState.BorderColor = System.Drawing.Color.Transparent;
            this.btnThirdPage.OnDisabledState.BorderRadius = 5;
            this.btnThirdPage.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnThirdPage.OnDisabledState.BorderThickness = 1;
            this.btnThirdPage.OnDisabledState.FillColor = System.Drawing.Color.Transparent;
            this.btnThirdPage.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnThirdPage.OnDisabledState.IconLeftImage = null;
            this.btnThirdPage.OnDisabledState.IconRightImage = null;
            this.btnThirdPage.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnThirdPage.onHoverState.BorderRadius = 5;
            this.btnThirdPage.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnThirdPage.onHoverState.BorderThickness = 1;
            this.btnThirdPage.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnThirdPage.onHoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnThirdPage.onHoverState.IconLeftImage = null;
            this.btnThirdPage.onHoverState.IconRightImage = null;
            this.btnThirdPage.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnThirdPage.OnIdleState.BorderRadius = 5;
            this.btnThirdPage.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnThirdPage.OnIdleState.BorderThickness = 1;
            this.btnThirdPage.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.btnThirdPage.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnThirdPage.OnIdleState.IconLeftImage = null;
            this.btnThirdPage.OnIdleState.IconRightImage = null;
            this.btnThirdPage.OnPressedState.BorderColor = System.Drawing.Color.Transparent;
            this.btnThirdPage.OnPressedState.BorderRadius = 5;
            this.btnThirdPage.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnThirdPage.OnPressedState.BorderThickness = 1;
            this.btnThirdPage.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnThirdPage.OnPressedState.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnThirdPage.OnPressedState.IconLeftImage = null;
            this.btnThirdPage.OnPressedState.IconRightImage = null;
            this.btnThirdPage.Size = new System.Drawing.Size(42, 41);
            this.btnThirdPage.TabIndex = 4;
            this.btnThirdPage.Tag = "3";
            this.btnThirdPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnThirdPage.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnThirdPage.TextMarginLeft = 0;
            this.btnThirdPage.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnThirdPage.UseDefaultRadiusAndThickness = true;
            // 
            // btnSecondPage
            // 
            this.btnSecondPage.AllowAnimations = true;
            this.btnSecondPage.AllowMouseEffects = false;
            this.btnSecondPage.AllowToggling = false;
            this.btnSecondPage.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSecondPage.AnimationSpeed = 200;
            this.btnSecondPage.AutoGenerateColors = false;
            this.btnSecondPage.AutoRoundBorders = false;
            this.btnSecondPage.AutoSizeLeftIcon = true;
            this.btnSecondPage.AutoSizeRightIcon = true;
            this.btnSecondPage.BackColor = System.Drawing.Color.Transparent;
            this.btnSecondPage.BackColor1 = System.Drawing.Color.Transparent;
            this.btnSecondPage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSecondPage.BackgroundImage")));
            this.btnSecondPage.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSecondPage.ButtonText = "2";
            this.btnSecondPage.ButtonTextMarginLeft = 0;
            this.btnSecondPage.ColorContrastOnClick = 45;
            this.btnSecondPage.ColorContrastOnHover = 45;
            this.btnSecondPage.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btnSecondPage.CustomizableEdges = borderEdges3;
            this.btnSecondPage.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSecondPage.DisabledBorderColor = System.Drawing.Color.Transparent;
            this.btnSecondPage.DisabledFillColor = System.Drawing.Color.Transparent;
            this.btnSecondPage.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnSecondPage.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Hover;
            this.btnSecondPage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSecondPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnSecondPage.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSecondPage.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnSecondPage.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnSecondPage.IconMarginLeft = 11;
            this.btnSecondPage.IconPadding = 10;
            this.btnSecondPage.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSecondPage.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnSecondPage.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnSecondPage.IconSize = 25;
            this.btnSecondPage.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btnSecondPage.IdleBorderRadius = 5;
            this.btnSecondPage.IdleBorderThickness = 1;
            this.btnSecondPage.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnSecondPage.IdleIconLeftImage = null;
            this.btnSecondPage.IdleIconRightImage = null;
            this.btnSecondPage.IndicateFocus = false;
            this.btnSecondPage.Location = new System.Drawing.Point(109, 4);
            this.btnSecondPage.Margin = new System.Windows.Forms.Padding(4);
            this.btnSecondPage.Name = "btnSecondPage";
            this.btnSecondPage.OnDisabledState.BorderColor = System.Drawing.Color.Transparent;
            this.btnSecondPage.OnDisabledState.BorderRadius = 5;
            this.btnSecondPage.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSecondPage.OnDisabledState.BorderThickness = 1;
            this.btnSecondPage.OnDisabledState.FillColor = System.Drawing.Color.Transparent;
            this.btnSecondPage.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnSecondPage.OnDisabledState.IconLeftImage = null;
            this.btnSecondPage.OnDisabledState.IconRightImage = null;
            this.btnSecondPage.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnSecondPage.onHoverState.BorderRadius = 5;
            this.btnSecondPage.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSecondPage.onHoverState.BorderThickness = 1;
            this.btnSecondPage.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnSecondPage.onHoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnSecondPage.onHoverState.IconLeftImage = null;
            this.btnSecondPage.onHoverState.IconRightImage = null;
            this.btnSecondPage.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnSecondPage.OnIdleState.BorderRadius = 5;
            this.btnSecondPage.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSecondPage.OnIdleState.BorderThickness = 1;
            this.btnSecondPage.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.btnSecondPage.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnSecondPage.OnIdleState.IconLeftImage = null;
            this.btnSecondPage.OnIdleState.IconRightImage = null;
            this.btnSecondPage.OnPressedState.BorderColor = System.Drawing.Color.Transparent;
            this.btnSecondPage.OnPressedState.BorderRadius = 5;
            this.btnSecondPage.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSecondPage.OnPressedState.BorderThickness = 1;
            this.btnSecondPage.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnSecondPage.OnPressedState.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSecondPage.OnPressedState.IconLeftImage = null;
            this.btnSecondPage.OnPressedState.IconRightImage = null;
            this.btnSecondPage.Size = new System.Drawing.Size(42, 41);
            this.btnSecondPage.TabIndex = 3;
            this.btnSecondPage.Tag = "2";
            this.btnSecondPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSecondPage.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSecondPage.TextMarginLeft = 0;
            this.btnSecondPage.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnSecondPage.UseDefaultRadiusAndThickness = true;
            // 
            // btnFirstPage
            // 
            this.btnFirstPage.AllowAnimations = true;
            this.btnFirstPage.AllowMouseEffects = false;
            this.btnFirstPage.AllowToggling = false;
            this.btnFirstPage.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnFirstPage.AnimationSpeed = 200;
            this.btnFirstPage.AutoGenerateColors = false;
            this.btnFirstPage.AutoRoundBorders = false;
            this.btnFirstPage.AutoSizeLeftIcon = true;
            this.btnFirstPage.AutoSizeRightIcon = true;
            this.btnFirstPage.BackColor = System.Drawing.Color.Transparent;
            this.btnFirstPage.BackColor1 = System.Drawing.Color.Transparent;
            this.btnFirstPage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFirstPage.BackgroundImage")));
            this.btnFirstPage.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnFirstPage.ButtonText = "1";
            this.btnFirstPage.ButtonTextMarginLeft = 0;
            this.btnFirstPage.ColorContrastOnClick = 45;
            this.btnFirstPage.ColorContrastOnHover = 45;
            this.btnFirstPage.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.btnFirstPage.CustomizableEdges = borderEdges4;
            this.btnFirstPage.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnFirstPage.DisabledBorderColor = System.Drawing.Color.Transparent;
            this.btnFirstPage.DisabledFillColor = System.Drawing.Color.Transparent;
            this.btnFirstPage.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnFirstPage.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Hover;
            this.btnFirstPage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirstPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnFirstPage.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFirstPage.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnFirstPage.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnFirstPage.IconMarginLeft = 11;
            this.btnFirstPage.IconPadding = 10;
            this.btnFirstPage.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFirstPage.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnFirstPage.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnFirstPage.IconSize = 25;
            this.btnFirstPage.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btnFirstPage.IdleBorderRadius = 5;
            this.btnFirstPage.IdleBorderThickness = 1;
            this.btnFirstPage.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnFirstPage.IdleIconLeftImage = null;
            this.btnFirstPage.IdleIconRightImage = null;
            this.btnFirstPage.IndicateFocus = false;
            this.btnFirstPage.Location = new System.Drawing.Point(62, 4);
            this.btnFirstPage.Margin = new System.Windows.Forms.Padding(4);
            this.btnFirstPage.Name = "btnFirstPage";
            this.btnFirstPage.OnDisabledState.BorderColor = System.Drawing.Color.Transparent;
            this.btnFirstPage.OnDisabledState.BorderRadius = 5;
            this.btnFirstPage.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnFirstPage.OnDisabledState.BorderThickness = 1;
            this.btnFirstPage.OnDisabledState.FillColor = System.Drawing.Color.Transparent;
            this.btnFirstPage.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnFirstPage.OnDisabledState.IconLeftImage = null;
            this.btnFirstPage.OnDisabledState.IconRightImage = null;
            this.btnFirstPage.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnFirstPage.onHoverState.BorderRadius = 5;
            this.btnFirstPage.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnFirstPage.onHoverState.BorderThickness = 1;
            this.btnFirstPage.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnFirstPage.onHoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnFirstPage.onHoverState.IconLeftImage = null;
            this.btnFirstPage.onHoverState.IconRightImage = null;
            this.btnFirstPage.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnFirstPage.OnIdleState.BorderRadius = 5;
            this.btnFirstPage.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnFirstPage.OnIdleState.BorderThickness = 1;
            this.btnFirstPage.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.btnFirstPage.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnFirstPage.OnIdleState.IconLeftImage = null;
            this.btnFirstPage.OnIdleState.IconRightImage = null;
            this.btnFirstPage.OnPressedState.BorderColor = System.Drawing.Color.Transparent;
            this.btnFirstPage.OnPressedState.BorderRadius = 5;
            this.btnFirstPage.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnFirstPage.OnPressedState.BorderThickness = 1;
            this.btnFirstPage.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnFirstPage.OnPressedState.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnFirstPage.OnPressedState.IconLeftImage = null;
            this.btnFirstPage.OnPressedState.IconRightImage = null;
            this.btnFirstPage.Size = new System.Drawing.Size(39, 41);
            this.btnFirstPage.TabIndex = 3;
            this.btnFirstPage.Tag = "1";
            this.btnFirstPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnFirstPage.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnFirstPage.TextMarginLeft = 0;
            this.btnFirstPage.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnFirstPage.UseDefaultRadiusAndThickness = true;
            // 
            // btnPrev
            // 
            this.btnPrev.AllowAnimations = true;
            this.btnPrev.AllowMouseEffects = true;
            this.btnPrev.AllowToggling = false;
            this.btnPrev.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnPrev.AnimationSpeed = 200;
            this.btnPrev.AutoGenerateColors = false;
            this.btnPrev.AutoRoundBorders = false;
            this.btnPrev.AutoSizeLeftIcon = true;
            this.btnPrev.AutoSizeRightIcon = true;
            this.btnPrev.BackColor = System.Drawing.Color.Transparent;
            this.btnPrev.BackColor1 = System.Drawing.Color.Transparent;
            this.btnPrev.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPrev.BackgroundImage")));
            this.btnPrev.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPrev.ButtonText = "";
            this.btnPrev.ButtonTextMarginLeft = 0;
            this.btnPrev.ColorContrastOnClick = 45;
            this.btnPrev.ColorContrastOnHover = 45;
            this.btnPrev.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges5.BottomLeft = true;
            borderEdges5.BottomRight = true;
            borderEdges5.TopLeft = true;
            borderEdges5.TopRight = true;
            this.btnPrev.CustomizableEdges = borderEdges5;
            this.btnPrev.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPrev.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnPrev.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnPrev.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnPrev.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnPrev.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPrev.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnPrev.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrev.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnPrev.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnPrev.IconMarginLeft = 11;
            this.btnPrev.IconPadding = 10;
            this.btnPrev.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrev.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnPrev.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnPrev.IconSize = 25;
            this.btnPrev.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btnPrev.IdleBorderRadius = 5;
            this.btnPrev.IdleBorderThickness = 1;
            this.btnPrev.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnPrev.IdleIconLeftImage = global::project_ManaTV.Properties.Resources.angle_left_solid;
            this.btnPrev.IdleIconRightImage = null;
            this.btnPrev.IndicateFocus = false;
            this.btnPrev.Location = new System.Drawing.Point(12, 4);
            this.btnPrev.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnPrev.OnDisabledState.BorderRadius = 5;
            this.btnPrev.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPrev.OnDisabledState.BorderThickness = 1;
            this.btnPrev.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnPrev.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnPrev.OnDisabledState.IconLeftImage = null;
            this.btnPrev.OnDisabledState.IconRightImage = null;
            this.btnPrev.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnPrev.onHoverState.BorderRadius = 5;
            this.btnPrev.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPrev.onHoverState.BorderThickness = 1;
            this.btnPrev.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnPrev.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnPrev.onHoverState.IconLeftImage = null;
            this.btnPrev.onHoverState.IconRightImage = null;
            this.btnPrev.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnPrev.OnIdleState.BorderRadius = 5;
            this.btnPrev.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPrev.OnIdleState.BorderThickness = 1;
            this.btnPrev.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.btnPrev.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnPrev.OnIdleState.IconLeftImage = global::project_ManaTV.Properties.Resources.angle_left_solid;
            this.btnPrev.OnIdleState.IconRightImage = null;
            this.btnPrev.OnPressedState.BorderColor = System.Drawing.Color.Transparent;
            this.btnPrev.OnPressedState.BorderRadius = 5;
            this.btnPrev.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPrev.OnPressedState.BorderThickness = 1;
            this.btnPrev.OnPressedState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnPrev.OnPressedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnPrev.OnPressedState.IconLeftImage = null;
            this.btnPrev.OnPressedState.IconRightImage = null;
            this.btnPrev.Size = new System.Drawing.Size(42, 41);
            this.btnPrev.TabIndex = 1;
            this.btnPrev.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPrev.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnPrev.TextMarginLeft = 0;
            this.btnPrev.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnPrev.UseDefaultRadiusAndThickness = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 36);
            this.label1.TabIndex = 18;
            this.label1.Text = "List Manufacturers";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.btnAddNew);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(8, 42);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(317, 49);
            this.flowLayoutPanel2.TabIndex = 17;
            // 
            // btnAddNew
            // 
            this.btnAddNew.AllowAnimations = true;
            this.btnAddNew.AllowMouseEffects = true;
            this.btnAddNew.AllowToggling = false;
            this.btnAddNew.AnimationSpeed = 200;
            this.btnAddNew.AutoGenerateColors = false;
            this.btnAddNew.AutoRoundBorders = false;
            this.btnAddNew.AutoSizeLeftIcon = false;
            this.btnAddNew.AutoSizeRightIcon = true;
            this.btnAddNew.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.btnAddNew.BackColor = System.Drawing.Color.Transparent;
            this.btnAddNew.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(164)))), ((int)(((byte)(77)))));
            this.btnAddNew.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddNew.BackgroundImage")));
            this.btnAddNew.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddNew.ButtonText = "Add new";
            this.btnAddNew.ButtonTextMarginLeft = 0;
            this.btnAddNew.ColorContrastOnClick = 45;
            this.btnAddNew.ColorContrastOnHover = 45;
            this.btnAddNew.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges6.BottomLeft = true;
            borderEdges6.BottomRight = true;
            borderEdges6.TopLeft = true;
            borderEdges6.TopRight = true;
            this.btnAddNew.CustomizableEdges = borderEdges6;
            this.btnAddNew.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddNew.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAddNew.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAddNew.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAddNew.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnAddNew.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddNew.ForeColor = System.Drawing.Color.White;
            this.btnAddNew.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNew.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnAddNew.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnAddNew.IconMarginLeft = 11;
            this.btnAddNew.IconPadding = 10;
            this.btnAddNew.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddNew.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnAddNew.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnAddNew.IconSize = 15;
            this.btnAddNew.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btnAddNew.IdleBorderRadius = 1;
            this.btnAddNew.IdleBorderThickness = 1;
            this.btnAddNew.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(164)))), ((int)(((byte)(77)))));
            this.btnAddNew.IdleIconLeftImage = global::project_ManaTV.Properties.Resources.plus_solid;
            this.btnAddNew.IdleIconRightImage = null;
            this.btnAddNew.IndicateFocus = false;
            this.btnAddNew.Location = new System.Drawing.Point(3, 2);
            this.btnAddNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAddNew.OnDisabledState.BorderRadius = 1;
            this.btnAddNew.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddNew.OnDisabledState.BorderThickness = 1;
            this.btnAddNew.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAddNew.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAddNew.OnDisabledState.IconLeftImage = null;
            this.btnAddNew.OnDisabledState.IconRightImage = null;
            this.btnAddNew.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnAddNew.onHoverState.BorderRadius = 1;
            this.btnAddNew.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddNew.onHoverState.BorderThickness = 1;
            this.btnAddNew.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnAddNew.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnAddNew.onHoverState.IconLeftImage = null;
            this.btnAddNew.onHoverState.IconRightImage = null;
            this.btnAddNew.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnAddNew.OnIdleState.BorderRadius = 1;
            this.btnAddNew.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddNew.OnIdleState.BorderThickness = 1;
            this.btnAddNew.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(164)))), ((int)(((byte)(77)))));
            this.btnAddNew.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnAddNew.OnIdleState.IconLeftImage = global::project_ManaTV.Properties.Resources.plus_solid;
            this.btnAddNew.OnIdleState.IconRightImage = null;
            this.btnAddNew.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnAddNew.OnPressedState.BorderRadius = 1;
            this.btnAddNew.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddNew.OnPressedState.BorderThickness = 1;
            this.btnAddNew.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnAddNew.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnAddNew.OnPressedState.IconLeftImage = null;
            this.btnAddNew.OnPressedState.IconRightImage = null;
            this.btnAddNew.Size = new System.Drawing.Size(115, 39);
            this.btnAddNew.TabIndex = 0;
            this.btnAddNew.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddNew.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddNew.TextMarginLeft = 0;
            this.btnAddNew.TextPadding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnAddNew.UseDefaultRadiusAndThickness = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // flowFilter
            // 
            this.flowFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowFilter.Controls.Add(this.btnSearch);
            this.flowFilter.Controls.Add(this.dpFilter);
            this.flowFilter.Controls.Add(this.txtSearch);
            this.flowFilter.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowFilter.Location = new System.Drawing.Point(691, 42);
            this.flowFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowFilter.Name = "flowFilter";
            this.flowFilter.Size = new System.Drawing.Size(501, 49);
            this.flowFilter.TabIndex = 16;
            // 
            // btnSearch
            // 
            this.btnSearch.AllowAnimations = true;
            this.btnSearch.AllowMouseEffects = true;
            this.btnSearch.AllowToggling = false;
            this.btnSearch.AnimationSpeed = 200;
            this.btnSearch.AutoGenerateColors = false;
            this.btnSearch.AutoRoundBorders = false;
            this.btnSearch.AutoSizeLeftIcon = true;
            this.btnSearch.AutoSizeRightIcon = true;
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(180)))), ((int)(((byte)(211)))));
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSearch.ButtonText = "Search";
            this.btnSearch.ButtonTextMarginLeft = 0;
            this.btnSearch.ColorContrastOnClick = 45;
            this.btnSearch.ColorContrastOnHover = 45;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges7.BottomLeft = true;
            borderEdges7.BottomRight = true;
            borderEdges7.TopLeft = true;
            borderEdges7.TopRight = true;
            this.btnSearch.CustomizableEdges = borderEdges7;
            this.btnSearch.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSearch.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSearch.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSearch.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSearch.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnSearch.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnSearch.IconMarginLeft = 11;
            this.btnSearch.IconPadding = 10;
            this.btnSearch.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnSearch.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnSearch.IconSize = 25;
            this.btnSearch.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btnSearch.IdleBorderRadius = 1;
            this.btnSearch.IdleBorderThickness = 1;
            this.btnSearch.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(180)))), ((int)(((byte)(211)))));
            this.btnSearch.IdleIconLeftImage = null;
            this.btnSearch.IdleIconRightImage = null;
            this.btnSearch.IndicateFocus = false;
            this.btnSearch.Location = new System.Drawing.Point(408, 2);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSearch.OnDisabledState.BorderRadius = 1;
            this.btnSearch.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSearch.OnDisabledState.BorderThickness = 1;
            this.btnSearch.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSearch.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSearch.OnDisabledState.IconLeftImage = null;
            this.btnSearch.OnDisabledState.IconRightImage = null;
            this.btnSearch.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnSearch.onHoverState.BorderRadius = 1;
            this.btnSearch.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSearch.onHoverState.BorderThickness = 1;
            this.btnSearch.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnSearch.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnSearch.onHoverState.IconLeftImage = null;
            this.btnSearch.onHoverState.IconRightImage = null;
            this.btnSearch.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnSearch.OnIdleState.BorderRadius = 1;
            this.btnSearch.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSearch.OnIdleState.BorderThickness = 1;
            this.btnSearch.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(180)))), ((int)(((byte)(211)))));
            this.btnSearch.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnSearch.OnIdleState.IconLeftImage = null;
            this.btnSearch.OnIdleState.IconRightImage = null;
            this.btnSearch.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnSearch.OnPressedState.BorderRadius = 1;
            this.btnSearch.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSearch.OnPressedState.BorderThickness = 1;
            this.btnSearch.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnSearch.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnSearch.OnPressedState.IconLeftImage = null;
            this.btnSearch.OnPressedState.IconRightImage = null;
            this.btnSearch.Size = new System.Drawing.Size(90, 38);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSearch.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSearch.TextMarginLeft = 0;
            this.btnSearch.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnSearch.UseDefaultRadiusAndThickness = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dpFilter
            // 
            this.dpFilter.BackColor = System.Drawing.Color.Transparent;
            this.dpFilter.BackgroundColor = System.Drawing.Color.White;
            this.dpFilter.BorderColor = System.Drawing.Color.Silver;
            this.dpFilter.BorderRadius = 1;
            this.dpFilter.Color = System.Drawing.Color.Silver;
            this.dpFilter.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.dpFilter.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dpFilter.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.dpFilter.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dpFilter.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.dpFilter.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.dpFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.dpFilter.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.dpFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dpFilter.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.dpFilter.FillDropDown = true;
            this.dpFilter.FillIndicator = false;
            this.dpFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dpFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dpFilter.ForeColor = System.Drawing.Color.Black;
            this.dpFilter.FormattingEnabled = true;
            this.dpFilter.Icon = null;
            this.dpFilter.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.dpFilter.IndicatorColor = System.Drawing.Color.Gray;
            this.dpFilter.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.dpFilter.ItemBackColor = System.Drawing.Color.White;
            this.dpFilter.ItemBorderColor = System.Drawing.Color.White;
            this.dpFilter.ItemForeColor = System.Drawing.Color.Black;
            this.dpFilter.ItemHeight = 25;
            this.dpFilter.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.dpFilter.ItemHighLightForeColor = System.Drawing.Color.White;
            this.dpFilter.Items.AddRange(new object[] {
            "Id",
            "Name"});
            this.dpFilter.ItemTopMargin = 3;
            this.dpFilter.Location = new System.Drawing.Point(277, 4);
            this.dpFilter.Margin = new System.Windows.Forms.Padding(4);
            this.dpFilter.Name = "dpFilter";
            this.dpFilter.Size = new System.Drawing.Size(124, 31);
            this.dpFilter.TabIndex = 8;
            this.dpFilter.Text = null;
            this.dpFilter.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.dpFilter.TextLeftMargin = 5;
            // 
            // txtSearch
            // 
            this.txtSearch.AcceptsReturn = false;
            this.txtSearch.AcceptsTab = false;
            this.txtSearch.AnimationSpeed = 200;
            this.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtSearch.BackColor = System.Drawing.Color.Transparent;
            this.txtSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtSearch.BackgroundImage")));
            this.txtSearch.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtSearch.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtSearch.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtSearch.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtSearch.BorderRadius = 1;
            this.txtSearch.BorderThickness = 1;
            this.txtSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtSearch.DefaultText = "";
            this.txtSearch.FillColor = System.Drawing.Color.White;
            this.txtSearch.HideSelection = true;
            this.txtSearch.IconLeft = null;
            this.txtSearch.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.IconPadding = 10;
            this.txtSearch.IconRight = null;
            this.txtSearch.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(30, 2);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtSearch.Modified = false;
            this.txtSearch.Multiline = false;
            this.txtSearch.Name = "txtSearch";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSearch.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtSearch.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSearch.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSearch.OnIdleState = stateProperties4;
            this.txtSearch.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtSearch.PlaceholderText = "Enter text";
            this.txtSearch.ReadOnly = false;
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(240, 38);
            this.txtSearch.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtSearch.TabIndex = 6;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSearch.TextMarginBottom = 0;
            this.txtSearch.TextMarginLeft = 3;
            this.txtSearch.TextMarginTop = 0;
            this.txtSearch.TextPlaceholder = "Enter text";
            this.txtSearch.UseSystemPasswordChar = false;
            this.txtSearch.WordWrap = true;
            // 
            // gridData
            // 
            this.gridData.AllowUserToAddRows = false;
            this.gridData.AllowUserToDeleteRows = false;
            this.gridData.AllowUserToOrderColumns = true;
            this.gridData.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridData.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.gridData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridData.ColumnHeadersHeight = 30;
            this.gridData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.colName,
            this.actionDetails,
            this.actionUpdate,
            this.actionDelete});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridData.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridData.EnableHeadersVisualStyles = false;
            this.gridData.Location = new System.Drawing.Point(8, 95);
            this.gridData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridData.Name = "gridData";
            this.gridData.ReadOnly = true;
            this.gridData.RowHeadersVisible = false;
            this.gridData.RowHeadersWidth = 51;
            this.gridData.RowTemplate.Height = 40;
            this.gridData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridData.Size = new System.Drawing.Size(1184, 438);
            this.gridData.TabIndex = 15;
            this.gridData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridData_CellClick);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ID.FillWeight = 244.6809F;
            this.ID.Frozen = true;
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ID.Width = 50;
            // 
            // colName
            // 
            this.colName.FillWeight = 63.82978F;
            this.colName.HeaderText = "Name";
            this.colName.MinimumWidth = 6;
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // actionDetails
            // 
            this.actionDetails.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.actionDetails.HeaderText = "";
            this.actionDetails.MinimumWidth = 6;
            this.actionDetails.Name = "actionDetails";
            this.actionDetails.ReadOnly = true;
            this.actionDetails.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.actionDetails.Width = 50;
            // 
            // actionUpdate
            // 
            this.actionUpdate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.actionUpdate.HeaderText = "Action";
            this.actionUpdate.MinimumWidth = 6;
            this.actionUpdate.Name = "actionUpdate";
            this.actionUpdate.ReadOnly = true;
            this.actionUpdate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.actionUpdate.Width = 50;
            // 
            // actionDelete
            // 
            this.actionDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.actionDelete.HeaderText = "";
            this.actionDelete.MinimumWidth = 6;
            this.actionDelete.Name = "actionDelete";
            this.actionDelete.ReadOnly = true;
            this.actionDelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.actionDelete.Width = 50;
            // 
            // FrmListBrands
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 595);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowFilter);
            this.Controls.Add(this.gridData);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmListBrands";
            this.Text = "ListBrands";
            this.Load += new System.EventHandler(this.ListBrands_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tvManagementDataSet1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowFilter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TVManagementDataSet tvManagementDataSet1;
        private Bunifu.UI.WinForms.BunifuSnackbar snackBarTab;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private Bunifu.UI.WinForms.BunifuDropdown dpPageSize;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnNext;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnThirdPage;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSecondPage;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnFirstPage;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnPrev;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAddNew;
        private System.Windows.Forms.FlowLayoutPanel flowFilter;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSearch;
        private Bunifu.UI.WinForms.BunifuDropdown dpFilter;
        private Bunifu.UI.WinForms.BunifuTextBox txtSearch;
        private System.Windows.Forms.DataGridView gridData;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewImageColumn actionDetails;
        private System.Windows.Forms.DataGridViewImageColumn actionUpdate;
        private System.Windows.Forms.DataGridViewImageColumn actionDelete;
    }
}