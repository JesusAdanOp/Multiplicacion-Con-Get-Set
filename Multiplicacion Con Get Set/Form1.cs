using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multiplicacion_Con_Get_Set
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clmultiplicacion mult = new clmultiplicacion();
            mult.V1 = int.Parse(txtv1.Text);
            mult.V2 = int.Parse(txtv2.Text);

            txtres.Text = mult.multiplicar().ToString();

        }
    }
}
