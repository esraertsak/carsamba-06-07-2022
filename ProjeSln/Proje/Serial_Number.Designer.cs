namespace Proje
{
    partial class Serial_Number
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Serial_Number));
            this.textEditRevizyonno = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textEditoperator = new DevExpress.XtraEditors.TextEdit();
            this.textEditserino = new DevExpress.XtraEditors.TextEdit();
            this.textEditID = new DevExpress.XtraEditors.TextEdit();
            this.labelControlOperator = new DevExpress.XtraEditors.LabelControl();
            this.labelControlTarih = new DevExpress.XtraEditors.LabelControl();
            this.labelControlserino = new DevExpress.XtraEditors.LabelControl();
            this.labelControlID = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.seriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pCBDataSet = new Proje.PCBDataSet();
            this.gridViewserino = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colseri_no = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltest_revizyon_no = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltest_tarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltest_operator = new DevExpress.XtraGrid.Columns.GridColumn();
            this.seriTableAdapter = new Proje.PCBDataSetTableAdapters.seriTableAdapter();
            this.pCBDataSet1 = new Proje.PCBDataSet1();
            this.pCBDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.textEditRevizyonno.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditoperator.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditserino.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewserino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCBDataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textEditRevizyonno
            // 
            this.textEditRevizyonno.Location = new System.Drawing.Point(749, 195);
            this.textEditRevizyonno.Name = "textEditRevizyonno";
            this.textEditRevizyonno.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textEditRevizyonno.Properties.Appearance.Options.UseFont = true;
            this.textEditRevizyonno.Size = new System.Drawing.Size(170, 22);
            this.textEditRevizyonno.TabIndex = 29;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(640, 197);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(85, 16);
            this.labelControl1.TabIndex = 28;
            this.labelControl1.Text = "Revizyon No:";
            // 
            // simpleButton4
            // 
            this.simpleButton4.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton4.Appearance.Options.UseFont = true;
            this.simpleButton4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.ImageOptions.Image")));
            this.simpleButton4.Location = new System.Drawing.Point(803, 14);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(117, 39);
            this.simpleButton4.TabIndex = 27;
            this.simpleButton4.Text = "GERİ";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click_1);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker1.Location = new System.Drawing.Point(747, 157);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(170, 25);
            this.dateTimePicker1.TabIndex = 26;
            // 
            // textEditoperator
            // 
            this.textEditoperator.Location = new System.Drawing.Point(747, 227);
            this.textEditoperator.Name = "textEditoperator";
            this.textEditoperator.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textEditoperator.Properties.Appearance.Options.UseFont = true;
            this.textEditoperator.Size = new System.Drawing.Size(170, 22);
            this.textEditoperator.TabIndex = 25;
            // 
            // textEditserino
            // 
            this.textEditserino.Location = new System.Drawing.Point(747, 123);
            this.textEditserino.Name = "textEditserino";
            this.textEditserino.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textEditserino.Properties.Appearance.Options.UseFont = true;
            this.textEditserino.Size = new System.Drawing.Size(170, 22);
            this.textEditserino.TabIndex = 24;
            // 
            // textEditID
            // 
            this.textEditID.Location = new System.Drawing.Point(749, 87);
            this.textEditID.Name = "textEditID";
            this.textEditID.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textEditID.Properties.Appearance.Options.UseFont = true;
            this.textEditID.Size = new System.Drawing.Size(170, 22);
            this.textEditID.TabIndex = 23;
//            this.textEditID.EditValueChanged += new System.EventHandler(this.textEditID_EditValueChanged);
            // 
            // labelControlOperator
            // 
            this.labelControlOperator.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControlOperator.Appearance.Options.UseFont = true;
            this.labelControlOperator.Location = new System.Drawing.Point(640, 234);
            this.labelControlOperator.Name = "labelControlOperator";
            this.labelControlOperator.Size = new System.Drawing.Size(61, 16);
            this.labelControlOperator.TabIndex = 22;
            this.labelControlOperator.Text = "Test Opt:";
            // 
            // labelControlTarih
            // 
            this.labelControlTarih.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControlTarih.Appearance.Options.UseFont = true;
            this.labelControlTarih.Location = new System.Drawing.Point(640, 162);
            this.labelControlTarih.Name = "labelControlTarih";
            this.labelControlTarih.Size = new System.Drawing.Size(73, 16);
            this.labelControlTarih.TabIndex = 21;
            this.labelControlTarih.Text = "Test Tarihi:";
            // 
            // labelControlserino
            // 
            this.labelControlserino.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControlserino.Appearance.Options.UseFont = true;
            this.labelControlserino.Location = new System.Drawing.Point(640, 126);
            this.labelControlserino.Name = "labelControlserino";
            this.labelControlserino.Size = new System.Drawing.Size(51, 16);
            this.labelControlserino.TabIndex = 20;
            this.labelControlserino.Text = "Seri No:";
            // 
            // labelControlID
            // 
            this.labelControlID.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControlID.Appearance.Options.UseFont = true;
            this.labelControlID.Location = new System.Drawing.Point(640, 84);
            this.labelControlID.Name = "labelControlID";
            this.labelControlID.Size = new System.Drawing.Size(20, 16);
            this.labelControlID.TabIndex = 19;
            this.labelControlID.Text = "ID:";
            // 
            // simpleButton3
            // 
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(733, 277);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(103, 44);
            this.simpleButton3.TabIndex = 18;
            this.simpleButton3.Text = "DÜZENLE";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click_1);
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(842, 278);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(77, 40);
            this.simpleButton2.TabIndex = 17;
            this.simpleButton2.Text = "SİL";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click_1);
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(640, 277);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(85, 44);
            this.simpleButton1.TabIndex = 16;
            this.simpleButton1.Text = "EKLE";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click_1);
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(0, -2);
            this.gridControl1.MainView = this.gridViewserino;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(634, 518);
            this.gridControl1.TabIndex = 30;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewserino});
            // 
            // seriBindingSource
            // 
            this.seriBindingSource.DataMember = "seri";
            this.seriBindingSource.DataSource = this.pCBDataSet;
            // 
            // pCBDataSet
            // 
            this.pCBDataSet.DataSetName = "PCBDataSet";
            this.pCBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridViewserino
            // 
            this.gridViewserino.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridViewserino.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gridViewserino.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gridViewserino.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridViewserino.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridViewserino.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gridViewserino.Appearance.Row.ForeColor = System.Drawing.Color.Fuchsia;
            this.gridViewserino.Appearance.Row.Options.UseBackColor = true;
            this.gridViewserino.Appearance.Row.Options.UseForeColor = true;
            this.gridViewserino.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colseri_no,
            this.coltest_revizyon_no,
            this.coltest_tarihi,
            this.coltest_operator});
            this.gridViewserino.GridControl = this.gridControl1;
            this.gridViewserino.Name = "gridViewserino";
            this.gridViewserino.OptionsBehavior.Editable = false;
            this.gridViewserino.OptionsView.ShowAutoFilterRow = true;
            this.gridViewserino.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridViewserino_RowClick);
            this.gridViewserino.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gridViewserino_SelectionChanged);
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.Visible = true;
            this.colid.VisibleIndex = 0;
            this.colid.Width = 121;
            // 
            // colseri_no
            // 
            this.colseri_no.FieldName = "seri_no";
            this.colseri_no.Name = "colseri_no";
            this.colseri_no.Visible = true;
            this.colseri_no.VisibleIndex = 1;
            this.colseri_no.Width = 121;
            // 
            // coltest_revizyon_no
            // 
            this.coltest_revizyon_no.FieldName = "test_revizyon_no";
            this.coltest_revizyon_no.Name = "coltest_revizyon_no";
            this.coltest_revizyon_no.Visible = true;
            this.coltest_revizyon_no.VisibleIndex = 2;
            this.coltest_revizyon_no.Width = 121;
            // 
            // coltest_tarihi
            // 
            this.coltest_tarihi.FieldName = "test_tarihi";
            this.coltest_tarihi.Name = "coltest_tarihi";
            this.coltest_tarihi.Visible = true;
            this.coltest_tarihi.VisibleIndex = 3;
            this.coltest_tarihi.Width = 126;
            // 
            // coltest_operator
            // 
            this.coltest_operator.FieldName = "test_operator";
            this.coltest_operator.Name = "coltest_operator";
            this.coltest_operator.Visible = true;
            this.coltest_operator.VisibleIndex = 4;
            this.coltest_operator.Width = 120;
            // 
            // seriTableAdapter
            // 
            this.seriTableAdapter.ClearBeforeFill = true;
            // 
            // pCBDataSet1
            // 
            this.pCBDataSet1.DataSetName = "PCBDataSet1";
            this.pCBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pCBDataSet1BindingSource
            // 
            this.pCBDataSet1BindingSource.DataSource = this.pCBDataSet1;
            this.pCBDataSet1BindingSource.Position = 0;
            // 
            // Serial_Number
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.ControlBox = false;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.textEditRevizyonno);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.simpleButton4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textEditoperator);
            this.Controls.Add(this.textEditserino);
            this.Controls.Add(this.textEditID);
            this.Controls.Add(this.labelControlOperator);
            this.Controls.Add(this.labelControlTarih);
            this.Controls.Add(this.labelControlserino);
            this.Controls.Add(this.labelControlID);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Serial_Number";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Serial_Number";
            this.Load += new System.EventHandler(this.Serial_Number_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textEditRevizyonno.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditoperator.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditserino.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewserino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCBDataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private DevExpress.XtraEditors.TextEdit textEditoperator;
        private DevExpress.XtraEditors.TextEdit textEditserino;
        private DevExpress.XtraEditors.TextEdit textEditID;
        private DevExpress.XtraEditors.LabelControl labelControlOperator;
        private DevExpress.XtraEditors.LabelControl labelControlTarih;
        private DevExpress.XtraEditors.LabelControl labelControlserino;
        private DevExpress.XtraEditors.LabelControl labelControlID;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private PCBDataSet pCBDataSet;
        private System.Windows.Forms.BindingSource seriBindingSource;
        private PCBDataSetTableAdapters.seriTableAdapter seriTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colseri_no;
        private DevExpress.XtraGrid.Columns.GridColumn coltest_revizyon_no;
        private DevExpress.XtraGrid.Columns.GridColumn coltest_tarihi;
        private DevExpress.XtraGrid.Columns.GridColumn coltest_operator;
        public DevExpress.XtraEditors.TextEdit textEditRevizyonno;
        public DevExpress.XtraGrid.Views.Grid.GridView gridViewserino;
        private System.Windows.Forms.BindingSource pCBDataSet1BindingSource;
        private PCBDataSet1 pCBDataSet1;
    }
}