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
    public partial class FrmJohonsonDieuKhienChay : DevExpress.XtraEditors.XtraForm
    {
        private List<DoThi> listDoThi = new List<DoThi>();
        private int index = 0;
        public FrmJohonsonDieuKhienChay()
        {
            InitializeComponent();
        }
        private void LoadDgvDinh()
        {
            dataGridView1.ColumnCount = Data.Data.graph_Johnson.dsDinh.Count + 1;
            dataGridView1.Columns[0].Name = "Đỉnh nguồn";
            dataGridView1.Columns[0].Width = 110;
            for (int i = 1; i < Data.Data.graph_Johnson.dsDinh.Count + 1; i++)
            {
                dataGridView1.Columns[i].Name = Data.Data.graph_Johnson.dsDinh[i - 1].Ten;
            }
        }
        private void LoadInitControl()
        {
            ///  cbx Xuat Phat
            cbxDinhXuatPhat.Properties.DataSource = Data.Data.graph_Johnson.dsDinh.ToList();
            cbxDinhXuatPhat.Properties.DisplayMember = "Ten";
            cbxDinhXuatPhat.Properties.ValueMember = "ID";

            // cbx ket thuc
            cbxDinhKetThuc.Properties.DataSource = Data.Data.graph_Johnson.dsDinh.ToList();
            cbxDinhKetThuc.Properties.DisplayMember = "Ten";
            cbxDinhKetThuc.Properties.ValueMember = "ID";

            // chạy tự động
            btnTamDung.Enabled = false;
            btnKetThuc.Enabled = false;

            // chạy từng bước
            btnStart.Enabled = false;
            btnEnd.Enabled = false;
            btnPrev.Enabled = false;
            btnNext.Enabled = false;
        }
        private void OnLoad()
        {
            this.Location = new Point(-1033, 55);
            timer2.Enabled = true;
            LoadDgvDinh();
            timer2.Start();
        }
        private void FrmJohonsonDieuKhienChay_Load(object sender, EventArgs e)
        {
            OnLoad();
            LoadInitControl();
            index = 0;
        }
        private void HienThiDoThi()
        {
            try
            {
                DoThi dt = listDoThi[index];
                panelMain.Controls.Clear();
                FrmVeDoThi ve = new FrmVeDoThi(dt);
                ve.Dock = DockStyle.Fill;
                panelMain.Controls.Add(ve);
                ve.Show();
                dataGridView1.Rows.Clear();
                const int oo = (int)1e9;
                string[] row = new string[100];
                //if (index == listDoThi.Count - 1) timer.Stop();
                if(index == listDoThi.Count-1)
                for (int i = 0; i < Data.Data.graph_Johnson.dsDinh.Count; i++)
                {
                    row[0] = dt.dsDinh[i].Ten;
                    for (int j = 0; j < dt.dsDinh.Count; j++)
                    {
                        if (dt.TrongSo[i, j] == oo)
                        {
                            row[j + 1] = "+oo";
                        }
                        else
                            row[j + 1] = dt.TrongSo[i, j].ToString();
                    }
                    dataGridView1.Rows.Add(row);
                }
            }
            catch
            {

            }
        }
        private bool Check()
        {
            if (Data.Data.graph_Johnson.dsDinh.Count == 0)
            {
                MessageBox.Show("Đồ thị chưa có đỉnh nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            try
            {
                int S = (int)cbxDinhXuatPhat.EditValue;
                int T = (int)cbxDinhKetThuc.EditValue;

                if (S == T)
                {
                    MessageBox.Show("Đỉnh kết thúc không được trùng với đỉnh bắt đầu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch
            {
                MessageBox.Show("Chưa có đỉnh nào được chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        private void btnStartChayTuDong_Click(object sender, EventArgs e)
        {
            if (Check())
            {
                // kiểm tra time delay
                int timeDelay = 0;
                try
                {
                    timeDelay = Int32.Parse(txtDelay.Text);
                    if (timeDelay < 0)
                    {
                        MessageBox.Show("Thời gian delay phải là số nguyên dương", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                catch
                {
                    MessageBox.Show("Time delay phải là số nguyên dương", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                this.Bounds = Screen.PrimaryScreen.Bounds;
                btnTamDung.Enabled = true;
                btnKetThuc.Enabled = true;
                btnBatDauChayTungBuoc.Enabled = false;
                groupSetting.Enabled = false;

                listDoThi = Johnson.Run(Data.Data.graph_Johnson, (int)cbxDinhXuatPhat.EditValue, (int)cbxDinhKetThuc.EditValue);
                index = 0;
                timer1.Enabled = true;
                timer1.Interval = timeDelay;
                timer1.Start();
                return;
            }
        }
        private void btnTamDung_Click(object sender, EventArgs e)
        {
            if (btnTamDung.Text == "Tạm dừng")
            {
                btnTamDung.Text = "Tiếp tục";
                timer1.Stop();
                return;
            }

            if (btnTamDung.Text == "Tiếp tục")
            {
                btnTamDung.Text = "Tạm dừng";
                timer1.Start();
                return;
            }
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            index = listDoThi.Count - 1;
            HienThiDoThi();
            timer1.Stop();

            btnBatDauChayTungBuoc.Enabled = true;
            btnKetThuc.Enabled = false;
            btnTamDung.Enabled = false;
            groupSetting.Enabled = true;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (listDoThi.Count > 0)
            {
                index = (index + 1) % listDoThi.Count;
                HienThiDoThi();
                if (index == listDoThi.Count - 1) timer1.Stop();
                return;
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (this.Location.X < 123)
            {
                int a = this.Location.X;
                this.Location = new Point(a + 15, 55);
            }
            else
            {
                timer1.Stop();
            }
        }
        #region chạy tự động
        private void btnBatDauChayTungBuoc_Click(object sender, EventArgs e)
        {
            this.Bounds = Screen.PrimaryScreen.Bounds;
            if (btnBatDauChayTungBuoc.Text == "Bắt đầu chạy từng bước")
            {
                if (Check())
                {
                    listDoThi = Johnson.Run(Data.Data.graph_Johnson, (int)cbxDinhXuatPhat.EditValue, (int)cbxDinhKetThuc.EditValue);
                    index = 0;
                    HienThiDoThi();
                    btnStartChayTuDong.Enabled = false;
                    btnPrev.Enabled = true;
                    btnNext.Enabled = true;
                    btnStart.Enabled = true;
                    btnEnd.Enabled = true;
                    groupSetting.Enabled = false;
                    btnBatDauChayTungBuoc.Text = "Kết thúc chạy từng bước";
                }
                return;
            }

            if (btnBatDauChayTungBuoc.Text == "Kết thúc chạy từng bước")
            {
                btnBatDauChayTungBuoc.Text = "Bắt đầu chạy từng bước";
                btnStartChayTuDong.Enabled = true;
                btnPrev.Enabled = false;
                btnNext.Enabled = false;
                btnStart.Enabled = false;
                btnEnd.Enabled = false;
                groupSetting.Enabled = true;
                return;
            }
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            index = 0;
            HienThiDoThi();
        }
        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (index > 0)
            {
                index = (index - 1 + listDoThi.Count) % listDoThi.Count;
                HienThiDoThi();
            }
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (index != listDoThi.Count)
            {
                index = (index + 1) % listDoThi.Count;
                HienThiDoThi();
            }
        }
        private void btnEnd_Click(object sender, EventArgs e)
        {
            index = listDoThi.Count - 1;
            HienThiDoThi();
        }
        #endregion
        
    }
}