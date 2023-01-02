
namespace Mo_phong_do_thi.GUI
{
    partial class FrmJohnson
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmJohnson));
            this.xóaTấtCảCácĐỉnhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmĐỉnhVàoVịTríNàyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.thêmCạnhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDieuKhienChay = new DevExpress.XtraEditors.SimpleButton();
            this.btnLoad = new DevExpress.XtraEditors.SimpleButton();
            this.btnDong = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.panelMain = new DevExpress.XtraEditors.PanelControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemCanh = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoaDinh = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemDinh = new DevExpress.XtraEditors.SimpleButton();
            this.LoaiCanh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TrongSo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Dinh2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Dinh1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dgvDsCanhMain = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.dgvDsCanh = new DevExpress.XtraGrid.GridControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.Y = new DevExpress.XtraGrid.Columns.GridColumn();
            this.X = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenDinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.STT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dgvDsDinhMain = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.dgvdsDinh = new DevExpress.XtraGrid.GridControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnLyThuyet = new DevExpress.XtraEditors.SimpleButton();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsCanhMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsCanh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsDinhMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdsDinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // xóaTấtCảCácĐỉnhToolStripMenuItem
            // 
            this.xóaTấtCảCácĐỉnhToolStripMenuItem.Name = "xóaTấtCảCácĐỉnhToolStripMenuItem";
            this.xóaTấtCảCácĐỉnhToolStripMenuItem.Size = new System.Drawing.Size(236, 24);
            this.xóaTấtCảCácĐỉnhToolStripMenuItem.Text = "Xóa tất cả các đỉnh";
            this.xóaTấtCảCácĐỉnhToolStripMenuItem.Click += new System.EventHandler(this.xóaTấtCảCácĐỉnhToolStripMenuItem_Click);
            // 
            // thêmĐỉnhVàoVịTríNàyToolStripMenuItem
            // 
            this.thêmĐỉnhVàoVịTríNàyToolStripMenuItem.Name = "thêmĐỉnhVàoVịTríNàyToolStripMenuItem";
            this.thêmĐỉnhVàoVịTríNàyToolStripMenuItem.Size = new System.Drawing.Size(236, 24);
            this.thêmĐỉnhVàoVịTríNàyToolStripMenuItem.Text = "Thêm đỉnh vào vị trí này";
            this.thêmĐỉnhVàoVịTríNàyToolStripMenuItem.Click += new System.EventHandler(this.thêmĐỉnhVàoVịTríNàyToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmĐỉnhVàoVịTríNàyToolStripMenuItem,
            this.thêmCạnhToolStripMenuItem,
            this.xóaTấtCảCácĐỉnhToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(237, 76);
            // 
            // thêmCạnhToolStripMenuItem
            // 
            this.thêmCạnhToolStripMenuItem.Name = "thêmCạnhToolStripMenuItem";
            this.thêmCạnhToolStripMenuItem.Size = new System.Drawing.Size(236, 24);
            this.thêmCạnhToolStripMenuItem.Text = "Thêm cạnh";
            this.thêmCạnhToolStripMenuItem.Click += new System.EventHandler(this.thêmCạnhToolStripMenuItem_Click);
            // 
            // btnDieuKhienChay
            // 
            this.btnDieuKhienChay.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDieuKhienChay.ImageOptions.Image")));
            this.btnDieuKhienChay.Location = new System.Drawing.Point(1097, 783);
            this.btnDieuKhienChay.Name = "btnDieuKhienChay";
            this.btnDieuKhienChay.Size = new System.Drawing.Size(276, 45);
            this.btnDieuKhienChay.TabIndex = 27;
            this.btnDieuKhienChay.Text = "Điều khiển chạy";
            this.btnDieuKhienChay.Click += new System.EventHandler(this.btnDieuKhienChay_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLoad.ImageOptions.Image")));
            this.btnLoad.Location = new System.Drawing.Point(797, 783);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(294, 45);
            this.btnLoad.TabIndex = 26;
            this.btnLoad.Text = "Load đồ thị";
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnDong
            // 
            this.btnDong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.ImageOptions.Image")));
            this.btnDong.Location = new System.Drawing.Point(1651, 783);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(254, 45);
            this.btnDong.TabIndex = 25;
            this.btnDong.Text = "Đóng ứng dụng";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnSave
            // 
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.Location = new System.Drawing.Point(511, 783);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(280, 45);
            this.btnSave.TabIndex = 24;
            this.btnSave.Text = "Lưu đồ thị";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panelMain
            // 
            this.panelMain.ContextMenuStrip = this.contextMenuStrip1;
            this.panelMain.Location = new System.Drawing.Point(6, 31);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1393, 738);
            this.panelMain.TabIndex = 0;
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.panelMain);
            this.groupControl3.Location = new System.Drawing.Point(506, 3);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(1404, 774);
            this.groupControl3.TabIndex = 23;
            this.groupControl3.Text = "Đồ thị Johnson";
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(263, 783);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(232, 45);
            this.simpleButton2.TabIndex = 22;
            this.simpleButton2.Text = "Xóa cạnh";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // btnThemCanh
            // 
            this.btnThemCanh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThemCanh.ImageOptions.Image")));
            this.btnThemCanh.Location = new System.Drawing.Point(8, 783);
            this.btnThemCanh.Name = "btnThemCanh";
            this.btnThemCanh.Size = new System.Drawing.Size(249, 45);
            this.btnThemCanh.TabIndex = 21;
            this.btnThemCanh.Text = "Thêm cạnh";
            this.btnThemCanh.Click += new System.EventHandler(this.btnThemCanh_Click);
            // 
            // btnXoaDinh
            // 
            this.btnXoaDinh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaDinh.ImageOptions.Image")));
            this.btnXoaDinh.Location = new System.Drawing.Point(263, 350);
            this.btnXoaDinh.Name = "btnXoaDinh";
            this.btnXoaDinh.Size = new System.Drawing.Size(232, 45);
            this.btnXoaDinh.TabIndex = 20;
            this.btnXoaDinh.Text = "Xóa đỉnh";
            this.btnXoaDinh.Click += new System.EventHandler(this.btnXoaDinh_Click);
            // 
            // btnThemDinh
            // 
            this.btnThemDinh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThemDinh.ImageOptions.Image")));
            this.btnThemDinh.Location = new System.Drawing.Point(8, 350);
            this.btnThemDinh.Name = "btnThemDinh";
            this.btnThemDinh.Size = new System.Drawing.Size(249, 45);
            this.btnThemDinh.TabIndex = 19;
            this.btnThemDinh.Text = "Thêm đỉnh";
            this.btnThemDinh.Click += new System.EventHandler(this.btnThemDinh_Click);
            // 
            // LoaiCanh
            // 
            this.LoaiCanh.Caption = "Loại Cạnh";
            this.LoaiCanh.FieldName = "LoaiCanh";
            this.LoaiCanh.MinWidth = 25;
            this.LoaiCanh.Name = "LoaiCanh";
            this.LoaiCanh.Visible = true;
            this.LoaiCanh.VisibleIndex = 4;
            this.LoaiCanh.Width = 87;
            // 
            // TrongSo
            // 
            this.TrongSo.Caption = "Trọng Số";
            this.TrongSo.FieldName = "TrongSo";
            this.TrongSo.MinWidth = 25;
            this.TrongSo.Name = "TrongSo";
            this.TrongSo.Visible = true;
            this.TrongSo.VisibleIndex = 3;
            this.TrongSo.Width = 117;
            // 
            // Dinh2
            // 
            this.Dinh2.Caption = "Đỉnh 2";
            this.Dinh2.FieldName = "Dinh2";
            this.Dinh2.MinWidth = 25;
            this.Dinh2.Name = "Dinh2";
            this.Dinh2.Visible = true;
            this.Dinh2.VisibleIndex = 2;
            this.Dinh2.Width = 111;
            // 
            // Dinh1
            // 
            this.Dinh1.Caption = "Đỉnh 1";
            this.Dinh1.FieldName = "Dinh1";
            this.Dinh1.MinWidth = 25;
            this.Dinh1.Name = "Dinh1";
            this.Dinh1.Visible = true;
            this.Dinh1.VisibleIndex = 1;
            this.Dinh1.Width = 94;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "STT";
            this.gridColumn1.FieldName = "STT";
            this.gridColumn1.MinWidth = 25;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 48;
            // 
            // dgvDsCanhMain
            // 
            this.dgvDsCanhMain.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.Dinh1,
            this.Dinh2,
            this.TrongSo,
            this.LoaiCanh});
            this.dgvDsCanhMain.GridControl = this.dgvDsCanh;
            this.dgvDsCanhMain.Name = "dgvDsCanhMain";
            this.dgvDsCanhMain.OptionsView.ShowGroupPanel = false;
            // 
            // dgvDsCanh
            // 
            this.dgvDsCanh.Location = new System.Drawing.Point(6, 32);
            this.dgvDsCanh.MainView = this.dgvDsCanhMain;
            this.dgvDsCanh.Name = "dgvDsCanh";
            this.dgvDsCanh.Size = new System.Drawing.Size(487, 339);
            this.dgvDsCanh.TabIndex = 0;
            this.dgvDsCanh.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvDsCanhMain});
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.dgvDsCanh);
            this.groupControl2.Location = new System.Drawing.Point(2, 401);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(498, 376);
            this.groupControl2.TabIndex = 18;
            this.groupControl2.Text = "Danh sách cạnh";
            // 
            // Y
            // 
            this.Y.Caption = "Tung độ";
            this.Y.FieldName = "Y";
            this.Y.MinWidth = 25;
            this.Y.Name = "Y";
            this.Y.Visible = true;
            this.Y.VisibleIndex = 3;
            this.Y.Width = 110;
            // 
            // X
            // 
            this.X.Caption = "Hoành độ";
            this.X.FieldName = "X";
            this.X.MinWidth = 25;
            this.X.Name = "X";
            this.X.Visible = true;
            this.X.VisibleIndex = 2;
            this.X.Width = 104;
            // 
            // TenDinh
            // 
            this.TenDinh.Caption = "Tên Đỉnh";
            this.TenDinh.FieldName = "TenDinh";
            this.TenDinh.MinWidth = 25;
            this.TenDinh.Name = "TenDinh";
            this.TenDinh.Visible = true;
            this.TenDinh.VisibleIndex = 1;
            this.TenDinh.Width = 184;
            // 
            // STT
            // 
            this.STT.Caption = "STT";
            this.STT.FieldName = "STT";
            this.STT.MinWidth = 25;
            this.STT.Name = "STT";
            this.STT.Visible = true;
            this.STT.VisibleIndex = 0;
            this.STT.Width = 59;
            // 
            // dgvDsDinhMain
            // 
            this.dgvDsDinhMain.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.STT,
            this.TenDinh,
            this.X,
            this.Y});
            this.dgvDsDinhMain.GridControl = this.dgvdsDinh;
            this.dgvDsDinhMain.Name = "dgvDsDinhMain";
            this.dgvDsDinhMain.OptionsView.ShowGroupPanel = false;
            // 
            // dgvdsDinh
            // 
            this.dgvdsDinh.Location = new System.Drawing.Point(6, 32);
            this.dgvdsDinh.MainView = this.dgvDsDinhMain;
            this.dgvdsDinh.Name = "dgvdsDinh";
            this.dgvdsDinh.Size = new System.Drawing.Size(487, 305);
            this.dgvdsDinh.TabIndex = 0;
            this.dgvdsDinh.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvDsDinhMain});
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.dgvdsDinh);
            this.groupControl1.Location = new System.Drawing.Point(2, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(498, 342);
            this.groupControl1.TabIndex = 17;
            this.groupControl1.Text = "Danh sách đỉnh";
            // 
            // btnLyThuyet
            // 
            this.btnLyThuyet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLyThuyet.ImageOptions.Image")));
            this.btnLyThuyet.Location = new System.Drawing.Point(1379, 783);
            this.btnLyThuyet.Name = "btnLyThuyet";
            this.btnLyThuyet.Size = new System.Drawing.Size(266, 45);
            this.btnLyThuyet.TabIndex = 28;
            this.btnLyThuyet.Text = "Lý thuyết thuật toán Johnson";
            this.btnLyThuyet.Click += new System.EventHandler(this.btnLyThuyet_Click);
            // 
            // FrmJohnson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnLyThuyet);
            this.Controls.Add(this.btnDieuKhienChay);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.btnThemCanh);
            this.Controls.Add(this.btnXoaDinh);
            this.Controls.Add(this.btnThemDinh);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "FrmJohnson";
            this.Size = new System.Drawing.Size(2000, 1000);
            this.Load += new System.EventHandler(this.FrmJohnson_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsCanhMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsCanh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsDinhMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdsDinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem xóaTấtCảCácĐỉnhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmĐỉnhVàoVịTríNàyToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thêmCạnhToolStripMenuItem;
        private DevExpress.XtraEditors.SimpleButton btnDieuKhienChay;
        private DevExpress.XtraEditors.SimpleButton btnLoad;
        private DevExpress.XtraEditors.SimpleButton btnDong;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.PanelControl panelMain;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton btnThemCanh;
        private DevExpress.XtraEditors.SimpleButton btnXoaDinh;
        private DevExpress.XtraEditors.SimpleButton btnThemDinh;
        private DevExpress.XtraGrid.Columns.GridColumn LoaiCanh;
        private DevExpress.XtraGrid.Columns.GridColumn TrongSo;
        private DevExpress.XtraGrid.Columns.GridColumn Dinh2;
        private DevExpress.XtraGrid.Columns.GridColumn Dinh1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvDsCanhMain;
        private DevExpress.XtraGrid.GridControl dgvDsCanh;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.Columns.GridColumn Y;
        private DevExpress.XtraGrid.Columns.GridColumn X;
        private DevExpress.XtraGrid.Columns.GridColumn TenDinh;
        private DevExpress.XtraGrid.Columns.GridColumn STT;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvDsDinhMain;
        private DevExpress.XtraGrid.GridControl dgvdsDinh;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnLyThuyet;
    }
}
