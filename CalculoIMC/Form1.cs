using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoIMC
{
    public partial class Form1 : Form
    {
        public Form1() {
            InitializeComponent();
            calcular.Enabled = false;
        }

        private void altura_TextChanged(object sender, EventArgs e) {
            calcular.Enabled = alturaText.Text != "" ? true : false;
        }

        private void calcular_Click(object sender, EventArgs e) {
            double.TryParse(alturaText.Text, out double altura);
            double.TryParse(pesoText.Text, out double peso);
            if (altura == null) return;

            double imc = peso / Math.Pow(altura, 2);

            StringBuilder str = new StringBuilder($"Seu IMC é {imc:F2}");

            MessageBox.Show(str.ToString());

            result.Text = str.ToString();
        }
    }
}
