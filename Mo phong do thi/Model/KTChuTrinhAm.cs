using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mo_phong_do_thi.Model
{
    public static class KTChuTrinhAm
    {
        private static DoThi dothi = new DoThi();
        private const int oo = (int)1e9;
        private const int maxn = 1000000;
        public static bool isNegCycleBellmanFord(DoThi a)
        {
            dothi = a.Clone();
            int V = dothi.dsDinh.Count;// số đỉnh 
            int E = dothi.dsCanh.Count;//số cạnh
            int[] dist = new int[maxn];
            for (int i = 0; i < V; i++)
                dist[i] = oo;
                dist[0] = 0;
            for (int i = 1; i <= V - 1; i++)
            {
                for (int j = 0; j < E; j++)
                {
                    int u = dothi.dsCanh[j].IDXP;
                    int v = dothi.dsCanh[j].IDKT;
                    int weight = dothi.dsCanh[j].TrongSo;
                    if (dist[u] != oo && dist[u] + weight < dist[v])
                        dist[v] = dist[u] + weight;
                }
            }
            for (int i = 0; i < E; i++)
            {
                int u = dothi.dsCanh[i].IDXP;
                int v = dothi.dsCanh[i].IDKT;
                int weight = dothi.dsCanh[i].TrongSo;
                if (dist[u] != oo && dist[u] + weight < dist[v])
                    return true;
            }
            return false;
        }
    }
}
