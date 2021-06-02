
namespace isTakipProje.Forms
{
    partial class FrmEmployees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmployees));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lookUpEditDepartment = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.textImage = new DevExpress.XtraEditors.TextEdit();
            this.textTelephone = new DevExpress.XtraEditors.TextEdit();
            this.textMail = new DevExpress.XtraEditors.TextEdit();
            this.textSurname = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.BtnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.BtnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.BtnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.textName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.textId = new DevExpress.XtraEditors.TextEdit();
            this.BtnList = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditDepartment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textImage.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textTelephone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textMail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textSurname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.lookUpEditDepartment);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.textImage);
            this.groupControl1.Controls.Add(this.textTelephone);
            this.groupControl1.Controls.Add(this.textMail);
            this.groupControl1.Controls.Add(this.textSurname);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.BtnUpdate);
            this.groupControl1.Controls.Add(this.BtnAdd);
            this.groupControl1.Controls.Add(this.BtnDelete);
            this.groupControl1.Controls.Add(this.textName);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.textId);
            this.groupControl1.Controls.Add(this.BtnList);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(652, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(320, 340);
            this.groupControl1.TabIndex = 1;
            // 
            // lookUpEditDepartment
            // 
            this.lookUpEditDepartment.EditValue = "";
            this.lookUpEditDepartment.Location = new System.Drawing.Point(99, 204);
            this.lookUpEditDepartment.Name = "lookUpEditDepartment";
            this.lookUpEditDepartment.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditDepartment.Size = new System.Drawing.Size(100, 20);
            this.lookUpEditDepartment.TabIndex = 19;
            this.lookUpEditDepartment.EditValueChanged += new System.EventHandler(this.lookUpEditDepartment_EditValueChanged);
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(16, 181);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(40, 13);
            this.labelControl7.TabIndex = 18;
            this.labelControl7.Text = "Görsel  :";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(16, 207);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(60, 13);
            this.labelControl6.TabIndex = 17;
            this.labelControl6.Text = "Departman :";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(16, 155);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(43, 13);
            this.labelControl5.TabIndex = 16;
            this.labelControl5.Text = "Telefon :";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(16, 129);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(25, 13);
            this.labelControl4.TabIndex = 15;
            this.labelControl4.Text = "Mail :";
            // 
            // textImage
            // 
            this.textImage.Location = new System.Drawing.Point(99, 174);
            this.textImage.Name = "textImage";
            this.textImage.Size = new System.Drawing.Size(202, 20);
            this.textImage.TabIndex = 13;
            // 
            // textTelephone
            // 
            this.textTelephone.Location = new System.Drawing.Point(100, 148);
            this.textTelephone.Name = "textTelephone";
            this.textTelephone.Size = new System.Drawing.Size(202, 20);
            this.textTelephone.TabIndex = 12;
            // 
            // textMail
            // 
            this.textMail.Location = new System.Drawing.Point(100, 122);
            this.textMail.Name = "textMail";
            this.textMail.Size = new System.Drawing.Size(202, 20);
            this.textMail.TabIndex = 11;
            // 
            // textSurname
            // 
            this.textSurname.Location = new System.Drawing.Point(100, 96);
            this.textSurname.Name = "textSurname";
            this.textSurname.Size = new System.Drawing.Size(202, 20);
            this.textSurname.TabIndex = 10;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(16, 103);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(37, 13);
            this.labelControl3.TabIndex = 9;
            this.labelControl3.Text = "Soyad :";
            this.labelControl3.Click += new System.EventHandler(this.labelControl3_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnUpdate.ImageOptions.Image")));
            this.BtnUpdate.Location = new System.Drawing.Point(176, 309);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(104, 23);
            this.BtnUpdate.TabIndex = 8;
            this.BtnUpdate.Text = "Güncelle";
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnAdd.ImageOptions.Image")));
            this.BtnAdd.Location = new System.Drawing.Point(176, 263);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(104, 23);
            this.BtnAdd.TabIndex = 7;
            this.BtnAdd.Text = "Ekle";
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnDelete.ImageOptions.Image")));
            this.BtnDelete.Location = new System.Drawing.Point(49, 309);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(104, 23);
            this.BtnDelete.TabIndex = 6;
            this.BtnDelete.Text = "Sil";
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(100, 70);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(202, 20);
            this.textName.TabIndex = 5;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(16, 77);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(22, 13);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Adı :";
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(99, 44);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(202, 20);
            this.textId.TabIndex = 3;
            // 
            // BtnList
            // 
            this.BtnList.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnList.ImageOptions.Image")));
            this.BtnList.Location = new System.Drawing.Point(49, 263);
            this.BtnList.Name = "BtnList";
            this.BtnList.Size = new System.Drawing.Size(104, 23);
            this.BtnList.TabIndex = 2;
            this.BtnList.Text = "Listele";
            this.BtnList.Click += new System.EventHandler(this.BtnList_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(16, 47);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(62, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Personel ID :";
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(-2, 2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(648, 340);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // FrmEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 346);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Name = "FrmEmployees";
            this.Text = "FrmEmployees";
            this.Load += new System.EventHandler(this.FrmEmployees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditDepartment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textImage.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textTelephone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textMail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textSurname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton BtnUpdate;
        private DevExpress.XtraEditors.SimpleButton BtnAdd;
        private DevExpress.XtraEditors.SimpleButton BtnDelete;
        private DevExpress.XtraEditors.TextEdit textName;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit textId;
        private DevExpress.XtraEditors.SimpleButton BtnList;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit textImage;
        private DevExpress.XtraEditors.TextEdit textTelephone;
        private DevExpress.XtraEditors.TextEdit textMail;
        private DevExpress.XtraEditors.TextEdit textSurname;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditDepartment;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
    }
}