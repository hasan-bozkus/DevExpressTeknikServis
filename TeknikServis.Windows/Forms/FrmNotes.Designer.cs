namespace TeknikServis.Windows.Forms
{
    partial class FrmNotes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNotes));
            this.TxtNoteId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.SmpBtnList = new DevExpress.XtraEditors.SimpleButton();
            this.SmpBtnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.SmpBtnRemove = new DevExpress.XtraEditors.SimpleButton();
            this.SmpBtnSave = new DevExpress.XtraEditors.SimpleButton();
            this.TxtNoteContent = new DevExpress.XtraEditors.TextEdit();
            this.labelControl33 = new DevExpress.XtraEditors.LabelControl();
            this.TxtNoteTitle = new DevExpress.XtraEditors.TextEdit();
            this.GrpCtrlCurrentProcess = new DevExpress.XtraEditors.GroupControl();
            this.CheckMarkAsRead = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl34 = new DevExpress.XtraEditors.LabelControl();
            this.LblTextProductName = new DevExpress.XtraEditors.LabelControl();
            this.GrdViewItems = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GrdUnreadNotes = new DevExpress.XtraGrid.GridControl();
            this.label1 = new System.Windows.Forms.Label();
            this.GrdReadNotes = new DevExpress.XtraGrid.GridControl();
            this.GrdViewItemsRead = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNoteId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNoteContent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNoteTitle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrpCtrlCurrentProcess)).BeginInit();
            this.GrpCtrlCurrentProcess.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CheckMarkAsRead.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdViewItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdUnreadNotes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdReadNotes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdViewItemsRead)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtNoteId
            // 
            this.TxtNoteId.Enabled = false;
            this.TxtNoteId.Location = new System.Drawing.Point(90, 53);
            this.TxtNoteId.Name = "TxtNoteId";
            this.TxtNoteId.Size = new System.Drawing.Size(199, 22);
            this.TxtNoteId.TabIndex = 20;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(43, 56);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(50, 16);
            this.labelControl6.TabIndex = 19;
            this.labelControl6.Text = "NOT ID: ";
            // 
            // SmpBtnList
            // 
            this.SmpBtnList.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("SmpBtnList.ImageOptions.Image")));
            this.SmpBtnList.Location = new System.Drawing.Point(99, 297);
            this.SmpBtnList.Name = "SmpBtnList";
            this.SmpBtnList.Size = new System.Drawing.Size(175, 35);
            this.SmpBtnList.TabIndex = 18;
            this.SmpBtnList.Text = "LİSTELE";
            this.SmpBtnList.Click += new System.EventHandler(this.SmpBtnList_Click);
            // 
            // SmpBtnUpdate
            // 
            this.SmpBtnUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("SmpBtnUpdate.ImageOptions.Image")));
            this.SmpBtnUpdate.Location = new System.Drawing.Point(99, 259);
            this.SmpBtnUpdate.Name = "SmpBtnUpdate";
            this.SmpBtnUpdate.Size = new System.Drawing.Size(175, 35);
            this.SmpBtnUpdate.TabIndex = 17;
            this.SmpBtnUpdate.Text = "GÜNCELLE";
            this.SmpBtnUpdate.Click += new System.EventHandler(this.SmpBtnUpdate_Click);
            // 
            // SmpBtnRemove
            // 
            this.SmpBtnRemove.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("SmpBtnRemove.ImageOptions.Image")));
            this.SmpBtnRemove.Location = new System.Drawing.Point(99, 221);
            this.SmpBtnRemove.Name = "SmpBtnRemove";
            this.SmpBtnRemove.Size = new System.Drawing.Size(175, 35);
            this.SmpBtnRemove.TabIndex = 16;
            this.SmpBtnRemove.Text = "SİL";
            // 
            // SmpBtnSave
            // 
            this.SmpBtnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("SmpBtnSave.ImageOptions.Image")));
            this.SmpBtnSave.Location = new System.Drawing.Point(99, 183);
            this.SmpBtnSave.Name = "SmpBtnSave";
            this.SmpBtnSave.Size = new System.Drawing.Size(175, 35);
            this.SmpBtnSave.TabIndex = 15;
            this.SmpBtnSave.Text = "KAYDET";
            this.SmpBtnSave.Click += new System.EventHandler(this.SmpBtnSave_Click);
            // 
            // TxtNoteContent
            // 
            this.TxtNoteContent.Location = new System.Drawing.Point(90, 109);
            this.TxtNoteContent.Name = "TxtNoteContent";
            this.TxtNoteContent.Size = new System.Drawing.Size(199, 22);
            this.TxtNoteContent.TabIndex = 4;
            // 
            // labelControl33
            // 
            this.labelControl33.Location = new System.Drawing.Point(46, 112);
            this.labelControl33.Name = "labelControl33";
            this.labelControl33.Size = new System.Drawing.Size(47, 16);
            this.labelControl33.TabIndex = 3;
            this.labelControl33.Text = "İÇERİK: ";
            // 
            // TxtNoteTitle
            // 
            this.TxtNoteTitle.Location = new System.Drawing.Point(90, 81);
            this.TxtNoteTitle.Name = "TxtNoteTitle";
            this.TxtNoteTitle.Size = new System.Drawing.Size(199, 22);
            this.TxtNoteTitle.TabIndex = 4;
            // 
            // GrpCtrlCurrentProcess
            // 
            this.GrpCtrlCurrentProcess.Controls.Add(this.CheckMarkAsRead);
            this.GrpCtrlCurrentProcess.Controls.Add(this.TxtNoteId);
            this.GrpCtrlCurrentProcess.Controls.Add(this.labelControl6);
            this.GrpCtrlCurrentProcess.Controls.Add(this.SmpBtnList);
            this.GrpCtrlCurrentProcess.Controls.Add(this.SmpBtnUpdate);
            this.GrpCtrlCurrentProcess.Controls.Add(this.SmpBtnRemove);
            this.GrpCtrlCurrentProcess.Controls.Add(this.SmpBtnSave);
            this.GrpCtrlCurrentProcess.Controls.Add(this.labelControl34);
            this.GrpCtrlCurrentProcess.Controls.Add(this.TxtNoteContent);
            this.GrpCtrlCurrentProcess.Controls.Add(this.labelControl33);
            this.GrpCtrlCurrentProcess.Controls.Add(this.TxtNoteTitle);
            this.GrpCtrlCurrentProcess.Controls.Add(this.LblTextProductName);
            this.GrpCtrlCurrentProcess.Location = new System.Drawing.Point(986, 5);
            this.GrpCtrlCurrentProcess.Name = "GrpCtrlCurrentProcess";
            this.GrpCtrlCurrentProcess.Size = new System.Drawing.Size(376, 551);
            this.GrpCtrlCurrentProcess.TabIndex = 50;
            this.GrpCtrlCurrentProcess.Text = "AJANDA İŞLEMLERİ";
            // 
            // CheckMarkAsRead
            // 
            this.CheckMarkAsRead.Location = new System.Drawing.Point(90, 137);
            this.CheckMarkAsRead.Name = "CheckMarkAsRead";
            this.CheckMarkAsRead.Properties.Caption = "Okundu Olarak İşaretle";
            this.CheckMarkAsRead.Size = new System.Drawing.Size(168, 24);
            this.CheckMarkAsRead.TabIndex = 21;
            // 
            // labelControl34
            // 
            this.labelControl34.Location = new System.Drawing.Point(42, 140);
            this.labelControl34.Name = "labelControl34";
            this.labelControl34.Size = new System.Drawing.Size(51, 16);
            this.labelControl34.TabIndex = 3;
            this.labelControl34.Text = "DURUM: ";
            // 
            // LblTextProductName
            // 
            this.LblTextProductName.Location = new System.Drawing.Point(44, 84);
            this.LblTextProductName.Name = "LblTextProductName";
            this.LblTextProductName.Size = new System.Drawing.Size(49, 16);
            this.LblTextProductName.TabIndex = 3;
            this.LblTextProductName.Text = "BAŞLIK: ";
            // 
            // GrdViewItems
            // 
            this.GrdViewItems.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(156)))), ((int)(((byte)(218)))));
            this.GrdViewItems.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(209)))), ((int)(((byte)(245)))));
            this.GrdViewItems.Appearance.Row.Options.UseBackColor = true;
            this.GrdViewItems.Appearance.Row.Options.UseBorderColor = true;
            this.GrdViewItems.GridControl = this.GrdUnreadNotes;
            this.GrdViewItems.Name = "GrdViewItems";
            this.GrdViewItems.OptionsView.ShowGroupPanel = false;
            this.GrdViewItems.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.GrdViewItems_FocusedRowChanged);
            // 
            // GrdUnreadNotes
            // 
            this.GrdUnreadNotes.Location = new System.Drawing.Point(2, 31);
            this.GrdUnreadNotes.MainView = this.GrdViewItems;
            this.GrdUnreadNotes.Name = "GrdUnreadNotes";
            this.GrdUnreadNotes.Size = new System.Drawing.Size(978, 248);
            this.GrdUnreadNotes.TabIndex = 49;
            this.GrdUnreadNotes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GrdViewItems});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 23);
            this.label1.TabIndex = 51;
            this.label1.Text = "Okunmayan Notlar";
            // 
            // GrdReadNotes
            // 
            this.GrdReadNotes.Location = new System.Drawing.Point(2, 308);
            this.GrdReadNotes.MainView = this.GrdViewItemsRead;
            this.GrdReadNotes.Name = "GrdReadNotes";
            this.GrdReadNotes.Size = new System.Drawing.Size(978, 248);
            this.GrdReadNotes.TabIndex = 49;
            this.GrdReadNotes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GrdViewItemsRead});
            // 
            // GrdViewItemsRead
            // 
            this.GrdViewItemsRead.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(185)))), ((int)(((byte)(139)))));
            this.GrdViewItemsRead.Appearance.Row.BorderColor = System.Drawing.Color.White;
            this.GrdViewItemsRead.Appearance.Row.Options.UseBackColor = true;
            this.GrdViewItemsRead.Appearance.Row.Options.UseBorderColor = true;
            this.GrdViewItemsRead.AppearancePrint.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(226)))), ((int)(((byte)(114)))));
            this.GrdViewItemsRead.AppearancePrint.Row.Options.UseBackColor = true;
            this.GrdViewItemsRead.GridControl = this.GrdReadNotes;
            this.GrdViewItemsRead.Name = "GrdViewItemsRead";
            this.GrdViewItemsRead.OptionsView.ShowGroupPanel = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(5, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 23);
            this.label2.TabIndex = 51;
            this.label2.Text = "Okunan Notlar";
            // 
            // FrmNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1368, 562);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GrdReadNotes);
            this.Controls.Add(this.GrpCtrlCurrentProcess);
            this.Controls.Add(this.GrdUnreadNotes);
            this.Name = "FrmNotes";
            this.Text = "FrmNotes";
            this.Load += new System.EventHandler(this.FrmNotes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TxtNoteId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNoteContent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNoteTitle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrpCtrlCurrentProcess)).EndInit();
            this.GrpCtrlCurrentProcess.ResumeLayout(false);
            this.GrpCtrlCurrentProcess.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CheckMarkAsRead.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdViewItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdUnreadNotes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdReadNotes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdViewItemsRead)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.TextEdit TxtNoteId;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SimpleButton SmpBtnList;
        private DevExpress.XtraEditors.SimpleButton SmpBtnUpdate;
        private DevExpress.XtraEditors.SimpleButton SmpBtnRemove;
        private DevExpress.XtraEditors.SimpleButton SmpBtnSave;
        private DevExpress.XtraEditors.TextEdit TxtNoteContent;
        private DevExpress.XtraEditors.LabelControl labelControl33;
        private DevExpress.XtraEditors.TextEdit TxtNoteTitle;
        private DevExpress.XtraEditors.GroupControl GrpCtrlCurrentProcess;
        private DevExpress.XtraEditors.LabelControl labelControl34;
        private DevExpress.XtraEditors.LabelControl LblTextProductName;
        private DevExpress.XtraGrid.Views.Grid.GridView GrdViewItems;
        private DevExpress.XtraGrid.GridControl GrdUnreadNotes;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl GrdReadNotes;
        private DevExpress.XtraGrid.Views.Grid.GridView GrdViewItemsRead;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.CheckEdit CheckMarkAsRead;
    }
}