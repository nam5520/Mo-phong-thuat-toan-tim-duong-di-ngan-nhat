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
    public partial class FrmVeDoThi : DevExpress.XtraEditors.XtraUserControl
    {
        private DoThi dothi = new DoThi();
        public FrmVeDoThi()
        {
            InitializeComponent();
        }
        public FrmVeDoThi(DoThi dt)
        {
            InitializeComponent();
            dothi = dt;
        }

        private void FrmVeDoThi_Paint(object sender, PaintEventArgs e)
        {
            dothi.Draw(e);
        }
    }
}
