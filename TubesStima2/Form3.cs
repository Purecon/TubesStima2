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
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
