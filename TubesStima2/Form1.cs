using System;
using System.IO;
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
    public partial class Testo : Form
    {
        private GrafAdj graf;
        private Microsoft.Msagl.Drawing.Graph graph;
        public Testo()
        {
            InitializeComponent();
            ExploreFriendButton.Enabled = false;
            RecomFriendButton.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //open from file
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                //initial dir 
                InitialDirectory = @"D:\",
                Title = "Browse Text Files",
                //check file
                CheckFileExists = true,
                CheckPathExists = true,
                //extensions
                DefaultExt = "txt",
                Filter = "txt files (*.txt)|*.txt",
                FilterIndex = 2,
                RestoreDirectory = true,
                //properties
                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            //texbox berisi path file
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
            }

            string file_name = openFileDialog1.FileName;
            System.Console.WriteLine(openFileDialog1.FileName);
            System.Console.WriteLine("Sebelum read");
            string[] lines = readFromFile(file_name);
            //create graf adjacency
            graf = new GrafAdj();
            graf.createMap(lines);
            System.Console.WriteLine("Simpul: "+graf.getJmlhSimpul().ToString());
            System.Console.WriteLine("Sisi: "+graf.getJmlhSisi().ToString());
            System.Console.WriteLine("Setelah read");
            //Menciptakan graph
            graph = new Microsoft.Msagl.Drawing.Graph("graph");
            gambarGraph(graph, lines);
            //enable button
            ExploreFriendButton.Enabled = true;
            RecomFriendButton.Enabled = true;
            /*
            //create a form 
            System.Windows.Forms.Form form = new System.Windows.Forms.Form();
            //create a viewer object 
            Microsoft.Msagl.GraphViewerGdi.GViewer viewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();
            //create a graph object 
            Microsoft.Msagl.Drawing.Graph graph = new Microsoft.Msagl.Drawing.Graph("graph");
            //create the graph content 
            gambarGraph(graph, lines);
            //bind the graph to the viewer 
            viewer.Graph = graph;
            //associate the viewer with the form 
            form.SuspendLayout();
            viewer.Dock = System.Windows.Forms.DockStyle.Fill;
            form.Controls.Add(viewer);
            form.ResumeLayout();
            //show the form 
            form.ShowDialog();
            */
        }

        private string[] readFromFile(string file_name)
        {
            //read dari file (local)
            string[] lines = System.IO.File.ReadAllLines(@file_name);
            //string[] lines = System.IO.File.ReadAllLines(@"D:\Furqon\Stima\Tubes2\TubesStima2\TubesStima2\TextFile\test.txt");

            //error
            //string path = (Path.Combine(Directory.GetCurrentDirectory(), "\\test.txt")).ToString();
            //string[] lines = System.IO.File.ReadAllLines(path);

            //System.Console.WriteLine(path);
            System.Console.WriteLine("Contents of Test.txt = ");
            //debug di console
            foreach (string line in lines)
            {
                Console.WriteLine("\t" + line);
            }
            return lines;
        }

        private void gambarGraph(Microsoft.Msagl.Drawing.Graph graph, string[] lines)
        {
            //proses tiap line, mulai dari indeks satu
            for (int i = 1; i < lines.Length; i++)
            {
                //split jadi dua simpul
                string[] substring = lines[i].Split(' ');
                //debug line
                Console.WriteLine($"Line: {i}");
                Console.WriteLine($"Simpul1: {substring[0]}");
                Console.WriteLine($"Simpul2: {substring[1]}");
                //add ke graph
                var Edge = graph.AddEdge(substring[0], substring[1]);
                Edge.Attr.ArrowheadAtTarget = Microsoft.Msagl.Drawing.ArrowStyle.None;
                Edge.Attr.ArrowheadAtSource = Microsoft.Msagl.Drawing.ArrowStyle.None;
                //kalau ingin 2 arah
                //graph.AddEdge(substring[1], substring[0]);
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ExploreFriend_Click(object sender, EventArgs e)
        {
            //Graph ditunjukkan di form2
            var frm = new Form2(graph,graf);
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }

        private void RecomFriendButton_Click(object sender, EventArgs e)
        {
            //Graph ditunjukkan di form2
            var frm = new Form3(graph,graf);
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }
    }
}
