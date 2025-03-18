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


        //botão para limpar 
        //os resultados
        private void btnLIMPAR_Click(object sender, EventArgs e)
        {
            lstResultados.Items.Clear();
        }

        //verificar se é uma string ou um número
        bool ENumero(string valor)
        {
            if (valor == "")
                return false;

            for (int i = 0; i < valor.Length; i++)
            {
                if (!char.IsDigit(valor[i]))
                    return false;
            }
            return true;
        }

        //Verificando se foi preenchido 
        //com números válidos ou não
        bool Validacao()
        {
            if (ENumero(txtnumInicial.Text))
            {
                if (ENumero(txtnumFinal.Text))
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Número informado invalido");
                    return false;
                }
            }
            if (ENumero(txtnumFinal.Text))
            {
                if (ENumero(txtnumInicial.Text))
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Número informado invalido");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Número informado invalido");
                return false;
            }
        }

        //varificando se o valor está 
        //nos padrões 0 a 100
        bool IntervaloValido(int valor)
        {
            if (valor > 0 && valor < 100)
                return true;
            else
                return false;
        }

        //Verificando se é maior que o limite = 100
        // ou menor que o inicial = 0
        bool ValorValido(int valor1, int valor2)
        {
            if (IntervaloValido(valor1))
            {
                if (IntervaloValido(valor2))
                {
                    if (valor2 >= valor1)
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Final deve ser maior que o Inicial");
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Os números devem ser maior que 0 e menos que 100");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Os numeros devem ser maior que 0 e menor que 100");
                return false;
            }
        }

        //tabuada

        void Tabuada(int Inicial, int Final)
        {
            for (int i = Inicial; i <= Final; i++)
            {
                //o segundo for é responsavel por 
                //fazer a multiplicação até 10
                for (int j = 1; j <= 10; j++)
                {
                    //estou armazenando o calculo do for dentro dessa string
                    string resultado;
                    //estou fazendo a string receber o calculo da tabuada
                    //assim gerando a tabuada até o 10
                    resultado = i + " x " + j + " = " + (i * j);
                    //exibindo
                    lstResultados.Items.Add(resultado);
                }    
                lstResultados.Items.Add("----------------------");
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            {
                //puxando o bool onde está minha validação 
                if (Validacao())
                {
                    //variavel onde será convertida para numeros
                    int numInicial, numFinal;
                    //converção
                    numFinal = int.Parse(txtnumFinal.Text);
                    numInicial = int.Parse(txtnumInicial.Text);
                    //Verificar se está dentro do intervalo que delimitei
                    if (ValorValido(numInicial, numFinal))
                    {
                        //chamar a função tabuada
                        Tabuada(numInicial, numFinal);
                    }

                }
            }
        }
    }
}