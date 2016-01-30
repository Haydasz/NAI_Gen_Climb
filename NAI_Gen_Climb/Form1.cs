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

            Functions.functionChoice = fid;
            checkBox1.Checked = false;

            Evolution gen = new Evolution(Int32.Parse(population.Text), Int32.Parse(iteration.Text), fid, Double.Parse(min.Text), Double.Parse(max.Text));
            Climb climb = new Climb(Int32.Parse(iteration.Text), fid, Double.Parse(min.Text), Double.Parse(max.Text), Double.Parse(cliX.Text), Double.Parse(delta.Text));
            Harmony harmony = new Harmony(Int32.Parse(hsm.Text), Double.Parse(hmcr.Text), Double.Parse(par.Text), Double.Parse(min.Text), Double.Parse(max.Text), Int32.Parse(iteration.Text));
            List<String> genControls = gen.runGen();
            List<String> climbControls = climb.run();
            List<String> harmonyControls = harmony.run();

            genMin.Text = genControls[0];
            genIter.Text = genControls[1];
            genX.Text = genControls[2];
            genY.Text = genControls[3];

            climbMin.Text = climbControls[0];
            climbIter.Text = climbControls[1];
            climbX.Text = climbControls[2];
            climbY.Text = climbControls[3];

            harX.Text = harmonyControls[0];
            harY.Text = harmonyControls[1];
            harMin.Text = harmonyControls[2];

            checkBox1.Checked = true;
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
