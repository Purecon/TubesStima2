using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TubesStima2
{
    public partial class Form3 : Form
    {
        private Microsoft.Msagl.Drawing.Graph graph;
        private GrafAdj graf;
        public Form3(Microsoft.Msagl.Drawing.Graph graph_input, GrafAdj graf_input)
        {
            InitializeComponent();
            graph = graph_input;
            //sudah digambar di form1
            //gViewer1.Graph = graph;
            graf = graf_input;
            initializeCombo();
        }

        private void initializeCombo()
        {
            //testing method
            string[] list_simpul = graf.getDaftarSimpul();
            foreach (var simpul in list_simpul)
            {
                comboBoxAcc.Items.Add(simpul);
                System.Console.WriteLine(simpul);
            }
        }

        private void runFriendRecommendation()
        {
            System.Console.WriteLine("Friend Recommendation Running");
            listBoxFriend.Items.Clear();
            string selectedAcc = comboBoxAcc.Items[comboBoxAcc.SelectedIndex].ToString();
            FriendRecommendation friendRecom = new FriendRecommendation();
            IList<Tuple<string, HashSet<string>>> daftarRecom = friendRecom.getFriendRecommendation(graf,selectedAcc);
            foreach(var recom in daftarRecom)
            {
                //BFS
                ExploreFriendBFS eksplorasiBFS = new ExploreFriendBFS();
                //Ambil dari daftar rekomendasi
                List<string> tempList = new List<string>();
                string[] tetangga = graf.getMap()[selectedAcc].Split(' ');
                string namaRecom = recom.Item1;
                HashSet<string> daftarMutual = recom.Item2;
                //syarat belum menjadi teman dan bukan dirinya sendiri
                if (!Array.Exists(tetangga, element => element == namaRecom) && namaRecom!=selectedAcc)
                {
                    listBoxFriend.Items.Add(namaRecom);
                    if (selectedAcc != namaRecom)
                    {
                        eksplorasiBFS.bfs(graf, selectedAcc, namaRecom);
                        eksplorasiBFS.tampilkanHasil();
                        string[] rute = eksplorasiBFS.getHasil().ToArray();
                        for (int i = 0; i < rute.Length; i++)
                        {
                            graph.FindNode(rute[i]).Attr.FillColor = Microsoft.Msagl.Drawing.Color.Green;
                        }
                        listBoxFriend.Items.Add(tampilkanHasil(eksplorasiBFS.getHasil())+ ", derajat pertemanan: "+eksplorasiBFS.getDerajat().ToString());
                    }

                    foreach (string nama in daftarMutual)
                    {
                        tempList.Add(nama);
                    }
                    string[] tempArr = tempList.ToArray();
                    string outTetangga = tempArr.Length.ToString()+" Mutual friends: "+string.Join(" ", tempArr);
                    listBoxFriend.Items.Add(outTetangga);
                    listBoxFriend.Items.Add(" ");
                }
            }
        }

        public string tampilkanHasil(List<string> hasil)
        {
            string[] rute = hasil.ToArray();
            string outputString;
            outputString = "Jalur pertemanan ";
            for (int i = 0; i < rute.Length; i++)
            {
                if (i != rute.Length - 1)
                {
                    outputString = outputString + rute[i] + "->";
                }
                else
                {
                    outputString = outputString + rute[i];
                }
            }
            return outputString;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelAccount_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxAcc_SelectedIndexChanged(object sender, EventArgs e)
        {
            runFriendRecommendation();
        }
    }
}
