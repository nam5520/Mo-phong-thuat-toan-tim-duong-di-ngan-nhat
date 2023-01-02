using DevExpress.XtraBars;
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
    public partial class FrmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void barDijkstra_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmDijkstra form = new FrmDijkstra();
            form.Dock = DockStyle.Fill;
            panelControl1.Controls.Clear();
            panelControl1.Controls.Add(form);
            form.Show();
        }

        private void barFloyd_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmFloyd form = new FrmFloyd();
            form.Dock = DockStyle.Fill;
            panelControl1.Controls.Clear();
            panelControl1.Controls.Add(form);
            form.Show();
        }

        private void barJohnson_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmJohnson form = new FrmJohnson();
            form.Dock = DockStyle.Fill;
            panelControl1.Controls.Clear();
            panelControl1.Controls.Add(form);
            form.Show();
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmDijkstraOnTap form = new FrmDijkstraOnTap();
            form.Dock = DockStyle.Fill;
            panelControl1.Controls.Clear();
            panelControl1.Controls.Add(form);
            form.Show();
        }
    }
}