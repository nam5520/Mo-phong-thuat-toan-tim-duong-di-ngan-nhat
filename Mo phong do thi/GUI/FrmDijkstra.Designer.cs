
namespace Mo_phong_do_thi.GUI
{
    partial class FrmDijkstra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDijkstra));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.dgvdsDinh = new DevExpress.XtraGrid.GridControl();
            this.dgvDsDinhMain = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.STT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenDinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.X = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Y = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoaDinh = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.dgvDsCanh = new DevExpress.XtraGrid.GridControl();
            this.dgvDsCanhMain = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Dinh1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Dinh2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TrongSo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LoaiCanh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnXoaCanh = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemCanh = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.panelMain = new DevExpress.XtraEditors.PanelControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.thêmĐỉnhVàoVịTríNàyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmCạnhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaTấtCảCácĐỉnhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnDong = new DevExpress.XtraEditors.SimpleButton();
            this.btnLoad = new DevExpress.XtraEditors.SimpleButton();
            this.btnDieuKhienChay = new DevExpress.XtraEditors.SimpleButton();
            this.btnLyThuyet = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdsDinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsDinhMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsCanh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsCanhMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelMain)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.dgvdsDinh);
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(498, 342);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Danh sách đỉnh";
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
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(9, 351);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(249, 45);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "Thêm đỉnh";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btnXoaDinh
            // 
            this.btnXoaDinh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaDinh.ImageOptions.Image")));
            this.btnXoaDinh.Location = new System.Drawing.Point(264, 351);
            this.btnXoaDinh.Name = "btnXoaDinh";
            this.btnXoaDinh.Size = new System.Drawing.Size(232, 45);
            this.btnXoaDinh.TabIndex = 2;
            this.btnXoaDinh.Text = "Xóa đỉnh";
            this.btnXoaDinh.Click += new System.EventHandler(this.btnXoaDinh_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.dgvDsCanh);
            this.groupControl2.Location = new System.Drawing.Point(4, 402);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(498, 376);
            this.groupControl2.TabIndex = 3;
            this.groupControl2.Text = "Danh sách cạnh";
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
            // btnXoaCanh
            // 
            this.btnXoaCanh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaCanh.ImageOptions.Image")));
            this.btnXoaCanh.Location = new System.Drawing.Point(264, 784);
            this.btnXoaCanh.Name = "btnXoaCanh";
            this.btnXoaCanh.Size = new System.Drawing.Size(232, 45);
            this.btnXoaCanh.TabIndex = 5;
            this.btnXoaCanh.Text = "Xóa cạnh";
            this.btnXoaCanh.Click += new System.EventHandler(this.btnXoaCanh_Click);
            // 
            // btnThemCanh
            // 
            this.btnThemCanh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThemCanh.ImageOptions.Image")));
            this.btnThemCanh.Location = new System.Drawing.Point(9, 784);
            this.btnThemCanh.Name = "btnThemCanh";
            this.btnThemCanh.Size = new System.Drawing.Size(249, 45);
            this.btnThemCanh.TabIndex = 4;
            this.btnThemCanh.Text = "Thêm cạnh";
            this.btnThemCanh.Click += new System.EventHandler(this.btnThemCanh_Click);
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.panelMain);
            this.groupControl3.Location = new System.Drawing.Point(508, 4);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(1404, 774);
            this.groupControl3.TabIndex = 6;
            this.groupControl3.Text = "Đồ thị Dijkstra";
            // 
            // panelMain
            // 
            this.panelMain.ContextMenuStrip = this.contextMenuStrip1;
            this.panelMain.Location = new System.Drawing.Point(6, 31);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1393, 738);
            this.panelMain.TabIndex = 0;
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
            // thêmĐỉnhVàoVịTríNàyToolStripMenuItem
            // 
            this.thêmĐỉnhVàoVịTríNàyToolStripMenuItem.Name = "thêmĐỉnhVàoVịTríNàyToolStripMenuItem";
            this.thêmĐỉnhVàoVịTríNàyToolStripMenuItem.Size = new System.Drawing.Size(236, 24);
            this.thêmĐỉnhVàoVịTríNàyToolStripMenuItem.Text = "Thêm đỉnh vào vị trí này";
            this.thêmĐỉnhVàoVịTríNàyToolStripMenuItem.Click += new System.EventHandler(this.thêmĐỉnhVàoVịTríNàyToolStripMenuItem_Click);
            // 
            // thêmCạnhToolStripMenuItem
            // 
            this.thêmCạnhToolStripMenuItem.Name = "thêmCạnhToolStripMenuItem";
            this.thêmCạnhToolStripMenuItem.Size = new System.Drawing.Size(236, 24);
            this.thêmCạnhToolStripMenuItem.Text = "Thêm cạnh";
            this.thêmCạnhToolStripMenuItem.Click += new System.EventHandler(this.thêmCạnhToolStripMenuItem_Click);
            // 
            // xóaTấtCảCácĐỉnhToolStripMenuItem
            // 
            this.xóaTấtCảCácĐỉnhToolStripMenuItem.Name = "xóaTấtCảCácĐỉnhToolStripMenuItem";
            this.xóaTấtCảCácĐỉnhToolStripMenuItem.Size = new System.Drawing.Size(236, 24);
            this.xóaTấtCảCácĐỉnhToolStripMenuItem.Text = "Xóa tất cả các đỉnh";
            this.xóaTấtCảCácĐỉnhToolStripMenuItem.Click += new System.EventHandler(this.xóaTấtCảCácĐỉnhToolStripMenuItem_Click);
            // 
            // btnSave
            // 
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.Location = new System.Drawing.Point(508, 784);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(280, 45);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Lưu đồ thị";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDong
            // 
            this.btnDong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.ImageOptions.Image")));
            this.btnDong.Location = new System.Drawing.Point(1648, 784);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(259, 45);
            this.btnDong.TabIndex = 8;
            this.btnDong.Text = "Đóng ứng dụng";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLoad.ImageOptions.Image")));
            this.btnLoad.Location = new System.Drawing.Point(794, 784);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(294, 45);
            this.btnLoad.TabIndex = 9;
            this.btnLoad.Text = "Load đồ thị";
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnDieuKhienChay
            // 
            this.btnDieuKhienChay.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDieuKhienChay.ImageOptions.Image")));
            this.btnDieuKhienChay.Location = new System.Drawing.Point(1094, 784);
            this.btnDieuKhienChay.Name = "btnDieuKhienChay";
            this.btnDieuKhienChay.Size = new System.Drawing.Size(276, 45);
            this.btnDieuKhienChay.TabIndex = 10;
            this.btnDieuKhienChay.Text = "Điều khiển chạy";
            this.btnDieuKhienChay.Click += new System.EventHandler(this.btnDieuKhienChay_Click);
            // 
            // btnLyThuyet
            // 
            this.btnLyThuyet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLyThuyet.ImageOptions.Image")));
            this.btnLyThuyet.Location = new System.Drawing.Point(1376, 784);
            this.btnLyThuyet.Name = "btnLyThuyet";
            this.btnLyThuyet.Size = new System.Drawing.Size(266, 45);
            this.btnLyThuyet.TabIndex = 11;
            this.btnLyThuyet.Text = "Lý thuyết thuật toán Dijkstra";
            this.btnLyThuyet.Click += new System.EventHandler(this.btnLyThuyet_Click);
            // 
            // FrmDijkstra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.btnLyThuyet);
            this.Controls.Add(this.btnDieuKhienChay);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.btnXoaCanh);
            this.Controls.Add(this.btnThemCanh);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.btnXoaDinh);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.groupControl1);
            this.Name = "FrmDijkstra";
            this.Size = new System.Drawing.Size(2000, 1000);
            this.Load += new System.EventHandler(this.FrmDijkstra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdsDinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsDinhMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsCanh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsCanhMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelMain)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl dgvdsDinh;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvDsDinhMain;
        private DevExpress.XtraGrid.Columns.GridColumn STT;
        private DevExpress.XtraGrid.Columns.GridColumn TenDinh;
        private DevExpress.XtraGrid.Columns.GridColumn X;
        private DevExpress.XtraGrid.Columns.GridColumn Y;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btnXoaDinh;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl dgvDsCanh;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvDsCanhMain;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn Dinh1;
        private DevExpress.XtraGrid.Columns.GridColumn Dinh2;
        private DevExpress.XtraGrid.Columns.GridColumn TrongSo;
        private DevExpress.XtraGrid.Columns.GridColumn LoaiCanh;
        private DevExpress.XtraEditors.SimpleButton btnXoaCanh;
        private DevExpress.XtraEditors.SimpleButton btnThemCanh;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnDong;
        private DevExpress.XtraEditors.SimpleButton btnLoad;
        private DevExpress.XtraEditors.SimpleButton btnDieuKhienChay;
        private DevExpress.XtraEditors.SimpleButton btnLyThuyet;
        private DevExpress.XtraEditors.PanelControl panelMain;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thêmĐỉnhVàoVịTríNàyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmCạnhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaTấtCảCácĐỉnhToolStripMenuItem;
    }
}
