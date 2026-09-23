namespace TeknikServis.Windows.Forms
{
    partial class FrmBrand
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBrand));
            DevExpress.XtraCharts.Series series3 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PieSeriesView pieSeriesView2 = new DevExpress.XtraCharts.PieSeriesView();
            DevExpress.XtraCharts.XYDiagram xyDiagram2 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series4 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.StackedBarSeriesView stackedBarSeriesView3 = new DevExpress.XtraCharts.StackedBarSeriesView();
            DevExpress.XtraCharts.StackedBarSeriesView stackedBarSeriesView4 = new DevExpress.XtraCharts.StackedBarSeriesView();
            this.GrdBrands = new DevExpress.XtraGrid.GridControl();
            this.GrdViewItems = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.LblTotalProductCount = new DevExpress.XtraEditors.LabelControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.LblTotalBrandCount = new DevExpress.XtraEditors.LabelControl();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.LblMaxProductCountByBrand = new DevExpress.XtraEditors.LabelControl();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.LblMaxPricedBrand = new DevExpress.XtraEditors.LabelControl();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.ChartBrandAndValue = new DevExpress.XtraCharts.ChartControl();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.ChartProductAndValue = new DevExpress.XtraCharts.ChartControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.pictureEdit7 = new DevExpress.XtraEditors.PictureEdit();
            this.panel8 = new System.Windows.Forms.Panel();
            this.pictureEdit3 = new DevExpress.XtraEditors.PictureEdit();
            this.panel9 = new System.Windows.Forms.Panel();
            this.pictureEdit4 = new DevExpress.XtraEditors.PictureEdit();
            this.panel10 = new System.Windows.Forms.Panel();
            this.pictureEdit5 = new DevExpress.XtraEditors.PictureEdit();
            this.panel11 = new System.Windows.Forms.Panel();
            this.pictureEdit6 = new DevExpress.XtraEditors.PictureEdit();
            this.panel13 = new System.Windows.Forms.Panel();
            this.pictureEdit8 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdBrands)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdViewItems)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartBrandAndValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView2)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartProductAndValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(stackedBarSeriesView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(stackedBarSeriesView4)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit7.Properties)).BeginInit();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).BeginInit();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit4.Properties)).BeginInit();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit5.Properties)).BeginInit();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit6.Properties)).BeginInit();
            this.panel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit8.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // GrdBrands
            // 
            this.GrdBrands.Location = new System.Drawing.Point(2, -9);
            this.GrdBrands.MainView = this.GrdViewItems;
            this.GrdBrands.Name = "GrdBrands";
            this.GrdBrands.Size = new System.Drawing.Size(541, 550);
            this.GrdBrands.TabIndex = 2;
            this.GrdBrands.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GrdViewItems});
            // 
            // GrdViewItems
            // 
            this.GrdViewItems.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(156)))), ((int)(((byte)(218)))));
            this.GrdViewItems.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(209)))), ((int)(((byte)(245)))));
            this.GrdViewItems.Appearance.Row.Options.UseBackColor = true;
            this.GrdViewItems.Appearance.Row.Options.UseBorderColor = true;
            this.GrdViewItems.GridControl = this.GrdBrands;
            this.GrdViewItems.Name = "GrdViewItems";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Controls.Add(this.LblTotalProductCount);
            this.panel1.Location = new System.Drawing.Point(549, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(202, 137);
            this.panel1.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(14, 21);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(135, 21);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Toplam Ürün Sayısı";
            // 
            // LblTotalProductCount
            // 
            this.LblTotalProductCount.Appearance.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblTotalProductCount.Appearance.ForeColor = System.Drawing.Color.White;
            this.LblTotalProductCount.Appearance.Options.UseFont = true;
            this.LblTotalProductCount.Appearance.Options.UseForeColor = true;
            this.LblTotalProductCount.Location = new System.Drawing.Point(32, 48);
            this.LblTotalProductCount.Name = "LblTotalProductCount";
            this.LblTotalProductCount.Size = new System.Drawing.Size(75, 59);
            this.LblTotalProductCount.TabIndex = 0;
            this.LblTotalProductCount.Text = "584";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(26)))));
            this.panel2.Controls.Add(this.labelControl2);
            this.panel2.Controls.Add(this.LblTotalBrandCount);
            this.panel2.Location = new System.Drawing.Point(966, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(202, 137);
            this.panel2.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(14, 21);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(144, 21);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Toplam Marka Sayısı";
            // 
            // LblTotalBrandCount
            // 
            this.LblTotalBrandCount.Appearance.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblTotalBrandCount.Appearance.ForeColor = System.Drawing.Color.White;
            this.LblTotalBrandCount.Appearance.Options.UseFont = true;
            this.LblTotalBrandCount.Appearance.Options.UseForeColor = true;
            this.LblTotalBrandCount.Location = new System.Drawing.Point(32, 48);
            this.LblTotalBrandCount.Name = "LblTotalBrandCount";
            this.LblTotalBrandCount.Size = new System.Drawing.Size(75, 59);
            this.LblTotalBrandCount.TabIndex = 0;
            this.LblTotalBrandCount.Text = "584";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(163)))), ((int)(((byte)(188)))));
            this.panel3.Controls.Add(this.labelControl4);
            this.panel3.Controls.Add(this.LblMaxProductCountByBrand);
            this.panel3.Location = new System.Drawing.Point(758, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(202, 137);
            this.panel3.TabIndex = 3;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(14, 21);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(156, 21);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "En Fazla Ürünlü Marka";
            // 
            // LblMaxProductCountByBrand
            // 
            this.LblMaxProductCountByBrand.Appearance.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.LblMaxProductCountByBrand.Appearance.ForeColor = System.Drawing.Color.White;
            this.LblMaxProductCountByBrand.Appearance.Options.UseFont = true;
            this.LblMaxProductCountByBrand.Appearance.Options.UseForeColor = true;
            this.LblMaxProductCountByBrand.Location = new System.Drawing.Point(30, 59);
            this.LblMaxProductCountByBrand.Name = "LblMaxProductCountByBrand";
            this.LblMaxProductCountByBrand.Size = new System.Drawing.Size(57, 45);
            this.LblMaxProductCountByBrand.TabIndex = 0;
            this.LblMaxProductCountByBrand.Text = "584";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.panel4.Controls.Add(this.labelControl6);
            this.panel4.Controls.Add(this.LblMaxPricedBrand);
            this.panel4.Location = new System.Drawing.Point(1172, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(214, 137);
            this.panel4.TabIndex = 3;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Appearance.Options.UseForeColor = true;
            this.labelControl6.Location = new System.Drawing.Point(14, 21);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(163, 21);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "En Yüksek Fiyatlı Marka";
            // 
            // LblMaxPricedBrand
            // 
            this.LblMaxPricedBrand.Appearance.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.LblMaxPricedBrand.Appearance.ForeColor = System.Drawing.Color.White;
            this.LblMaxPricedBrand.Appearance.Options.UseFont = true;
            this.LblMaxPricedBrand.Appearance.Options.UseForeColor = true;
            this.LblMaxPricedBrand.Location = new System.Drawing.Point(29, 59);
            this.LblMaxPricedBrand.Name = "LblMaxPricedBrand";
            this.LblMaxPricedBrand.Size = new System.Drawing.Size(57, 45);
            this.LblMaxPricedBrand.TabIndex = 0;
            this.LblMaxPricedBrand.Text = "584";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.pictureEdit1);
            this.panel5.Controls.Add(this.labelControl5);
            this.panel5.Controls.Add(this.labelControl3);
            this.panel5.Controls.Add(this.ChartBrandAndValue);
            this.panel5.Location = new System.Drawing.Point(549, 145);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(432, 392);
            this.panel5.TabIndex = 4;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(32, 3);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Size = new System.Drawing.Size(60, 50);
            this.pictureEdit1.TabIndex = 2;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(98, 16);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(207, 28);
            this.labelControl5.TabIndex = 1;
            this.labelControl5.Text = "Marka ve İstatistikleri";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(15, 59);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(387, 34);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Projemizin bu bölümünde markalar ve bu markalara ait istatistik \r\ndeğerlerine gra" +
    "fik alanı üzerinden güçlü bir arayüzle ulaşabilirsiniz.";
            // 
            // ChartBrandAndValue
            // 
            this.ChartBrandAndValue.IndicatorsPaletteName = "Office 2013";
            this.ChartBrandAndValue.Location = new System.Drawing.Point(12, 99);
            this.ChartBrandAndValue.Name = "ChartBrandAndValue";
            this.ChartBrandAndValue.PaletteName = "Pastel Kit";
            series3.LegendTextPattern = "(A)";
            series3.Name = "Series 1";
            series3.SeriesID = 0;
            series3.View = pieSeriesView2;
            this.ChartBrandAndValue.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series3};
            this.ChartBrandAndValue.Size = new System.Drawing.Size(415, 288);
            this.ChartBrandAndValue.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.pictureEdit2);
            this.panel6.Controls.Add(this.labelControl8);
            this.panel6.Controls.Add(this.ChartProductAndValue);
            this.panel6.Controls.Add(this.labelControl7);
            this.panel6.Location = new System.Drawing.Point(987, 145);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(407, 306);
            this.panel6.TabIndex = 4;
            // 
            // pictureEdit2
            // 
            this.pictureEdit2.EditValue = ((object)(resources.GetObject("pictureEdit2.EditValue")));
            this.pictureEdit2.Location = new System.Drawing.Point(21, 12);
            this.pictureEdit2.Name = "pictureEdit2";
            this.pictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit2.Size = new System.Drawing.Size(60, 41);
            this.pictureEdit2.TabIndex = 2;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(87, 16);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(211, 28);
            this.labelControl8.TabIndex = 1;
            this.labelControl8.Text = "Ürünler ve Kategoriler";
            // 
            // ChartProductAndValue
            // 
            xyDiagram2.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram2.AxisY.VisibleInPanesSerializable = "-1";
            this.ChartProductAndValue.Diagram = xyDiagram2;
            this.ChartProductAndValue.IndicatorsPaletteName = "Office 2013";
            this.ChartProductAndValue.Location = new System.Drawing.Point(9, 99);
            this.ChartProductAndValue.Name = "ChartProductAndValue";
            this.ChartProductAndValue.PaletteName = "Pastel Kit";
            series4.Name = "Kategoriler";
            series4.SeriesID = 0;
            series4.View = stackedBarSeriesView3;
            this.ChartProductAndValue.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series4};
            this.ChartProductAndValue.SeriesTemplate.View = stackedBarSeriesView4;
            this.ChartProductAndValue.Size = new System.Drawing.Size(390, 204);
            this.ChartProductAndValue.TabIndex = 0;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(4, 59);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(346, 34);
            this.labelControl7.TabIndex = 1;
            this.labelControl7.Text = "Sistemimize ürün giriş ve ürün takibi hem masaüstü hem de \r\nkargo noktasında hem " +
    "de web tarafından yapılabilmektedir. ";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.panel13);
            this.panel7.Controls.Add(this.panel11);
            this.panel7.Controls.Add(this.panel10);
            this.panel7.Controls.Add(this.panel9);
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Controls.Add(this.panel12);
            this.panel7.Location = new System.Drawing.Point(987, 457);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(407, 79);
            this.panel7.TabIndex = 4;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(203)))), ((int)(((byte)(196)))));
            this.panel12.Controls.Add(this.pictureEdit7);
            this.panel12.Location = new System.Drawing.Point(0, 3);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(75, 72);
            this.panel12.TabIndex = 0;
            // 
            // pictureEdit7
            // 
            this.pictureEdit7.EditValue = ((object)(resources.GetObject("pictureEdit7.EditValue")));
            this.pictureEdit7.Location = new System.Drawing.Point(15, 12);
            this.pictureEdit7.Name = "pictureEdit7";
            this.pictureEdit7.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit7.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit7.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit7.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit7.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit7.Size = new System.Drawing.Size(48, 48);
            this.pictureEdit7.TabIndex = 0;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(203)))), ((int)(((byte)(196)))));
            this.panel8.Controls.Add(this.pictureEdit3);
            this.panel8.Location = new System.Drawing.Point(0, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(75, 72);
            this.panel8.TabIndex = 0;
            // 
            // pictureEdit3
            // 
            this.pictureEdit3.EditValue = ((object)(resources.GetObject("pictureEdit3.EditValue")));
            this.pictureEdit3.Location = new System.Drawing.Point(11, 13);
            this.pictureEdit3.Name = "pictureEdit3";
            this.pictureEdit3.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit3.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit3.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit3.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit3.Size = new System.Drawing.Size(48, 48);
            this.pictureEdit3.TabIndex = 0;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(76)))), ((int)(((byte)(103)))));
            this.panel9.Controls.Add(this.pictureEdit4);
            this.panel9.Location = new System.Drawing.Point(81, 3);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(75, 72);
            this.panel9.TabIndex = 0;
            // 
            // pictureEdit4
            // 
            this.pictureEdit4.EditValue = ((object)(resources.GetObject("pictureEdit4.EditValue")));
            this.pictureEdit4.Location = new System.Drawing.Point(15, 12);
            this.pictureEdit4.Name = "pictureEdit4";
            this.pictureEdit4.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit4.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit4.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit4.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit4.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit4.Size = new System.Drawing.Size(48, 48);
            this.pictureEdit4.TabIndex = 0;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(50)))));
            this.panel10.Controls.Add(this.pictureEdit5);
            this.panel10.Location = new System.Drawing.Point(162, 3);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(75, 72);
            this.panel10.TabIndex = 0;
            // 
            // pictureEdit5
            // 
            this.pictureEdit5.EditValue = ((object)(resources.GetObject("pictureEdit5.EditValue")));
            this.pictureEdit5.Location = new System.Drawing.Point(15, 12);
            this.pictureEdit5.Name = "pictureEdit5";
            this.pictureEdit5.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit5.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit5.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit5.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit5.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit5.Size = new System.Drawing.Size(48, 48);
            this.pictureEdit5.TabIndex = 0;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(90)))), ((int)(((byte)(36)))));
            this.panel11.Controls.Add(this.pictureEdit6);
            this.panel11.Location = new System.Drawing.Point(243, 4);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(75, 72);
            this.panel11.TabIndex = 0;
            // 
            // pictureEdit6
            // 
            this.pictureEdit6.EditValue = ((object)(resources.GetObject("pictureEdit6.EditValue")));
            this.pictureEdit6.Location = new System.Drawing.Point(15, 12);
            this.pictureEdit6.Name = "pictureEdit6";
            this.pictureEdit6.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit6.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit6.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit6.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit6.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit6.Size = new System.Drawing.Size(48, 48);
            this.pictureEdit6.TabIndex = 0;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(18)))));
            this.panel13.Controls.Add(this.pictureEdit8);
            this.panel13.Location = new System.Drawing.Point(324, 4);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(75, 72);
            this.panel13.TabIndex = 0;
            // 
            // pictureEdit8
            // 
            this.pictureEdit8.EditValue = ((object)(resources.GetObject("pictureEdit8.EditValue")));
            this.pictureEdit8.Location = new System.Drawing.Point(15, 12);
            this.pictureEdit8.Name = "pictureEdit8";
            this.pictureEdit8.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit8.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit8.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit8.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit8.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit8.Size = new System.Drawing.Size(48, 48);
            this.pictureEdit8.TabIndex = 0;
            // 
            // FrmBrand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1391, 544);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.GrdBrands);
            this.Name = "FrmBrand";
            this.Text = "FrmBrand";
            this.Load += new System.EventHandler(this.FrmBrand_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdBrands)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdViewItems)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartBrandAndValue)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(stackedBarSeriesView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(stackedBarSeriesView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartProductAndValue)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit7.Properties)).EndInit();
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).EndInit();
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit4.Properties)).EndInit();
            this.panel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit5.Properties)).EndInit();
            this.panel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit6.Properties)).EndInit();
            this.panel13.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit8.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridControl GrdBrands;
        private DevExpress.XtraGrid.Views.Grid.GridView GrdViewItems;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl LblTotalProductCount;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl LblTotalBrandCount;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl LblMaxProductCountByBrand;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl LblMaxPricedBrand;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraCharts.ChartControl ChartBrandAndValue;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraCharts.ChartControl ChartProductAndValue;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private System.Windows.Forms.Panel panel12;
        private DevExpress.XtraEditors.PictureEdit pictureEdit7;
        private System.Windows.Forms.Panel panel13;
        private DevExpress.XtraEditors.PictureEdit pictureEdit8;
        private System.Windows.Forms.Panel panel11;
        private DevExpress.XtraEditors.PictureEdit pictureEdit6;
        private System.Windows.Forms.Panel panel10;
        private DevExpress.XtraEditors.PictureEdit pictureEdit5;
        private System.Windows.Forms.Panel panel9;
        private DevExpress.XtraEditors.PictureEdit pictureEdit4;
        private System.Windows.Forms.Panel panel8;
        private DevExpress.XtraEditors.PictureEdit pictureEdit3;
    }
}