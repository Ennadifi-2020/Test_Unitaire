using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bulltin1_Test_Unitaire
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

    

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calcul c = new Calcul();
            double m = c.calculerMoyenne(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox3.Text));
            label1.Text = "La moyenne est :" + m;
        }
    }
}
