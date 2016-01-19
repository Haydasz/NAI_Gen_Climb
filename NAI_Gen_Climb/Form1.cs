using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NAI_Gen_Climb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void generate_Click(object sender, EventArgs e)
        {
            int fid = function.SelectedIndex;

            Gen gen = new Gen(Int32.Parse(population.Text), Int32.Parse(iteration.Text), fid, Double.Parse(min.Text), Double.Parse(max.Text));
            Climb climb = new Climb(Int32.Parse(iteration.Text), fid, Double.Parse(min.Text), Double.Parse(max.Text),5.0, Double.Parse(delta.Text));

            gen.runGen();
            climb.run();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
