using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mo_phong_do_thi.Model
{
    public class Dinh : ICloneable
    {
        public int ID { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public Color mau { get; set; }
        public string Ten { get; set; }
        public string ThongTinThem { get; set; }

        public void Draw(PaintEventArgs e)
        {
            Pen pen = new Pen(mau);
            pen.Width = 1;

            e.Graphics.FillEllipse(new SolidBrush(mau), x - 15, y - 15, 30, 30);

            StringFormat format = new StringFormat();
            format.LineAlignment = StringAlignment.Center;
            format.Alignment = StringAlignment.Center;
            e.Graphics.DrawString(this.Ten, new Font("Arial", 10), new SolidBrush(Color.White), new PointF(x, y), format);
            e.Graphics.DrawString(this.ThongTinThem, new Font("Arial", 8), Brushes.Blue, new PointF(x, y - 30), format);
        }
           

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
