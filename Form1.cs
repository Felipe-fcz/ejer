using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double nota1 = double.Parse(txtNota1.Text);
            double nota2 = double.Parse(txtNota2.Text);
            double nota3 = double.Parse(txtNota3.Text);

            double resultado = nota1 + nota2 + nota3;
            double notaFinal = resultado / 3.0;

            MessageBox.Show("La nota final del estudienate es: " + notaFinal);
        }
    }
}
