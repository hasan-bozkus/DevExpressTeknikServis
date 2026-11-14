namespace TeknikServis.Windows.Forms
{
    partial class FrmDepartment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDepartment));
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.GrdDepartments = new DevExpress.XtraGrid.GridControl();
            this.GrdViewItems = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.LblTotalDepartmentCount = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.LblTotalEmployeeCount = new DevExpress.XtraEditors.LabelControl();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TxtDepartmentId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.SmpBtnList = new DevExpress.XtraEditors.SimpleButton();
            this.SmpBtnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.SmpBtnRemove = new DevExpress.XtraEditors.SimpleButton();
            this.SmpBtnSave = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.TxtDepartmentName = new DevExpress.XtraEditors.TextEdit();
            this.GrpCtrlCurrentProcess = new DevExpress.XtraEditors.GroupControl();
            this.RchTxtDepartmentDescription = new System.Windows.Forms.RichTextBox();
            this.LblTextProductName = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.GrdDepartments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdViewItems)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDepartmentId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDepartmentName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrpCtrlCurrentProcess)).BeginInit();
            this.GrpCtrlCurrentProcess.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelControl15
            // 
            this.labelControl15.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelControl15.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl15.Appearance.Options.UseFont = true;
            this.labelControl15.Appearance.Options.UseForeColor = true;
            this.labelControl15.Location = new System.Drawing.Point(14, 21);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(215, 21);
            this.labelControl15.TabIndex = 0;
            this.labelControl15.Text = "En Az Çalışanı Olan Departman";
            // 
            // GrdDepartments
            // 
            this.GrdDepartments.Location = new System.Drawing.Point(3, 144);
            this.GrdDepartments.MainView = this.GrdViewItems;
            this.GrdDepartments.Name = "GrdDepartments";
            this.GrdDepartments.Size = new System.Drawing.Size(1020, 397);
            this.GrdDepartments.TabIndex = 30;
            this.GrdDepartments.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GrdViewItems});
            // 
            // GrdViewItems
            // 
            this.GrdViewItems.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(156)))), ((int)(((byte)(218)))));
            this.GrdViewItems.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(209)))), ((int)(((byte)(245)))));
            this.GrdViewItems.Appearance.Row.Options.UseBackColor = true;
            this.GrdViewItems.Appearance.Row.Options.UseBorderColor = true;
            this.GrdViewItems.GridControl = this.GrdDepartments;
            this.GrdViewItems.Name = "GrdViewItems";
            this.GrdViewItems.OptionsView.ShowGroupPanel = false;
            this.GrdViewItems.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.GrdViewItems_FocusedRowChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(21)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.labelControl10);
            this.panel1.Controls.Add(this.LblTotalDepartmentCount);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(251, 137);
            this.panel1.TabIndex = 32;
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelControl10.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Appearance.Options.UseForeColor = true;
            this.labelControl10.Location = new System.Drawing.Point(14, 21);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(178, 21);
            this.labelControl10.TabIndex = 0;
            this.labelControl10.Text = "Toplam Departman Sayısı";
            // 
            // LblTotalDepartmentCount
            // 
            this.LblTotalDepartmentCount.Appearance.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblTotalDepartmentCount.Appearance.ForeColor = System.Drawing.Color.White;
            this.LblTotalDepartmentCount.Appearance.Options.UseFont = true;
            this.LblTotalDepartmentCount.Appearance.Options.UseForeColor = true;
            this.LblTotalDepartmentCount.Location = new System.Drawing.Point(32, 48);
            this.LblTotalDepartmentCount.Name = "LblTotalDepartmentCount";
            this.LblTotalDepartmentCount.Size = new System.Drawing.Size(75, 59);
            this.LblTotalDepartmentCount.TabIndex = 0;
            this.LblTotalDepartmentCount.Text = "584";
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelControl11.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Appearance.Options.UseForeColor = true;
            this.labelControl11.Location = new System.Drawing.Point(14, 21);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(140, 21);
            this.labelControl11.TabIndex = 0;
            this.labelControl11.Text = "Aktif Personel Sayısı";
            // 
            // LblTotalEmployeeCount
            // 
            this.LblTotalEmployeeCount.Appearance.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblTotalEmployeeCount.Appearance.ForeColor = System.Drawing.Color.White;
            this.LblTotalEmployeeCount.Appearance.Options.UseFont = true;
            this.LblTotalEmployeeCount.Appearance.Options.UseForeColor = true;
            this.LblTotalEmployeeCount.Location = new System.Drawing.Point(32, 48);
            this.LblTotalEmployeeCount.Name = "LblTotalEmployeeCount";
            this.LblTotalEmployeeCount.Size = new System.Drawing.Size(75, 59);
            this.LblTotalEmployeeCount.TabIndex = 0;
            this.LblTotalEmployeeCount.Text = "584";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(185)))), ((int)(((byte)(59)))));
            this.panel3.Controls.Add(this.labelControl13);
            this.panel3.Controls.Add(this.labelControl14);
            this.panel3.Location = new System.Drawing.Point(515, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(251, 137);
            this.panel3.TabIndex = 33;
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelControl13.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl13.Appearance.Options.UseFont = true;
            this.labelControl13.Appearance.Options.UseForeColor = true;
            this.labelControl13.Location = new System.Drawing.Point(14, 21);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(233, 21);
            this.labelControl13.TabIndex = 0;
            this.labelControl13.Text = "En Fazla Çalışanı Olan Departman";
            // 
            // labelControl14
            // 
            this.labelControl14.Appearance.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl14.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl14.Appearance.Options.UseFont = true;
            this.labelControl14.Appearance.Options.UseForeColor = true;
            this.labelControl14.Location = new System.Drawing.Point(32, 48);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(75, 59);
            this.labelControl14.TabIndex = 0;
            this.labelControl14.Text = "584";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(153)))), ((int)(((byte)(146)))));
            this.panel4.Controls.Add(this.labelControl15);
            this.panel4.Controls.Add(this.labelControl16);
            this.panel4.Location = new System.Drawing.Point(772, 1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(251, 137);
            this.panel4.TabIndex = 34;
            // 
            // labelControl16
            // 
            this.labelControl16.Appearance.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl16.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl16.Appearance.Options.UseFont = true;
            this.labelControl16.Appearance.Options.UseForeColor = true;
            this.labelControl16.Location = new System.Drawing.Point(32, 48);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(75, 59);
            this.labelControl16.TabIndex = 0;
            this.labelControl16.Text = "584";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(80)))), ((int)(((byte)(57)))));
            this.panel2.Controls.Add(this.labelControl11);
            this.panel2.Controls.Add(this.LblTotalEmployeeCount);
            this.panel2.Location = new System.Drawing.Point(258, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(251, 137);
            this.panel2.TabIndex = 35;
            // 
            // TxtDepartmentId
            // 
            this.TxtDepartmentId.Enabled = false;
            this.TxtDepartmentId.Location = new System.Drawing.Point(99, 31);
            this.TxtDepartmentId.Name = "TxtDepartmentId";
            this.TxtDepartmentId.Size = new System.Drawing.Size(199, 22);
            this.TxtDepartmentId.TabIndex = 20;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(0, 34);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(97, 16);
            this.labelControl6.TabIndex = 19;
            this.labelControl6.Text = "DEPARTMAN ID: ";
            // 
            // SmpBtnList
            // 
            this.SmpBtnList.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("SmpBtnList.ImageOptions.Image")));
            this.SmpBtnList.Location = new System.Drawing.Point(99, 343);
            this.SmpBtnList.Name = "SmpBtnList";
            this.SmpBtnList.Size = new System.Drawing.Size(171, 32);
            this.SmpBtnList.TabIndex = 18;
            this.SmpBtnList.Text = "LİSTELE";
            this.SmpBtnList.Click += new System.EventHandler(this.SmpBtnList_Click);
            // 
            // SmpBtnUpdate
            // 
            this.SmpBtnUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("SmpBtnUpdate.ImageOptions.Image")));
            this.SmpBtnUpdate.Location = new System.Drawing.Point(99, 305);
            this.SmpBtnUpdate.Name = "SmpBtnUpdate";
            this.SmpBtnUpdate.Size = new System.Drawing.Size(171, 32);
            this.SmpBtnUpdate.TabIndex = 17;
            this.SmpBtnUpdate.Text = "GÜNCELLE";
            this.SmpBtnUpdate.Click += new System.EventHandler(this.SmpBtnUpdate_Click);
            // 
            // SmpBtnRemove
            // 
            this.SmpBtnRemove.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("SmpBtnRemove.ImageOptions.Image")));
            this.SmpBtnRemove.Location = new System.Drawing.Point(99, 267);
            this.SmpBtnRemove.Name = "SmpBtnRemove";
            this.SmpBtnRemove.Size = new System.Drawing.Size(171, 32);
            this.SmpBtnRemove.TabIndex = 16;
            this.SmpBtnRemove.Text = "SİL";
            this.SmpBtnRemove.Click += new System.EventHandler(this.SmpBtnRemove_Click);
            // 
            // SmpBtnSave
            // 
            this.SmpBtnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("SmpBtnSave.ImageOptions.Image")));
            this.SmpBtnSave.Location = new System.Drawing.Point(99, 229);
            this.SmpBtnSave.Name = "SmpBtnSave";
            this.SmpBtnSave.Size = new System.Drawing.Size(171, 32);
            this.SmpBtnSave.TabIndex = 15;
            this.SmpBtnSave.Text = "KAYDET";
            this.SmpBtnSave.Click += new System.EventHandler(this.SmpBtnSave_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(33, 90);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(68, 16);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "AÇIKLAMA: ";
            // 
            // TxtDepartmentName
            // 
            this.TxtDepartmentName.Location = new System.Drawing.Point(99, 59);
            this.TxtDepartmentName.Name = "TxtDepartmentName";
            this.TxtDepartmentName.Size = new System.Drawing.Size(199, 22);
            this.TxtDepartmentName.TabIndex = 4;
            // 
            // GrpCtrlCurrentProcess
            // 
            this.GrpCtrlCurrentProcess.Controls.Add(this.RchTxtDepartmentDescription);
            this.GrpCtrlCurrentProcess.Controls.Add(this.TxtDepartmentId);
            this.GrpCtrlCurrentProcess.Controls.Add(this.labelControl6);
            this.GrpCtrlCurrentProcess.Controls.Add(this.SmpBtnList);
            this.GrpCtrlCurrentProcess.Controls.Add(this.SmpBtnUpdate);
            this.GrpCtrlCurrentProcess.Controls.Add(this.SmpBtnRemove);
            this.GrpCtrlCurrentProcess.Controls.Add(this.SmpBtnSave);
            this.GrpCtrlCurrentProcess.Controls.Add(this.labelControl1);
            this.GrpCtrlCurrentProcess.Controls.Add(this.TxtDepartmentName);
            this.GrpCtrlCurrentProcess.Controls.Add(this.LblTextProductName);
            this.GrpCtrlCurrentProcess.Location = new System.Drawing.Point(1029, -9);
            this.GrpCtrlCurrentProcess.Name = "GrpCtrlCurrentProcess";
            this.GrpCtrlCurrentProcess.Size = new System.Drawing.Size(338, 537);
            this.GrpCtrlCurrentProcess.TabIndex = 31;
            this.GrpCtrlCurrentProcess.Text = "DEPARTMAN İŞLEMLERİ";
            // 
            // RchTxtDepartmentDescription
            // 
            this.RchTxtDepartmentDescription.Location = new System.Drawing.Point(99, 90);
            this.RchTxtDepartmentDescription.Name = "RchTxtDepartmentDescription";
            this.RchTxtDepartmentDescription.Size = new System.Drawing.Size(199, 104);
            this.RchTxtDepartmentDescription.TabIndex = 21;
            this.RchTxtDepartmentDescription.Text = "";
            // 
            // LblTextProductName
            // 
            this.LblTextProductName.Location = new System.Drawing.Point(72, 62);
            this.LblTextProductName.Name = "LblTextProductName";
            this.LblTextProductName.Size = new System.Drawing.Size(25, 16);
            this.LblTextProductName.TabIndex = 3;
            this.LblTextProductName.Text = "AD: ";
            // 
            // FrmDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1368, 533);
            this.Controls.Add(this.GrdDepartments);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.GrpCtrlCurrentProcess);
            this.Name = "FrmDepartment";
            this.Text = "Departman";
            this.Load += new System.EventHandler(this.FrmDepartment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdDepartments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdViewItems)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDepartmentId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDepartmentName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrpCtrlCurrentProcess)).EndInit();
            this.GrpCtrlCurrentProcess.ResumeLayout(false);
            this.GrpCtrlCurrentProcess.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraGrid.GridControl GrdDepartments;
        private DevExpress.XtraGrid.Views.Grid.GridView GrdViewItems;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl LblTotalDepartmentCount;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl LblTotalEmployeeCount;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraEditors.LabelControl labelControl16;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.TextEdit TxtDepartmentId;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SimpleButton SmpBtnList;
        private DevExpress.XtraEditors.SimpleButton SmpBtnUpdate;
        private DevExpress.XtraEditors.SimpleButton SmpBtnRemove;
        private DevExpress.XtraEditors.SimpleButton SmpBtnSave;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit TxtDepartmentName;
        private DevExpress.XtraEditors.GroupControl GrpCtrlCurrentProcess;
        private DevExpress.XtraEditors.LabelControl LblTextProductName;
        private System.Windows.Forms.RichTextBox RchTxtDepartmentDescription;
    }
}