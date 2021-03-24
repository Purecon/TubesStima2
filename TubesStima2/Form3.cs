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
            string selectedAcc = comboBoxAcc.Items[comboBoxAcc.SelectedIndex].ToString();
            FriendRecommendation friendRecom = new FriendRecommendation();
            IList<Tuple<string, HashSet<string>>> daftarRecom = friendRecom.getFriendRecommendation(graf,selectedAcc);
            foreach(var x in daftarRecom)
            {
                System.Console.WriteLine(x);
            }
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
