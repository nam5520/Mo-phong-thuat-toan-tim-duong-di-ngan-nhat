using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mo_phong_do_thi.Model
{
    public static class FloydWarshall
    {
        public struct FloydCell
        {
            public int Previous;
            public int Value;

            //public FloydCell(int value)
                //: this(-1, value)
            //{ }
            public FloydCell(int previous, int value)
            {
                this.Previous = previous;
                this.Value = value;
            }
        }
        // const
        private const int oo = (int)1e9;
        private const int maxn = 111;

        // variable
        private static DoThi dothi = new DoThi(); // đồ thị
        private static int S = 0; // đỉnh xuất phát
        private static int T = 0; // đỉnh kết thúc
        private static bool[] kt = new bool[maxn];//kiểm tra xem đỉnh đó dã đi lấy ra chưa
        public static FloydCell[,] FloydData = new FloydCell[maxn,maxn];// truy vết
        // ket qua
        private static List<DoThi> ans = new List<DoThi>();
        #region Hàm chức năng
        private static void KhoiTaoKhoangCach()
        {
            for (int i = 0; i < dothi.dsDinh.Count; i++)
            {
                for (int j = 0; j < dothi.dsDinh.Count; j++)
                {
                    if (i == j)
                    {
                        FloydData[i, j].Value = 0;
                        FloydData[i, j].Previous = i;
                    }
                    else
                    {
                        FloydData[i, j].Value = oo;
                        FloydData[i, j].Previous = i;
                    }
                }    
                kt[i] = true;
            }
            for (int i=0; i<dothi.dsCanh.Count;i++)
            { 
                Canh canh = dothi.dsCanh[i];
                int u = IndexOf(canh.IDXP);
                int v = IndexOf(canh.IDKT);
                FloydData[u, v].Value = canh.TrongSo;
                if (canh.LoaiCanh == 0)
                {
                    FloydData[v, u].Value = canh.TrongSo;
                }
            }
        }
        private static void SaveGraph(int mod)
        {
            DoThi z = dothi.Clone();

            for (int index = 0; index < z.dsDinh.Count; index++)
            {
                Dinh dinh = z.dsDinh[index];

                if (kt[index])
                    dinh.mau = Color.LightGray;
                else
                    dinh.mau = Color.Green;

                if (mod == index) dinh.mau = Color.OrangeRed;
            }
            for (int i = 0; i < dothi.dsDinh.Count; i++)
            {
               for (int j = 0; j < dothi.dsDinh.Count; j++)
                {               
                    z.TrongSo[i,j] = FloydData[i, j].Value;
                }          
            }
            if (mod == -2)
            {
                if (FloydData[S, T].Value != oo)
                {
                    z.dsDinh[T].ThongTinThem = "D[" + z.dsDinh[T].Ten + "] = " + FloydData[S, T].Value;
                    int u = T;
                    int s = S;
                    while (u != s)
                    {
                        // tô màu đỏ cạnh nối từ x đến u
                        int IDx = dothi.dsDinh[FloydData[s, u].Previous].ID;
                        int IDu = dothi.dsDinh[u].ID;

                        // tìm cạnh 2 chiều
                        Canh canh = z.dsCanh
                                   .Where(p => p.LoaiCanh == 0)
                                   .Where(p => (p.IDXP == IDx && p.IDKT == IDu) || (p.IDXP == IDu && p.IDKT == IDx))
                                   .FirstOrDefault();
                        if (canh != null)
                            canh.mau = Color.Red;
                        else
                        {
                            // tìm canh 1 chiều
                            canh = z.dsCanh
                                   .Where(p => p.LoaiCanh == 1)
                                   .Where(p => (p.IDXP == IDx && p.IDKT == IDu))
                                   .FirstOrDefault();
                            if (canh != null) canh.mau = Color.Red;
                        }
                        u = FloydData[s, u].Previous;

                    }    
                }
                else MessageBox.Show("Không có đường đi cần tìm...!", "THÔNG BÁO:");
            }    
            ans.Add(z);
        }
        private static void FloydMain()
        {
            for (int k = 0; k < dothi.dsDinh.Count; k++)
            {
                for (int i = 0; i < dothi.dsDinh.Count; i++)
                { 
                    for (int j = 0; j < dothi.dsDinh.Count; j++)
                    {
                        if (FloydData[i, j].Value > FloydData[i, k].Value + FloydData[k, j].Value)
                        {
                            if (FloydData[i, k].Value + FloydData[k, j].Value < 9999999)
                            {
                                FloydData[i, j].Value = FloydData[i, k].Value + FloydData[k, j].Value;
                                FloydData[i, j].Previous = FloydData[k, j].Previous; // truy vết
                            }    
                        }
                            
                    }
                }
                kt[k] = false;
                SaveGraph(k);     
            }
        }
        private static void InitGraph()
        {
            KhoiTaoKhoangCach();
            SaveGraph(-1);
            FloydMain();
            SaveGraph(-2);
        }
        private static int IndexOf(int ID)
        {
            int low = 0, high = dothi.dsDinh.Count - 1;
            while (high >= low)
            {
                int mid = (high + low) / 2;
                if (dothi.dsDinh[mid].ID == ID) return mid;
                if (dothi.dsDinh[mid].ID > ID) high = mid - 1;
                else low = mid + 1;
            }
            return high;
        }
        #endregion
        public static List<DoThi> Run(DoThi a, int IDs, int IDt)
        {
            ans = new List<DoThi>();
            dothi = a.Clone();
            S = IndexOf(IDs);
            T = IndexOf(IDt);
            InitGraph();
            return ans;
        }
    }
}
