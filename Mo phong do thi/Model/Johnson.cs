using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mo_phong_do_thi.Model
{
    public static class Johnson
    {
        private const int oo = (int)1e9;
        private const int maxn = 111;

        // variable
        private static DoThi dothi = new DoThi(); // đồ thị
        private static int S = 0; // đỉnh xuất phát
        private static int T = 0; // đỉnh kết thúc
        private static int[] d = new int[maxn];
        private static int[] d2 = new int[maxn];
        // Lưu trọng số của các đỉnh
        private static int[] trace = new int[maxn]; // truy vết
        private static bool[] kt = new bool[maxn * maxn];
        private static List<p>[] listCanh = new List<p>[maxn]; // danh sách cạnh
        private static int SBellmanFord = -1;
        private static bool[] kt2 = new bool[maxn]; // Đỉnh đó đã được lấy ra chưa
        private static int[] trace2 = new int[maxn]; // truy vết
        // data struct
        private static C5.IntervalHeap<p> Heap = new C5.IntervalHeap<p>();
        // ket qua
        private static List<DoThi> ans = new List<DoThi>();

        #region Hàm chức năng
        private static void KhoiTaoDanhSachCanhDijkstra()
        {
            for (int index = 0; index < maxn; index++)
            {
                listCanh[index] = new List<p>();
            }


            for (int index = 0; index < dothi.dsCanh.Count; index++)
            {
                Canh canh = dothi.dsCanh[index];
                int u = IndexOf(canh.IDXP);
                int v = IndexOf(canh.IDKT);

                p xt = new p();
                xt.v = v;
                xt.w = canh.TrongSo;

                listCanh[u].Add(xt);
                if (canh.LoaiCanh == 0)
                {
                    // nếu là cạnh 2 chiều
                    p qp = new p();
                    qp.v = u;
                    qp.w = canh.TrongSo;
                    listCanh[v].Add(qp);
                }
            }
        }
        private static void KhoiTaoKhoangCachDijkstra(int Sx)
        {
            for (int index = 0; index < dothi.dsDinh.Count; index++)
            {
                int cs = IndexOf(dothi.dsDinh[index].ID);
                if (cs != Sx) d2[index] = oo; else d2[index] = 0;
                kt2[index] = true;
                trace2[index] = -1;
            }

            /// thêm đỉnh đầu tiên vào Heap
            p z = new p();
            z.v = Sx;
            z.w = 0;
            Heap.Add(z);
        }
        private static void KhoiTaoKhoangCachFloyd()
        {
            for (int index = 0; index < dothi.dsDinh.Count; index++)
            {
                int cs = IndexOf(dothi.dsDinh[index].ID);
                if (cs != SBellmanFord) d[index] = oo; else d[index] = 0;
                trace[index] = -1;
            }
        }
        private static void DinhTrungGian()
        {
            Dinh dinh = new Dinh();
            dinh.mau = Color.Yellow;
            dinh.Ten = "S";
            dinh.x = 1288;
            dinh.y = 197;
            int count = dothi.dsDinh.Count;
            if (count == 0) dinh.ID = 1; else dinh.ID = dothi.dsDinh[count - 1].ID + 1;
            dothi.dsDinh.Add(dinh);
            SBellmanFord = IndexOf(dinh.ID);
            for (int index = 1; index < dothi.dsDinh.Count; index++)
            {
                Canh canh = new Canh();
                int LoaiCanh = 1;
                int cntt = dothi.dsCanh.Count;
                if (cntt == 0) canh.ID = 1;
                else canh.ID = dothi.dsCanh[cntt - 1].ID + 1;

                canh.IDXP = dothi.dsDinh[dothi.dsDinh.Count - 1].ID;
                canh.IDKT = index;
                canh.x1 = dothi.dsDinh.Where(p => p.ID == canh.IDXP).FirstOrDefault().x;
                canh.y1 = dothi.dsDinh.Where(p => p.ID == canh.IDXP).FirstOrDefault().y;
                canh.x2 = dothi.dsDinh.Where(p => p.ID == canh.IDKT).FirstOrDefault().x;
                canh.y2 = dothi.dsDinh.Where(p => p.ID == canh.IDKT).FirstOrDefault().y;
                canh.TrongSo = 0;
                canh.mau = Color.Black;
                canh.LoaiCanh = LoaiCanh;
                dothi.dsCanh.Add(canh);
            }
        }
        private static void XoaDinhTrungGian()
        {
            for (int index = 0; index < dothi.dsCanh.Count; index++)
            {
                dothi.dsCanh[index].TrongSo = dothi.dsCanh[index].TrongSo + d[IndexOf(dothi.dsCanh[index].IDXP)] - d[IndexOf(dothi.dsCanh[index].IDKT)];
            }    
            dothi.dsCanh.RemoveAll(p => p.IDXP == dothi.dsDinh[dothi.dsDinh.Count - 1].ID);
            dothi.dsDinh.RemoveAll(p => p.ID == dothi.dsDinh[dothi.dsDinh.Count-1].ID);
            SaveGraphStart();
        }
        private static void SaveGraphStart()
        {
            DoThi z = dothi.Clone();
            for (int index = 0; index < z.dsCanh.Count; index++)
            {
                Canh canh = z.dsCanh[index];
                canh.mau = Color.Black;
            }
            ans.Add(z);
        }
        private static void SaveGraph(int mod)
        {
            DoThi z = dothi.Clone();

            for (int index = 0; index < z.dsDinh.Count; index++)
            {
                Dinh dinh = z.dsDinh[index];

                if (d[index] != oo)
                    dinh.ThongTinThem = "D[" + dinh.Ten + "] = " + d[index];
                else
                    dinh.ThongTinThem = "D[" + dinh.Ten + "] = +oo";
            }

            for (int index = 0; index < z.dsCanh.Count; index++)
            {
                Canh canh = z.dsCanh[index];

                canh.mau = Color.LightGray;
                if (kt[index]) canh.mau = Color.Green;
                if (index == mod) canh.mau = Color.OrangeRed;
            }

            if (mod == -2 && d[T] != oo)
            {
                // in đường đi cuối cùng
                int u = T;
                while (u != S)
                {
                    int x = trace[u];

                    // tô màu đỏ cạnh nối từ x đến u
                    int IDu = dothi.dsDinh[u].ID;
                    int IDx = dothi.dsDinh[x].ID;

                    // tìm cạnh 2 chiều
                    Canh canh = z.dsCanh
                               .Where(p => p.LoaiCanh == 0 && p.TrongSo == d[u] - d[x])
                               .Where(p => (p.IDXP == IDx && p.IDKT == IDu) || (p.IDXP == IDu && p.IDKT == IDx))
                               .FirstOrDefault();
                    if (canh != null)
                        canh.mau = Color.Red;
                    else
                    {
                        // tìm canhk 1 chiều
                        canh = z.dsCanh
                               .Where(p => p.LoaiCanh == 1 && p.TrongSo == d[u] - d[x])
                               .Where(p => (p.IDXP == IDx && p.IDKT == IDu))
                               .FirstOrDefault();
                        if (canh != null) canh.mau = Color.Red;
                        else
                        {
                            MessageBox.Show("Không có đường đi theo yêu cầu...!", "THÔNG BÁO:");
                        }
                    }

                    u = trace[u];
                }
            }
            ans.Add(z);
        }
        private static void SaveGraphDijkstra(int mod)
        {
            DoThi z = dothi.Clone();

            for (int index = 0; index < z.dsDinh.Count; index++)
            {
                Dinh dinh = z.dsDinh[index];

                if (kt2[index])
                    dinh.mau = Color.LightGray;
                else
                    dinh.mau = Color.Green;

                if (mod == index) dinh.mau = Color.OrangeRed;
                if (d2[index] != oo)
                    dinh.ThongTinThem = "D[" + dinh.Ten + "] = " + d2[index];
                else
                    dinh.ThongTinThem = "D[" + dinh.Ten + "] = +oo";
            }
            
            if (mod == -2 && d2[T] != oo)
            {
                // in đường đi cuối cùng
                int u = T;
                while (u != S)
                {
                    int x = trace2[u];

                    // tô màu đỏ cạnh nối từ x đến u
                    int IDu = dothi.dsDinh[u].ID;
                    int IDx = dothi.dsDinh[x].ID;

                    // tìm cạnh 2 chiều
                    Canh canh = z.dsCanh
                               .Where(p => p.LoaiCanh == 0 && p.TrongSo == d2[u] - d2[x])
                               .Where(p => (p.IDXP == IDx && p.IDKT == IDu) || (p.IDXP == IDu && p.IDKT == IDx))
                               .FirstOrDefault();
                    if (canh != null)
                        canh.mau = Color.Red;
                    else
                    {
                        // tìm canh 1 chiều
                        canh = z.dsCanh
                               .Where(p => p.LoaiCanh == 1 && p.TrongSo == d2[u] - d2[x])
                               .Where(p => (p.IDXP == IDx && p.IDKT == IDu))
                               .FirstOrDefault();
                        if (canh != null) canh.mau = Color.Red;
                    }
                   
                    u = trace2[u];
                }
                
            }
            if (mod == -2)
            {
                z.TrongSo = dothi.TrongSo;
            }
            ans.Add(z);
        }
        private static void FordBellmanMain()
        {
            int m = dothi.dsCanh.Count;
            for (int index = 1; index <= dothi.dsDinh.Count; index++)
            {
                int cnt = dothi.dsCanh.Count;

                for (int i = 0; i < dothi.dsCanh.Count; i++)
                    kt[i] = false;
                SaveGraph(-1);

                for (int i = 0; i < dothi.dsCanh.Count; i++)
                {
                    Canh canh = dothi.dsCanh[i];

                    bool ok = false;

                    int u = IndexOf(canh.IDXP);
                    int v = IndexOf(canh.IDKT);


                    SaveGraph(i);


                    if (d[v] > d[u] + canh.TrongSo)
                    {
                        d[v] = d[u] + canh.TrongSo;
                        trace[v] = u;
                        ok = true;
                        kt[i] = true;
                    }

                    if (canh.LoaiCanh == 0 && d[u] > d[v] + canh.TrongSo)
                    {
                        d[u] = d[v] + canh.TrongSo;
                        trace[u] = v;
                        ok = true;
                        kt[i] = true;
                    }

                    if (ok) cnt--;
                }

                if (cnt == m) return;
            }
        }
        private static void DijkstraMain(int Sx,int mod)
        {
            while (Heap.Count > 0)
            {
                p z = Heap.FindMin();
                int u = z.v;
                int du = z.w;
                Heap.DeleteMin();

                if (!kt2[u]) continue;
                kt2[u] = false;
                if (mod != -1 )
                SaveGraphDijkstra(u);
                //if (u == T) return;

                foreach (p canh in listCanh[u])
                {
                    int v = canh.v;
                    int w = canh.w;

                    if (d2[v] > d2[u] + w)
                    {
                        d2[v] = d2[u] + w;
                        trace2[v] = u;
                        p xx = new p();
                        xx.v = v;
                        xx.w = d2[v];
                        Heap.Add(xx);
                    }
                }
            }
            if (kt2[T] && mod == -1)
            {
                MessageBox.Show("Không có đường đi cần tìm...!", "THÔNG BÁO:");
            }
        }
        private static void DijkstraV()
        {
            KhoiTaoDanhSachCanhDijkstra();   
            for (int i=0; i<dothi.dsDinh.Count;i++)
            {
                int Sx = IndexOf(dothi.dsDinh[i].ID);
                KhoiTaoKhoangCachDijkstra(Sx);
                SaveGraphDijkstra(-1);
                DijkstraMain(Sx,0);
                for (int j = 0; j < dothi.dsDinh.Count; j++)
                {
                    dothi.TrongSo[i, j] = d2[j];
                }
                SaveGraphDijkstra(-3);
            }
            KhoiTaoKhoangCachDijkstra(S);
            DijkstraMain(S,-1);
            SaveGraphDijkstra(-2);
        }
        private static void InitGraph()
        {
            SaveGraphStart();
            DinhTrungGian();
            KhoiTaoKhoangCachFloyd();
            FordBellmanMain();
            XoaDinhTrungGian();
            //SaveGraph(-1);
            DijkstraV();
            //SaveGraph(-2);
        }
        #endregion

        #region Main
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
        public static List<DoThi> Run(DoThi a, int IDs, int IDt)
        {
            ans = new List<DoThi>();
            dothi = a.Clone();
            S = IndexOf(IDs);
            T = IndexOf(IDt);
            InitGraph();
            return ans;
        }
        #endregion
    }
}
