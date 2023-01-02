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
    public partial class FrmFloyd : DevExpress.XtraEditors.XtraUserControl
    {
        public FrmFloyd()
        {
            InitializeComponent();
        }
        private void LoadDgvDinh()
        {
            int i = 1;
            dgvdsDinh.DataSource = Data.Data.graph_Floyd.dsDinh
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
            dgvDsCanh.DataSource = Data.Data.graph_Floyd.dsCanh.ToList()
                                   .Select(p => new
                                   {
                                       ID = p.ID,
                                       STT = i++,
                                       Dinh1 = Data.Data.graph_Floyd.dsDinh.Where(z => z.ID == p.IDXP).FirstOrDefault().Ten,
                                       Dinh2 = Data.Data.graph_Floyd.dsDinh.Where(z => z.ID == p.IDKT).FirstOrDefault().Ten,
                                       TrongSo = p.TrongSo,
                                       LoaiCanh = (p.LoaiCanh == 0) ? "Cạnh 2 chiều" : "Cạnh 1 chiều"
                                   })
                                   .ToList();
        }
        private void HienThiDoThi()
        {
            panelMain.Controls.Clear();
            FrmVeDoThi vedothi = new FrmVeDoThi(Data.Data.graph_Floyd);
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

        private void FrmFloyd_Load(object sender, EventArgs e)
        {
            Loadz();
        }

        private void btnThemDinh_Click(object sender, EventArgs e)
        {
            FrmFloydThemDinh form = new FrmFloydThemDinh();
            form.ShowDialog();
            Loadz();
        }

        private void btnThemCanh_Click(object sender, EventArgs e)
        {
            FrmFloydThemCanh form = new FrmFloydThemCanh();
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
                Data.Data.graph_Floyd.dsDinh.RemoveAll(p => p.ID == id);
                Data.Data.graph_Floyd.dsCanh.RemoveAll(p => p.IDXP == id || p.IDKT == id);
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
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (Data.Data.graph_Floyd.dsDinh.Count == 0)
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
                Data.Data.graph_Floyd.dsCanh.RemoveAll(p => p.ID == id);
                MessageBox.Show("Xóa cạnh thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Loadz();
            }
            catch
            {
                MessageBox.Show("Chưa có cạnh nào được chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnDieuKhienChay_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            FormCollection fc = Application.OpenForms;
            foreach (Form f in fc)
            {
                if (f.Name == "FormFloydDieuKhienChay")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (IsOpen == false)
            {
                FormFloydDieuKhienChay form = new FormFloydDieuKhienChay();
                form.Show();
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog file = new SaveFileDialog();
            file.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            if (file.ShowDialog() == DialogResult.OK)
            {
                string FileName = file.FileName;
                Data.Data.graph_Floyd.WriteFile(FileName);
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
                Data.Data.graph_Floyd.ReadFile(FileName);
                Loadz();
            }
        }

        private void btnLyThuyet_Click(object sender, EventArgs e)
        {
            FrmFloydLyThuyet frm = new FrmFloydLyThuyet();
            frm.ShowDialog();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }
        #region contextmenu
        private void thêmĐỉnhVàoVịTríNàyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int tdx = panelMain.PointToClient(MousePosition).X;
            int tdy = panelMain.PointToClient(MousePosition).Y;
            FrmFloydThemDinh form = new FrmFloydThemDinh(tdx, tdy);
            form.ShowDialog();
            Loadz();
        }
        private void thêmCạnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFloydThemCanh form = new FrmFloydThemCanh();
            form.ShowDialog();
            Loadz();
        }
        private void xóaTấtCảCácĐỉnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có chắc chắn xóa tất cả đồ thị?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (rs == DialogResult.Cancel) return;
            Data.Data.graph_Floyd.dsDinh.Clear();
            Data.Data.graph_Floyd.dsCanh.Clear();
            Loadz();
        }
        #endregion
    }
}
