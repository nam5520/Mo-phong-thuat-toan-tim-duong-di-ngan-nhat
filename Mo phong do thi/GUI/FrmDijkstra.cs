using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mo_phong_do_thi.GUI
{
    public partial class FrmDijkstra : DevExpress.XtraEditors.XtraUserControl
    {
        public FrmDijkstra()
        {
            InitializeComponent();
        }
        private void LoadDgvDinh()
        {
            int i = 1;
            dgvdsDinh.DataSource = Data.Data.graph_Dijkstra.dsDinh
                                   .Select(p => new
                                   {
                                       ID = p.ID,
                                       STT = i++,
                                       TenDinh = p.Ten,
                                       X = p.x,
                                       Y = p.y
                                   })
                                   .ToList();
        }
        private void LoadDgvCanh()
        {
            int i = 1;
            dgvDsCanh.DataSource = Data.Data.graph_Dijkstra.dsCanh.ToList()
                                   .Select(p => new
                                   {
                                       ID = p.ID,
                                       STT = i++,
                                       Dinh1 = Data.Data.graph_Dijkstra.dsDinh.Where(z => z.ID == p.IDXP).FirstOrDefault().Ten,
                                       Dinh2 = Data.Data.graph_Dijkstra.dsDinh.Where(z => z.ID == p.IDKT).FirstOrDefault().Ten,
                                       TrongSo = p.TrongSo,
                                       LoaiCanh = (p.LoaiCanh == 0) ? "Cạnh 2 chiều" : "Cạnh 1 chiều"
                                   })
                                   .ToList();
        }
        private void HienThiDoThi()
        {
            panelMain.Controls.Clear();
            FrmVeDoThi vedothi = new FrmVeDoThi(Data.Data.graph_Dijkstra);
            vedothi.Dock = DockStyle.Fill;
            panelMain.Controls.Add(vedothi);
            vedothi.Show();
        }
        private void Loadz()
        {
            LoadDgvDinh();
            LoadDgvCanh();
            HienThiDoThi();
        }

        private void FrmDijkstra_Load(object sender, EventArgs e)
        {
            Loadz();
        }

        private void btnThemCanh_Click(object sender, EventArgs e)
        {
            FrmDijkstraThemCanh form = new FrmDijkstraThemCanh();
            form.ShowDialog();
            Loadz();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            FrmDijkstraThemDinh form = new FrmDijkstraThemDinh();
            form.ShowDialog();
            Loadz();
        }

        private void btnXoaDinh_Click(object sender, EventArgs e)
        {
            int id = 0;
            try
            {

                id = (int)dgvDsDinhMain.GetFocusedRowCellValue("ID");
                DialogResult rs = MessageBox.Show("Bạn có chắc chắn xóa đỉnh này?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (rs == DialogResult.Cancel) return;
                Data.Data.graph_Dijkstra.dsDinh.RemoveAll(p => p.ID == id);
                Data.Data.graph_Dijkstra.dsCanh.RemoveAll(p => p.IDXP == id || p.IDKT == id);
                MessageBox.Show("Xóa đỉnh thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Loadz();
            }
            catch
            {
                if (id == 0)
                {
                    MessageBox.Show("Chưa có đỉnh nào được chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void btnXoaCanh_Click(object sender, EventArgs e)
        {
            if (Data.Data.graph_Dijkstra.dsDinh.Count == 0)
            {
                MessageBox.Show("Danh sách cạnh đang trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            DialogResult rs = MessageBox.Show("Bạn có chắc chắn xóa cạnh này?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (rs == DialogResult.Cancel) return;

            int id = 0;
            try
            {
                id = (int)dgvDsCanhMain.GetFocusedRowCellValue("ID");
                Data.Data.graph_Dijkstra.dsCanh.RemoveAll(p => p.ID == id);
                MessageBox.Show("Xóa cạnh thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Loadz();
            }
            catch
            {
                MessageBox.Show("Chưa có cạnh nào được chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog file = new SaveFileDialog();
            file.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            if (file.ShowDialog() == DialogResult.OK)
            {
                string FileName = file.FileName;
                Data.Data.graph_Dijkstra.WriteFile(FileName);
                Loadz();
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            if (file.ShowDialog() == DialogResult.OK)
            {
                string FileName = file.FileName;
                Data.Data.graph_Dijkstra.ReadFile(FileName);
                Loadz();
            }
        }

        private void btnLyThuyet_Click(object sender, EventArgs e)
        {
            FrmDijkstraLyThuyet form = new FrmDijkstraLyThuyet();
            form.ShowDialog();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }
        private void btnDieuKhienChay_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            FormCollection fc = Application.OpenForms;
            foreach (Form f in fc)
            {
                if (f.Name == "FrmDijkstraDieuKhienChay")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (IsOpen == false)
            {
                FrmDijkstraDieuKhienChay form = new FrmDijkstraDieuKhienChay();
                form.Show();
            }
        }
        #region contextmenu
        private void thêmĐỉnhVàoVịTríNàyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int tdx = panelMain.PointToClient(MousePosition).X;
            int tdy = panelMain.PointToClient(MousePosition).Y;
            FrmDijkstraThemDinh form = new FrmDijkstraThemDinh(tdx, tdy);
            form.ShowDialog();
            Loadz();
        }
        private void thêmCạnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDijkstraThemCanh form = new FrmDijkstraThemCanh();
            form.ShowDialog();
            Loadz();
        }
        private void xóaTấtCảCácĐỉnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có chắc chắn xóa tất cả đồ thị?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (rs == DialogResult.Cancel) return;
            Data.Data.graph_Dijkstra.dsDinh.Clear();
            Data.Data.graph_Dijkstra.dsCanh.Clear();
            Loadz();
        }
        #endregion
    }
}
