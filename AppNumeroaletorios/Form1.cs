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
            int s = 0, numero;
            float pro;
            
            Random aleatorio = new Random();
            this.lstNumeros.Sorted = false;
            this.lstNumeros.Items.Clear();
            for(int c = 20; c <= 50; c++)
            {
                 numero = aleatorio.Next(20, 50);
                this.lstNumeros.Items.Add(numero);
                s = s + numero;
                
            }
            pro = s/30;
            this.txtSuma.Text = s.ToString();
            this.txtPromedio.Text = pro.ToString("0.00");        
        }

        private void btnOrdenarLista_Click(object sender, EventArgs e)
        {
            this.lstNumeros.Sorted = true;

        }
    }
}
