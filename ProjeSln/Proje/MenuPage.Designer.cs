namespace Proje
{
    partial class MenuPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPage));
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.BtnAyarlar = new DevExpress.XtraEditors.SimpleButton();
            this.BtnRaporOrtami = new DevExpress.XtraEditors.SimpleButton();
            this.BtnTestOrtami = new DevExpress.XtraEditors.SimpleButton();
            this.btncikisMenupage = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tablePanel1.Controls.Add(this.BtnAyarlar);
            this.tablePanel1.Controls.Add(this.BtnRaporOrtami);
            this.tablePanel1.Controls.Add(this.BtnTestOrtami);
            this.tablePanel1.Location = new System.Drawing.Point(243, 12);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 142F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 145F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel1.Size = new System.Drawing.Size(391, 426);
            this.tablePanel1.TabIndex = 0;
            // 
            // BtnAyarlar
            // 
            this.BtnAyarlar.Appearance.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnAyarlar.Appearance.Options.UseFont = true;
            this.tablePanel1.SetColumn(this.BtnAyarlar, 0);
            this.BtnAyarlar.Location = new System.Drawing.Point(3, 293);
            this.BtnAyarlar.Name = "BtnAyarlar";
            this.tablePanel1.SetRow(this.BtnAyarlar, 2);
            this.BtnAyarlar.Size = new System.Drawing.Size(385, 126);
            this.BtnAyarlar.TabIndex = 3;
            this.BtnAyarlar.Text = "AYARLAR";
            // 
            // BtnRaporOrtami
            // 
            this.BtnRaporOrtami.Appearance.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnRaporOrtami.Appearance.Options.UseFont = true;
            this.tablePanel1.SetColumn(this.BtnRaporOrtami, 0);
            this.BtnRaporOrtami.Location = new System.Drawing.Point(3, 145);
            this.BtnRaporOrtami.Name = "BtnRaporOrtami";
            this.tablePanel1.SetRow(this.BtnRaporOrtami, 1);
            this.BtnRaporOrtami.Size = new System.Drawing.Size(385, 138);
            this.BtnRaporOrtami.TabIndex = 1;
            this.BtnRaporOrtami.Text = "RAPOR ORTAMI";
            // 
            // BtnTestOrtami
            // 
            this.BtnTestOrtami.Appearance.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnTestOrtami.Appearance.Options.UseFont = true;
            this.tablePanel1.SetColumn(this.BtnTestOrtami, 0);
            this.BtnTestOrtami.Location = new System.Drawing.Point(3, 3);
            this.BtnTestOrtami.Name = "BtnTestOrtami";
            this.tablePanel1.SetRow(this.BtnTestOrtami, 0);
            this.BtnTestOrtami.Size = new System.Drawing.Size(385, 136);
            this.BtnTestOrtami.TabIndex = 0;
            this.BtnTestOrtami.Text = "TEST ORTAMI";
            this.BtnTestOrtami.Click += new System.EventHandler(this.BtnTestOrtami_Click);
            // 
            // btncikisMenupage
            // 
            this.btncikisMenupage.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btncikisMenupage.Appearance.Options.UseFont = true;
            this.btncikisMenupage.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btncikisMenupage.ImageOptions.Image")));
            this.btncikisMenupage.Location = new System.Drawing.Point(755, 1);
            this.btncikisMenupage.Name = "btncikisMenupage";
            this.btncikisMenupage.Size = new System.Drawing.Size(90, 34);
            this.btncikisMenupage.TabIndex = 1;
            this.btncikisMenupage.Text = "ÇIKIŞ";
            this.btncikisMenupage.Click += new System.EventHandler(this.btncikisMenupage_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(12, 12);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(100, 34);
            this.simpleButton1.TabIndex = 3;
            this.simpleButton1.Text = "GERİ";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // MenuPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 488);
            this.ControlBox = false;
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.btncikisMenupage);
            this.Controls.Add(this.tablePanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MenuPage";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuPage";
            this.Load += new System.EventHandler(this.MenuPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraEditors.SimpleButton BtnTestOrtami;
        private DevExpress.XtraEditors.SimpleButton BtnAyarlar;
        private DevExpress.XtraEditors.SimpleButton BtnRaporOrtami;
        private DevExpress.XtraEditors.SimpleButton btncikisMenupage;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}