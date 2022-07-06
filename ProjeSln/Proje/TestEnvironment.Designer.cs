namespace Proje
{
    partial class TestEnvironment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestEnvironment));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.comboBoxPorts = new System.Windows.Forms.ComboBox();
            this.simpleButtonbaglan = new DevExpress.XtraEditors.SimpleButton();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButtonOku = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonRevision = new DevExpress.XtraEditors.SimpleButton();
            this.groupControlasama2 = new DevExpress.XtraEditors.GroupControl();
            this.textEditSeriNo = new DevExpress.XtraEditors.TextEdit();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.groupControlasama1 = new DevExpress.XtraEditors.GroupControl();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl4asama = new DevExpress.XtraEditors.GroupControl();
            this.labelStatus = new DevExpress.XtraEditors.LabelControl();
            this.progressBarControl = new DevExpress.XtraEditors.MarqueeProgressBarControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlasama2)).BeginInit();
            this.groupControlasama2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditSeriNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlasama1)).BeginInit();
            this.groupControlasama1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4asama)).BeginInit();
            this.groupControl4asama.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(34, 50);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(240, 24);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "1- Lütfen kartı yerleştiriniz.";
            // 
            // comboBoxPorts
            // 
            this.comboBoxPorts.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxPorts.FormattingEnabled = true;
            this.comboBoxPorts.Location = new System.Drawing.Point(383, 53);
            this.comboBoxPorts.Name = "comboBoxPorts";
            this.comboBoxPorts.Size = new System.Drawing.Size(129, 28);
            this.comboBoxPorts.TabIndex = 1;
            // 
            // simpleButtonbaglan
            // 
            this.simpleButtonbaglan.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButtonbaglan.Appearance.Options.UseFont = true;
            this.simpleButtonbaglan.Location = new System.Drawing.Point(557, 52);
            this.simpleButtonbaglan.Name = "simpleButtonbaglan";
            this.simpleButtonbaglan.Size = new System.Drawing.Size(88, 31);
            this.simpleButtonbaglan.TabIndex = 2;
            this.simpleButtonbaglan.Text = "Bağlan";
            this.simpleButtonbaglan.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(29, 52);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(196, 24);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "2-Kart Seri No giriniz:";
            // 
            // simpleButtonOku
            // 
            this.simpleButtonOku.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButtonOku.Appearance.Options.UseFont = true;
            this.simpleButtonOku.Location = new System.Drawing.Point(557, 53);
            this.simpleButtonOku.Name = "simpleButtonOku";
            this.simpleButtonOku.Size = new System.Drawing.Size(88, 24);
            this.simpleButtonOku.TabIndex = 5;
            this.simpleButtonOku.Text = " Oku";
            this.simpleButtonOku.Click += new System.EventHandler(this.simpleButtonOku_Click);
            // 
            // simpleButtonRevision
            // 
            this.simpleButtonRevision.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButtonRevision.Appearance.Options.UseFont = true;
            this.simpleButtonRevision.Location = new System.Drawing.Point(476, 53);
            this.simpleButtonRevision.Name = "simpleButtonRevision";
            this.simpleButtonRevision.Size = new System.Drawing.Size(75, 23);
            this.simpleButtonRevision.TabIndex = 6;
            this.simpleButtonRevision.Text = ".....";
            // 
            // groupControlasama2
            // 
            this.groupControlasama2.Controls.Add(this.simpleButtonOku);
            this.groupControlasama2.Controls.Add(this.simpleButtonRevision);
            this.groupControlasama2.Controls.Add(this.labelControl2);
            this.groupControlasama2.Controls.Add(this.textEditSeriNo);
            this.groupControlasama2.Location = new System.Drawing.Point(55, 12);
            this.groupControlasama2.Name = "groupControlasama2";
            this.groupControlasama2.Size = new System.Drawing.Size(862, 92);
            this.groupControlasama2.TabIndex = 7;
            this.groupControlasama2.Text = "2.Aşama";
            // 
            // textEditSeriNo
            // 
            this.textEditSeriNo.Location = new System.Drawing.Point(330, 53);
            this.textEditSeriNo.Name = "textEditSeriNo";
            this.textEditSeriNo.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textEditSeriNo.Properties.Appearance.Options.UseFont = true;
            this.textEditSeriNo.Size = new System.Drawing.Size(129, 26);
            this.textEditSeriNo.TabIndex = 4;
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.simpleButton3);
            this.groupControl3.Controls.Add(this.simpleButton2);
            this.groupControl3.Controls.Add(this.labelControl3);
            this.groupControl3.Location = new System.Drawing.Point(161, 212);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(593, 82);
            this.groupControl3.TabIndex = 8;
            this.groupControl3.Text = "3.asama";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(14, 38);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(170, 24);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "3-Test başlasın mı?";
            // 
            // groupControlasama1
            // 
            this.groupControlasama1.Controls.Add(this.labelControl1);
            this.groupControlasama1.Controls.Add(this.comboBoxPorts);
            this.groupControlasama1.Controls.Add(this.simpleButtonbaglan);
            this.groupControlasama1.Location = new System.Drawing.Point(41, 110);
            this.groupControlasama1.Name = "groupControlasama1";
            this.groupControlasama1.Size = new System.Drawing.Size(862, 96);
            this.groupControlasama1.TabIndex = 7;
            this.groupControlasama1.Text = "1.Aşama";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(880, 12);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(100, 34);
            this.simpleButton1.TabIndex = 8;
            this.simpleButton1.Text = "GERİ";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click_1);
            // 
            // groupControl4asama
            // 
            this.groupControl4asama.Controls.Add(this.labelStatus);
            this.groupControl4asama.Controls.Add(this.progressBarControl);
            this.groupControl4asama.Location = new System.Drawing.Point(105, 300);
            this.groupControl4asama.Name = "groupControl4asama";
            this.groupControl4asama.Size = new System.Drawing.Size(750, 85);
            this.groupControl4asama.TabIndex = 14;
            this.groupControl4asama.Text = "4.Aşama";
            // 
            // labelStatus
            // 
            this.labelStatus.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelStatus.Appearance.Options.UseFont = true;
            this.labelStatus.Location = new System.Drawing.Point(14, 34);
            this.labelStatus.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(123, 19);
            this.labelStatus.TabIndex = 8;
            this.labelStatus.Text = "Test Başlatılıyor...";
            // 
            // progressBarControl
            // 
            this.progressBarControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarControl.EditValue = 0;
            this.progressBarControl.Location = new System.Drawing.Point(14, 57);
            this.progressBarControl.Name = "progressBarControl";
            this.progressBarControl.Size = new System.Drawing.Size(419, 13);
            this.progressBarControl.TabIndex = 6;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Location = new System.Drawing.Point(210, 38);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 15;
            this.simpleButton2.Text = "EVET";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.Location = new System.Drawing.Point(291, 38);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(72, 24);
            this.simpleButton3.TabIndex = 16;
            this.simpleButton3.Text = "HAYIR";
            // 
            // TestEnvironment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 493);
            this.ControlBox = false;
            this.Controls.Add(this.groupControl4asama);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.groupControlasama2);
            this.Controls.Add(this.groupControlasama1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TestEnvironment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test Environment";
            this.Load += new System.EventHandler(this.TestEnvironment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControlasama2)).EndInit();
            this.groupControlasama2.ResumeLayout(false);
            this.groupControlasama2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditSeriNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlasama1)).EndInit();
            this.groupControlasama1.ResumeLayout(false);
            this.groupControlasama1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4asama)).EndInit();
            this.groupControl4asama.ResumeLayout(false);
            this.groupControl4asama.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ComboBox comboBoxPorts;
        private DevExpress.XtraEditors.SimpleButton simpleButtonbaglan;
        private System.IO.Ports.SerialPort serialPort1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton simpleButtonOku;
        private DevExpress.XtraEditors.SimpleButton simpleButtonRevision;
        private DevExpress.XtraEditors.GroupControl groupControlasama2;
        private DevExpress.XtraEditors.GroupControl groupControlasama1;
        private DevExpress.XtraEditors.TextEdit textEditSeriNo;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.GroupControl groupControl4asama;
        private DevExpress.XtraEditors.LabelControl labelStatus;
        private DevExpress.XtraEditors.MarqueeProgressBarControl progressBarControl;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}