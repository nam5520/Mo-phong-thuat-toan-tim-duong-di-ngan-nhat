
namespace Mo_phong_do_thi.GUI
{
    partial class FrmDijkstraDieuKhienChay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDijkstraDieuKhienChay));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.btnPrev = new DevExpress.XtraEditors.SimpleButton();
            this.btnNext = new DevExpress.XtraEditors.SimpleButton();
            this.btnEnd = new DevExpress.XtraEditors.SimpleButton();
            this.btnStart = new DevExpress.XtraEditors.SimpleButton();
            this.btnBatDauChayTungBuoc = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnKetThuc = new DevExpress.XtraEditors.SimpleButton();
            this.btnTamDung = new DevExpress.XtraEditors.SimpleButton();
            this.btnStartChayTuDong = new DevExpress.XtraEditors.SimpleButton();
            this.txtDelay = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.groupSetting = new DevExpress.XtraEditors.PanelControl();
            this.cbxDinhKetThuc = new DevExpress.XtraEditors.LookUpEdit();
            this.cbxDinhXuatPhat = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.panelMain = new DevExpress.XtraEditors.PanelControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDelay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupSetting)).BeginInit();
            this.groupSetting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxDinhKetThuc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxDinhXuatPhat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelMain)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupControl1.AutoSize = true;
            this.groupControl1.Controls.Add(this.groupControl4);
            this.groupControl1.Controls.Add(this.groupControl3);
            this.groupControl1.Controls.Add(this.groupSetting);
            this.groupControl1.Location = new System.Drawing.Point(3, 5);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(437, 651);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Điều khiển";
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.panelControl3);
            this.groupControl4.Location = new System.Drawing.Point(6, 392);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(424, 170);
            this.groupControl4.TabIndex = 2;
            this.groupControl4.Text = "Chạy từng bước";
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.btnPrev);
            this.panelControl3.Controls.Add(this.btnNext);
            this.panelControl3.Controls.Add(this.btnEnd);
            this.panelControl3.Controls.Add(this.btnStart);
            this.panelControl3.Controls.Add(this.btnBatDauChayTungBuoc);
            this.panelControl3.Location = new System.Drawing.Point(5, 31);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(414, 131);
            this.panelControl3.TabIndex = 1;
            // 
            // btnPrev
            // 
            this.btnPrev.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrev.Appearance.Options.UseFont = true;
            this.btnPrev.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPrev.ImageOptions.Image")));
            this.btnPrev.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnPrev.Location = new System.Drawing.Point(113, 74);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(92, 41);
            this.btnPrev.TabIndex = 9;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Appearance.Options.UseFont = true;
            this.btnNext.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.ImageOptions.Image")));
            this.btnNext.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnNext.Location = new System.Drawing.Point(214, 74);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(83, 41);
            this.btnNext.TabIndex = 8;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnd.Appearance.Options.UseFont = true;
            this.btnEnd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEnd.ImageOptions.Image")));
            this.btnEnd.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnEnd.Location = new System.Drawing.Point(303, 74);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(97, 41);
            this.btnEnd.TabIndex = 7;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // btnStart
            // 
            this.btnStart.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Appearance.Options.UseFont = true;
            this.btnStart.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnStart.ImageOptions.Image")));
            this.btnStart.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnStart.Location = new System.Drawing.Point(14, 74);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(93, 41);
            this.btnStart.TabIndex = 6;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnBatDauChayTungBuoc
            // 
            this.btnBatDauChayTungBuoc.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatDauChayTungBuoc.Appearance.Options.UseFont = true;
            this.btnBatDauChayTungBuoc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBatDauChayTungBuoc.ImageOptions.Image")));
            this.btnBatDauChayTungBuoc.Location = new System.Drawing.Point(13, 15);
            this.btnBatDauChayTungBuoc.Name = "btnBatDauChayTungBuoc";
            this.btnBatDauChayTungBuoc.Size = new System.Drawing.Size(387, 41);
            this.btnBatDauChayTungBuoc.TabIndex = 5;
            this.btnBatDauChayTungBuoc.Text = "Bắt đầu chạy từng bước";
            this.btnBatDauChayTungBuoc.Click += new System.EventHandler(this.btnBatDauChayTungBuoc_Click);
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.panelControl2);
            this.groupControl3.Location = new System.Drawing.Point(6, 155);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(424, 231);
            this.groupControl3.TabIndex = 1;
            this.groupControl3.Text = "Chạy tự động";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnKetThuc);
            this.panelControl2.Controls.Add(this.btnTamDung);
            this.panelControl2.Controls.Add(this.btnStartChayTuDong);
            this.panelControl2.Controls.Add(this.txtDelay);
            this.panelControl2.Controls.Add(this.labelControl3);
            this.panelControl2.Location = new System.Drawing.Point(5, 31);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(414, 191);
            this.panelControl2.TabIndex = 1;
            // 
            // btnKetThuc
            // 
            this.btnKetThuc.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKetThuc.Appearance.Options.UseFont = true;
            this.btnKetThuc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKetThuc.ImageOptions.Image")));
            this.btnKetThuc.Location = new System.Drawing.Point(13, 134);
            this.btnKetThuc.Name = "btnKetThuc";
            this.btnKetThuc.Size = new System.Drawing.Size(387, 41);
            this.btnKetThuc.TabIndex = 5;
            this.btnKetThuc.Text = "Kết thúc";
            this.btnKetThuc.Click += new System.EventHandler(this.btnKetThuc_Click);
            // 
            // btnTamDung
            // 
            this.btnTamDung.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTamDung.Appearance.Options.UseFont = true;
            this.btnTamDung.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTamDung.ImageOptions.Image")));
            this.btnTamDung.Location = new System.Drawing.Point(214, 69);
            this.btnTamDung.Name = "btnTamDung";
            this.btnTamDung.Size = new System.Drawing.Size(186, 41);
            this.btnTamDung.TabIndex = 4;
            this.btnTamDung.Text = "Tạm dừng";
            this.btnTamDung.Click += new System.EventHandler(this.btnTamDung_Click);
            // 
            // btnStartChayTuDong
            // 
            this.btnStartChayTuDong.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartChayTuDong.Appearance.Options.UseFont = true;
            this.btnStartChayTuDong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnStartChayTuDong.ImageOptions.Image")));
            this.btnStartChayTuDong.Location = new System.Drawing.Point(13, 69);
            this.btnStartChayTuDong.Name = "btnStartChayTuDong";
            this.btnStartChayTuDong.Size = new System.Drawing.Size(185, 41);
            this.btnStartChayTuDong.TabIndex = 3;
            this.btnStartChayTuDong.Text = "Bắt đầu chạy";
            this.btnStartChayTuDong.Click += new System.EventHandler(this.btnStartChayTuDong_Click);
            // 
            // txtDelay
            // 
            this.txtDelay.EditValue = "1000";
            this.txtDelay.Location = new System.Drawing.Point(148, 22);
            this.txtDelay.Name = "txtDelay";
            this.txtDelay.Size = new System.Drawing.Size(252, 22);
            this.txtDelay.TabIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(21, 26);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(108, 18);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Thời gian delay :";
            // 
            // groupSetting
            // 
            this.groupSetting.Controls.Add(this.cbxDinhKetThuc);
            this.groupSetting.Controls.Add(this.cbxDinhXuatPhat);
            this.groupSetting.Controls.Add(this.labelControl2);
            this.groupSetting.Controls.Add(this.labelControl1);
            this.groupSetting.Location = new System.Drawing.Point(6, 32);
            this.groupSetting.Name = "groupSetting";
            this.groupSetting.Size = new System.Drawing.Size(424, 116);
            this.groupSetting.TabIndex = 0;
            // 
            // cbxDinhKetThuc
            // 
            this.cbxDinhKetThuc.Location = new System.Drawing.Point(130, 63);
            this.cbxDinhKetThuc.Name = "cbxDinhKetThuc";
            this.cbxDinhKetThuc.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxDinhKetThuc.Properties.Appearance.Options.UseFont = true;
            this.cbxDinhKetThuc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxDinhKetThuc.Properties.NullText = "Chọn đỉnh";
            this.cbxDinhKetThuc.Size = new System.Drawing.Size(275, 24);
            this.cbxDinhKetThuc.TabIndex = 5;
            // 
            // cbxDinhXuatPhat
            // 
            this.cbxDinhXuatPhat.Location = new System.Drawing.Point(130, 23);
            this.cbxDinhXuatPhat.Name = "cbxDinhXuatPhat";
            this.cbxDinhXuatPhat.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxDinhXuatPhat.Properties.Appearance.Options.UseFont = true;
            this.cbxDinhXuatPhat.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxDinhXuatPhat.Properties.NullText = "Chọn đỉnh";
            this.cbxDinhXuatPhat.Size = new System.Drawing.Size(275, 24);
            this.cbxDinhXuatPhat.TabIndex = 5;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(19, 69);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(96, 18);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Đỉnh kết thúc :";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(18, 26);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(94, 18);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Đỉnh bắt đầu :";
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.Controls.Add(this.panelMain);
            this.groupControl2.Location = new System.Drawing.Point(446, 5);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(727, 651);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Đồ thị";
            // 
            // panelMain
            // 
            this.panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMain.AutoSize = true;
            this.panelMain.Location = new System.Drawing.Point(5, 32);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(717, 614);
            this.panelMain.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // FrmDijkstraDieuKhienChay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 662);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("FrmDijkstraDieuKhienChay.IconOptions.Image")));
            this.Name = "FrmDijkstraDieuKhienChay";
            this.Text = "Chương trình chạy";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmDijkstraDieuKhienChay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDelay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupSetting)).EndInit();
            this.groupSetting.ResumeLayout(false);
            this.groupSetting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxDinhKetThuc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxDinhXuatPhat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.PanelControl groupSetting;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.SimpleButton btnStart;
        private DevExpress.XtraEditors.SimpleButton btnBatDauChayTungBuoc;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btnKetThuc;
        private DevExpress.XtraEditors.SimpleButton btnTamDung;
        private DevExpress.XtraEditors.SimpleButton btnStartChayTuDong;
        private DevExpress.XtraEditors.TextEdit txtDelay;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnPrev;
        private DevExpress.XtraEditors.SimpleButton btnNext;
        private DevExpress.XtraEditors.SimpleButton btnEnd;
        private DevExpress.XtraEditors.PanelControl panelMain;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private DevExpress.XtraEditors.LookUpEdit cbxDinhKetThuc;
        private DevExpress.XtraEditors.LookUpEdit cbxDinhXuatPhat;
    }
}