using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimuladorCredito
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Limpia el Grid
            listView1.Items.Clear();
                       
             //Se inicia las operaciones
            int ncuotas = int.Parse(txtcuotas.Text);
            double valorprestamo = double.Parse(txtprestamo.Text);
            double intereses = double.Parse(txtintereses.Text);

            intereses = intereses / 100;

            double capi = 0;
            double intereses2 = 0;
            double pagototal2 = 0;
            double saldo2 = 0;

            capi = Math.Round(valorprestamo / ncuotas);

            //MessageBox.Show("Variable Intereses 123: "+ intereses);

            for (int i=1;i<=ncuotas;i++)
            {
                             
                intereses2 = Math.Round(valorprestamo * intereses);
                pagototal2 = Math.Round(capi + intereses2);
                valorprestamo = Math.Round(valorprestamo - capi);
                
                ListViewItem lista = new ListViewItem(i.ToString());
                lista.SubItems.Add(capi.ToString("C0"));
                lista.SubItems.Add(intereses2.ToString("C0"));
                lista.SubItems.Add(pagototal2.ToString("C0"));
                lista.SubItems.Add(valorprestamo.ToString("C0"));
                listView1.Items.Add(lista);
              
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }
    }
}
