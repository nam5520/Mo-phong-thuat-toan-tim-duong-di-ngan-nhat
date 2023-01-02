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
    public partial class FrmFloydThemCanh : DevExpress.XtraEditors.XtraForm
    {
        public FrmFloydThemCanh()
        {
            InitializeComponent();
        }

        private void LoadInitControl()
        {
            List<Dinh> xp = Data.Data.graph_Floyd.dsDinh.ToList();
            // cbx Dinh Xuat Phat
            cbxDinhXP.Properties.DataSource = xp;
            cbxDinhXP.Properties.DisplayMember = "Ten";
            cbxDinhXP.Properties.ValueMember = "ID";

            List<Dinh> kt = Data.Data.graph_Floyd.dsDinh.ToList();
            // cbx Dinh Ket Thuc
            cbxDinhKT.Properties.DataSource = kt;
            cbxDinhKT.Properties.DisplayMember = "Ten";
            cbxDinhKT.Properties.ValueMember = "ID";
            cbxLoaiCanh.Properties.Items.Add("Cạnh một chiều");
            cbxLoaiCanh.Properties.Items.Add("Cạnh hai chiều");
            cbxLoaiCanh.Text = "Cạnh hai chiều";
        }

        private void FrmFloydThemCanh_Load(object sender, EventArgs e)
        {
            LoadInitControl();
        }
        #region Hàm chức năng
        private bool Check()
        {
            if (Data.Data.graph_Floyd.dsDinh.Count == 0)
            {
                MessageBox.Show("Danh sách đỉnh đang trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if ((int)cbxDinhKT.EditValue == (int)cbxDinhXP.EditValue)
            {
                MessageBox.Show("Đình xuất phát không được trùng đỉnh kết thúc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                int LoaiCanh = (cbxLoaiCanh.Text == "Cạnh hai chiều") ? 0 : 1;
                int cnt = Data.Data.graph_Floyd.dsCanh.Count;
                if (cnt == 0) canh.ID = 1;
                else canh.ID = Data.Data.graph_Floyd.dsCanh[cnt - 1].ID + 1;

                canh.IDXP = (int)cbxDinhXP.EditValue;
                canh.IDKT = (int)cbxDinhKT.EditValue;
                canh.x1 = Data.Data.graph_Floyd.dsDinh.Where(p => p.ID == canh.IDXP).FirstOrDefault().x;
                canh.y1 = Data.Data.graph_Floyd.dsDinh.Where(p => p.ID == canh.IDXP).FirstOrDefault().y;
                canh.x2 = Data.Data.graph_Floyd.dsDinh.Where(p => p.ID == canh.IDKT).FirstOrDefault().x;
                canh.y2 = Data.Data.graph_Floyd.dsDinh.Where(p => p.ID == canh.IDKT).FirstOrDefault().y;
                canh.TrongSo = Int32.Parse(txtTrongSo.Text);
                canh.mau = Color.Black;
                canh.LoaiCanh = LoaiCanh;

                Data.Data.graph_Floyd.dsCanh.Add(canh);
                if (KTChuTrinhAm.isNegCycleBellmanFord(Data.Data.graph_Floyd))
                {
                    MessageBox.Show("Đồ thị có chu trình ầm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Data.Data.graph_Floyd.dsCanh.RemoveAll(p => p.ID == canh.ID);
                }
                else
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