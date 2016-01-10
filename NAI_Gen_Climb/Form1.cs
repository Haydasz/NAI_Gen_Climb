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
            Gen gen = new Gen(Int32.Parse(population.Text), Int32.Parse(iteration.Text), 1, Double.Parse(min.Text), Double.Parse(max.Text));
            Climb climb = new Climb(Int32.Parse(iteration.Text), 1, Double.Parse(min.Text), Double.Parse(max.Text),5.0);

            gen.runGen();
            climb.run();
        }
    }
}
