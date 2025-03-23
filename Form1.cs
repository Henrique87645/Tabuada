using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tabuada
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLIMPAR_Click(object sender, EventArgs e)
        {
            lstResultados.Items.Clear();
        }

        bool Validacao()
        {
            if (!int.TryParse(txtnumInicial.Text, out int numInicial) ||
                !int.TryParse(txtnumFinal.Text, out int numFinal))
            {
                MessageBox.Show("Digite apenas números inteiros!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        bool IntervaloValido(int valor)
        {
            if (valor > 0 && valor <= 100)
                return true;
            else
                return false;
        }

        bool ValorValido(int inicial, int final)
        {
            if (!IntervaloValido(inicial) || !IntervaloValido(final))
            {
                MessageBox.Show("Os números devem estar entre 1 e 100!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (final < inicial)
            {
                MessageBox.Show("O número final deve ser maior ou igual ao inicial!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        void Tabuada(int inicial, int final)
        {
            for (int i = inicial; i <= final; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    lstResultados.Items.Add($"{i} x {j} = {i * j}");
                }
                lstResultados.Items.Add("----------------------");
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (Validacao())
            {
                int numInicial = int.Parse(txtnumInicial.Text);
                int numFinal = int.Parse(txtnumFinal.Text);

                if (ValorValido(numInicial, numFinal))
                {
                    Tabuada(numInicial, numFinal);
                }
            }
        }
    }
}