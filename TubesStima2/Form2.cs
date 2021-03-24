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
    public partial class Form2 : Form
    {
        private bool boolAcc;
        private bool boolTarget;
        private Microsoft.Msagl.Drawing.Graph graph;
        private GrafAdj graf;
        public Form2(Microsoft.Msagl.Drawing.Graph graph_input, GrafAdj graf_input)
        {
            InitializeComponent();
            graph = graph_input;
            //sudah digambar di form1
            gViewer1.Graph = graph;
            graf = graf_input;
            initializeCombo();
            startButton.Enabled = false;
            string[] list_simpul = graf.getDaftarSimpul();
            foreach (var simpul in list_simpul)
            {
                graph.FindNode(simpul).Attr.FillColor = Microsoft.Msagl.Drawing.Color.White;
            }
        }

        private void warnaiGraph()
        {
            labelDerajatKoneksi.Text = "";
            labelJalur.Text = "";
            string[] list_simpul = graf.getDaftarSimpul();
            string selectedAcc = comboBoxAcc.Items[comboBoxAcc.SelectedIndex].ToString();
            string targetAcc = comboBoxTarget.Items[comboBoxTarget.SelectedIndex].ToString();
            foreach (var simpul in list_simpul)
            {
                graph.FindNode(simpul).Attr.FillColor = Microsoft.Msagl.Drawing.Color.White;
            }
            if (checkBoxBFS.Checked)
            {
                //BFS
                System.Console.WriteLine("Menggunakan BFS");
                ExploreFriendBFS eksplorasiBFS = new ExploreFriendBFS();
                /*
                try
                {
                    eksplorasiBFS.bfs(graf, "A", "W");
                    eksplorasiBFS.tampilkanHasil();
                    eksplorasiBFS.tampilkanDerajat();
                }
                catch (Exception ex)
                {
                    System.Console.WriteLine(ex);
                    System.Console.WriteLine("Tidak ada jalur koneksi yang tersedia");
                    System.Console.WriteLine("Anda harus memulai koneksi baru itu sendiri.");
                }
                */
                try
                {
                    if (selectedAcc != targetAcc)
                    {
                        eksplorasiBFS.bfs(graf, selectedAcc, targetAcc);
                        eksplorasiBFS.tampilkanHasil();
                        string[] rute = eksplorasiBFS.getHasil().ToArray();
                        for (int i = 0; i < rute.Length; i++)
                        {
                            graph.FindNode(rute[i]).Attr.FillColor = Microsoft.Msagl.Drawing.Color.Green;
                        }
                        tampilkanHasil(eksplorasiBFS.getHasil());
                        labelDerajatKoneksi.Text = eksplorasiBFS.getDerajat().ToString();
                    }
                    else
                    {
                        MessageBox.Show("Tidak ada jalur koneksi yang tersedia", "Not Found!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Tidak ada jalur koneksi yang tersedia", "Not Found!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    System.Console.WriteLine(ex);
                }
            }
            else
            {
                //DFS
                System.Console.WriteLine("Menggunakan DFS");
                ExploreFriendDFS eksplorasiDFS = new ExploreFriendDFS();
                try
                { 
                string[] rute = eksplorasiDFS.getConnection(graf, selectedAcc, targetAcc);
                for (int i = 0; i < rute.Length; i++)
                {
                    graph.FindNode(rute[i]).Attr.FillColor = Microsoft.Msagl.Drawing.Color.Green;
                }
                labelDerajatKoneksi.Text = eksplorasiDFS.getDegreeConnection(graf, selectedAcc, targetAcc).ToString();
                List<string> ruteList = rute.ToList();
                tampilkanHasil(ruteList);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Tidak ada jalur koneksi yang tersedia", "Not Found!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    System.Console.WriteLine(ex);
                }
            }
            gViewer1.Graph = graph;
        }

        private void initializeCombo()
        {
            //testing method
            string[] list_simpul = graf.getDaftarSimpul();
            foreach (var simpul in list_simpul)
            {
                comboBoxAcc.Items.Add(simpul);
                comboBoxTarget.Items.Add(simpul);
                System.Console.WriteLine(simpul);
            }
        }

        public void tampilkanHasil(List<string> hasil)
        {
            string[] rute = hasil.ToArray();
            string outputString;
            outputString = "Jalur pertemanan ";
            for (int i = 0; i < rute.Length; i++)
            {
                if (i != rute.Length - 1)
                {
                    outputString = outputString+rute[i]+"->";
                }
                else
                {
                    outputString = outputString +rute[i];
                }
            }
            labelJalur.Text = outputString;
        }

        private void gViewer1_Load(object sender, EventArgs e)
        {

        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBoxBFS_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxBFS.Checked)
            {
                checkBoxDFS.Checked = false;
            }            
        }

        private void checkBoxDFS_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxDFS.Checked)
            {
                checkBoxBFS.Checked = false;
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            warnaiGraph();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxAcc_SelectedIndexChanged(object sender, EventArgs e)
        {
            boolAcc = true;
            if(boolAcc && boolTarget)
            {
                startButton.Enabled = true;
            }
        }

        private void comboBoxTarget_SelectedIndexChanged(object sender, EventArgs e)
        {
            boolTarget = true;
            if (boolAcc && boolTarget)
            {
                startButton.Enabled = true;
            }
        }
    }
}
