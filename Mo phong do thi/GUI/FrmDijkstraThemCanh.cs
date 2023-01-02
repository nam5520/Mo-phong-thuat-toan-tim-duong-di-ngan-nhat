using DevExpress.XtraEditors;
using Mo_phong_do_thi.Model;
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
    public partial class FrmDijkstraThemCanh : DevExpress.XtraEditors.XtraForm
    {
        public FrmDijkstraThemCanh()
        {
            InitializeComponent();
        }
        #region LoadForm
        private void LoadInitControl()
        {
            List<Dinh> xp = Data.Data.graph_Dijkstra.dsDinh.ToList();
            // cbx Dinh Xuat Phat
            cbxDinhXP.Properties.DataSource = xp;
            cbxDinhXP.Properties.DisplayMember = "Ten";
            cbxDinhXP.Properties.ValueMember = "ID";

            List<Dinh> kt = Data.Data.graph_Dijkstra.dsDinh.ToList();
            // cbx Dinh Ket Thuc
            cbxDinhKT.Properties.DataSource = kt;
            cbxDinhKT.Properties.DisplayMember = "Ten";
            cbxDinhKT.Properties.ValueMember = "ID";
            cbxLoaiCanh.Properties.Items.Add("Cạnh một chiều");
            cbxLoaiCanh.Properties.Items.Add("Cạnh hai chiều");
            cbxLoaiCanh.Text = "Cạnh hai chiều";
        }
        #endregion
        private void FrmDijkstraThemCanh_Load(object sender, EventArgs e)
        {
            LoadInitControl();
        }
        #region Hàm chức năng
        private bool Check()
        {
            if (Data.Data.graph_Dijkstra.dsDinh.Count == 0)
            {
                MessageBox.Show("Danh sách đỉnh đang trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if ((int)cbxDinhKT.EditValue == (int)cbxDinhXP.EditValue)
            {
                MessageBox.Show("Đình xuất phát không được trùng đỉnh kết thúc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            bool ok;
            try
            {
                int ts = Int32.Parse(txtTrongSo.Text);
                if (ts > 0) ok = true; else ok = false;
            }
            catch
            {
                ok = false;
            }
            if (!ok)
            {
                MessageBox.Show("Trọng số của cạnh phải là số nguyên dương", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        #endregion

        #region sự kiện
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (Check())
            {
                Canh canh = new Canh();
                int TrongSo = (cbxLoaiCanh.Text == "Cạnh hai chiều") ? 0 : 1;
                int cnt = Data.Data.graph_Dijkstra.dsCanh.Count;
                if (cnt == 0) canh.ID = 1;
                else canh.ID = Data.Data.graph_Dijkstra.dsCanh[cnt - 1].ID + 1;

                canh.IDXP = (int)cbxDinhXP.EditValue;
                canh.IDKT = (int)cbxDinhKT.EditValue;
                canh.x1 = Data.Data.graph_Dijkstra.dsDinh.Where(p => p.ID == canh.IDXP).FirstOrDefault().x;
                canh.y1 = Data.Data.graph_Dijkstra.dsDinh.Where(p => p.ID == canh.IDXP).FirstOrDefault().y;
                canh.x2 = Data.Data.graph_Dijkstra.dsDinh.Where(p => p.ID == canh.IDKT).FirstOrDefault().x;
                canh.y2 = Data.Data.graph_Dijkstra.dsDinh.Where(p => p.ID == canh.IDKT).FirstOrDefault().y;
                canh.TrongSo = Int32.Parse(txtTrongSo.Text);
                canh.mau = Color.Black;
                canh.LoaiCanh = TrongSo;

                Data.Data.graph_Dijkstra.dsCanh.Add(canh);
                MessageBox.Show("Thêm cạnh thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                return;
            }
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion


    }
}