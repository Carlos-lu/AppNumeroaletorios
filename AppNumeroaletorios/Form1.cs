using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppNumeroaletorios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
           
        }

        private void btnLenarcaja_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            this.lstNumeros.Items.Clear();
            for(int n = 20; n <= 50; n++)
            {
                int num = r.Next(20, 50);
                this.lstNumeros.Items.Add(num);
            }

        }
    }
}
