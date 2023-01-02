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
    public partial class FrmDijkstraThemDinh : DevExpress.XtraEditors.XtraForm
    {
        public FrmDijkstraThemDinh()
        {
            InitializeComponent();
            x = -1;
            y = -1;
        }
        private int x, y;
        #region constructor
        public FrmDijkstraThemDinh(int _x, int _y)
        {
            InitializeComponent();
            x = _x;
            y = _y;
        }
        #endregion

        #region hàm chức năng
        private bool Check()
        {
            if (txtTenDinh.Text == "")
            {
                MessageBox.Show("Tên đỉnh không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            bool ok;

            try
            {
                int ts = Int32.Parse(txtX.Text);
                ok = true;
            }
            catch
            {
                ok = false;
            }
            if (!ok)
            {
                MessageBox.Show("Tọa độ của X phải là số nguyên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            try
            {
                int ts = Int32.Parse(txtY.Text);
                ok = true;
            }
            catch
            {
                ok = false;
            }
            if (!ok)
            {
                MessageBox.Show("Tọa độ của Y phải là số nguyên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


            return true;
        }



        private void ThemDinh()
        {
            if (Check())
            {
                Dinh dinh = new Dinh();
                dinh.mau = Color.Green;
                dinh.Ten = txtTenDinh.Text;
                dinh.x = Int32.Parse(txtX.Text);
                dinh.y = Int32.Parse(txtY.Text);
                //string m =(string)"D[" + dinh.Ten + "]=0 ";
                //dinh.ThongTinThem= m;

                int count = Data.Data.graph_Dijkstra.dsDinh.Count;
                if (count == 0) dinh.ID = 1; else dinh.ID = Data.Data.graph_Dijkstra.dsDinh[count - 1].ID + 1;
                Data.Data.graph_Dijkstra.AddDinh(dinh);
                MessageBox.Show("Thêm đỉnh thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        #endregion

        #region sự kiện

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            ThemDinh();
        }

        private void btnHuy_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region LoadForm
        private void FrmDijkstraThemDinh_Load_1(object sender, EventArgs e)
        {
            if (this.x == -1 && this.y == -1)
            {
                Random rand = new Random();
                txtX.Text = rand.Next(1, 900).ToString();
                txtY.Text = rand.Next(1, 500).ToString();
                return;
            }

            txtX.Text = this.x.ToString();
            txtY.Text = this.y.ToString();
        }
        #endregion
    }

}