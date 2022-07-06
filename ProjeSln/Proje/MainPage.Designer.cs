namespace Proje
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.btnCikis = new DevExpress.XtraEditors.SimpleButton();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.btnbcu = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton8 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton7 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton6 = new DevExpress.XtraEditors.SimpleButton();
            this.btnhvc = new DevExpress.XtraEditors.SimpleButton();
            this.btnhvcu = new DevExpress.XtraEditors.SimpleButton();
            this.btnvccu = new DevExpress.XtraEditors.SimpleButton();
            this.btnbmu = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCikis
            // 
            this.btnCikis.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.Appearance.Options.UseFont = true;
            this.btnCikis.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCikis.ImageOptions.Image")));
            this.btnCikis.Location = new System.Drawing.Point(835, 8);
            this.btnCikis.Margin = new System.Windows.Forms.Padding(4);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(87, 38);
            this.btnCikis.TabIndex = 0;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 48.95F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 51.05F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tablePanel1.Controls.Add(this.btnbcu);
            this.tablePanel1.Controls.Add(this.simpleButton8);
            this.tablePanel1.Controls.Add(this.simpleButton7);
            this.tablePanel1.Controls.Add(this.simpleButton6);
            this.tablePanel1.Controls.Add(this.btnhvc);
            this.tablePanel1.Controls.Add(this.btnhvcu);
            this.tablePanel1.Controls.Add(this.btnvccu);
            this.tablePanel1.Controls.Add(this.btnbmu);
            this.tablePanel1.Location = new System.Drawing.Point(13, 54);
            this.tablePanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 162F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel1.Size = new System.Drawing.Size(935, 456);
            this.tablePanel1.TabIndex = 1;
            // 
            // btnbcu
            // 
            this.btnbcu.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnbcu.Appearance.Options.UseFont = true;
            this.tablePanel1.SetColumn(this.btnbcu, 3);
            this.btnbcu.Enabled = false;
            this.btnbcu.Location = new System.Drawing.Point(705, 201);
            this.btnbcu.Margin = new System.Windows.Forms.Padding(4);
            this.btnbcu.Name = "btnbcu";
            this.tablePanel1.SetRow(this.btnbcu, 1);
            this.btnbcu.Size = new System.Drawing.Size(226, 215);
            this.btnbcu.TabIndex = 7;
            this.btnbcu.Text = "BCU";
            // 
            // simpleButton8
            // 
            this.tablePanel1.SetColumn(this.simpleButton8, 2);
            this.simpleButton8.Enabled = false;
            this.simpleButton8.Location = new System.Drawing.Point(467, 201);
            this.simpleButton8.Margin = new System.Windows.Forms.Padding(4);
            this.simpleButton8.Name = "simpleButton8";
            this.tablePanel1.SetRow(this.simpleButton8, 1);
            this.simpleButton8.Size = new System.Drawing.Size(231, 215);
            this.simpleButton8.TabIndex = 6;
            this.simpleButton8.Text = "simpleButton8";
            // 
            // simpleButton7
            // 
            this.tablePanel1.SetColumn(this.simpleButton7, 1);
            this.simpleButton7.Enabled = false;
            this.simpleButton7.Location = new System.Drawing.Point(238, 201);
            this.simpleButton7.Margin = new System.Windows.Forms.Padding(4);
            this.simpleButton7.Name = "simpleButton7";
            this.tablePanel1.SetRow(this.simpleButton7, 1);
            this.simpleButton7.Size = new System.Drawing.Size(221, 215);
            this.simpleButton7.TabIndex = 5;
            this.simpleButton7.Text = "simpleButton7";
            // 
            // simpleButton6
            // 
            this.tablePanel1.SetColumn(this.simpleButton6, 0);
            this.simpleButton6.Enabled = false;
            this.simpleButton6.Location = new System.Drawing.Point(4, 201);
            this.simpleButton6.Margin = new System.Windows.Forms.Padding(4);
            this.simpleButton6.Name = "simpleButton6";
            this.tablePanel1.SetRow(this.simpleButton6, 1);
            this.simpleButton6.Size = new System.Drawing.Size(226, 215);
            this.simpleButton6.TabIndex = 4;
            this.simpleButton6.Text = "simpleButton6";
            // 
            // btnhvc
            // 
            this.btnhvc.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnhvc.Appearance.Options.UseFont = true;
            this.tablePanel1.SetColumn(this.btnhvc, 3);
            this.btnhvc.Enabled = false;
            this.btnhvc.Location = new System.Drawing.Point(705, 4);
            this.btnhvc.Margin = new System.Windows.Forms.Padding(4);
            this.btnhvc.Name = "btnhvc";
            this.tablePanel1.SetRow(this.btnhvc, 0);
            this.btnhvc.Size = new System.Drawing.Size(226, 154);
            this.btnhvc.TabIndex = 3;
            this.btnhvc.Text = "HVC";
            this.btnhvc.Click += new System.EventHandler(this.btnhvc_Click);
            // 
            // btnhvcu
            // 
            this.btnhvcu.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnhvcu.Appearance.Options.UseFont = true;
            this.tablePanel1.SetColumn(this.btnhvcu, 1);
            this.btnhvcu.Enabled = false;
            this.btnhvcu.Location = new System.Drawing.Point(238, 4);
            this.btnhvcu.Margin = new System.Windows.Forms.Padding(4);
            this.btnhvcu.Name = "btnhvcu";
            this.tablePanel1.SetRow(this.btnhvcu, 0);
            this.btnhvcu.Size = new System.Drawing.Size(221, 154);
            this.btnhvcu.TabIndex = 2;
            this.btnhvcu.Text = "HVCU";
            // 
            // btnvccu
            // 
            this.btnvccu.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnvccu.Appearance.Options.UseFont = true;
            this.tablePanel1.SetColumn(this.btnvccu, 2);
            this.btnvccu.Enabled = false;
            this.btnvccu.Location = new System.Drawing.Point(467, 4);
            this.btnvccu.Margin = new System.Windows.Forms.Padding(4);
            this.btnvccu.Name = "btnvccu";
            this.tablePanel1.SetRow(this.btnvccu, 0);
            this.btnvccu.Size = new System.Drawing.Size(231, 154);
            this.btnvccu.TabIndex = 1;
            this.btnvccu.Text = "VCCU";
            // 
            // btnbmu
            // 
            this.btnbmu.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnbmu.Appearance.Options.UseFont = true;
            this.tablePanel1.SetColumn(this.btnbmu, 0);
            this.btnbmu.Location = new System.Drawing.Point(4, 4);
            this.btnbmu.Margin = new System.Windows.Forms.Padding(4);
            this.btnbmu.Name = "btnbmu";
            this.tablePanel1.SetRow(this.btnbmu, 0);
            this.btnbmu.Size = new System.Drawing.Size(226, 154);
            this.btnbmu.TabIndex = 0;
            this.btnbmu.Text = "BMU";
            this.btnbmu.Click += new System.EventHandler(this.btnbmu_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 523);
            this.ControlBox = false;
            this.Controls.Add(this.tablePanel1);
            this.Controls.Add(this.btnCikis);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainPage";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainPage";
            this.Load += new System.EventHandler(this.MainPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnCikis;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraEditors.SimpleButton btnbcu;
        private DevExpress.XtraEditors.SimpleButton simpleButton8;
        private DevExpress.XtraEditors.SimpleButton simpleButton7;
        private DevExpress.XtraEditors.SimpleButton simpleButton6;
        private DevExpress.XtraEditors.SimpleButton btnhvc;
        private DevExpress.XtraEditors.SimpleButton btnhvcu;
        private DevExpress.XtraEditors.SimpleButton btnvccu;
        private DevExpress.XtraEditors.SimpleButton btnbmu;
    }
}