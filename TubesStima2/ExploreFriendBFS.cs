using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TubesStima2
{
    class ExploreFriendBFS
    {
        private List<string> hasil;
        private int derajat;

        public void bfs(GrafAdj graf, string simpulAwal, string simpulTujuan)
        {
            Dictionary<string, string> prevNode = new Dictionary<string, string>();
            Dictionary<string, string> mapGraf = graf.getMap();
            HashSet<string> dikunjungi = new HashSet<string>();
            dikunjungi.Add(simpulAwal);
            Queue<string> antrian = new Queue<string>();
            antrian.Enqueue(simpulAwal);

            prevNode[simpulAwal] = null;

            while (antrian.Count > 0)
            {
                string current = antrian.Dequeue();

                if (current == simpulTujuan)
                {
                    break;
                }

                foreach (var tetangga in mapGraf[current].Split(' '))
                {
                    if (!dikunjungi.Contains(tetangga))
                    {
                        dikunjungi.Add(tetangga);
                        antrian.Enqueue(tetangga);

                        prevNode[tetangga] = current;
                    }
                }
            }

            string curr = simpulTujuan;
            hasil = new List<string>();

            while (curr != null)
            {
                hasil.Add(curr);
                string temp;
                bool keyExists = prevNode.TryGetValue(curr, out temp);
                if (!keyExists)
                {
                    throw new KeyNotFoundException();
                }
                curr = prevNode[curr];
                derajat++;
            }

            derajat = derajat - 2; //mengexclude simpulAwal dan simpulTujuan

            hasil.Reverse();
        }

        public void tampilkanHasil()
        {
            string[] rute = hasil.ToArray();
            System.Console.WriteLine("Nama akun:{0} dan {1}",rute[0],rute[rute.Length-1]);
            System.Console.Write("Jalur pertemanan ");
            for (int i = 0; i < rute.Length; i++)
            {
                if (i != rute.Length - 1)
                {
                    System.Console.Write(rute[i] + "->");
                }
                else
                {
                    System.Console.WriteLine(rute[i]);
                }
            }
        }

        public void tampilkanDerajat()
        {
            System.Console.WriteLine("Derajat koneksi: {0}", derajat);
        }

        public List<string> getHasil()
        {
            return hasil;
        }

        public int getDerajat()
        {
            return derajat;
        }
    }
}
