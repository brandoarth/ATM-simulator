using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CaixaEletro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            // Inicializando o vetor de cédulas
            int valor;
            int[] cedulas = new int[] { 200, 100, 50, 20, 10, 5, 2, 1 };
            int[] quantidades = new int[cedulas.Length];

            if (int.TryParse(txtValorSaque.Text, out valor) && valor > 0)
            {
             //verifica se o valor digitado pelo usuário é maior que zero.
                for (int i = 0; i < cedulas.Length; i++)
                {
                    int quantidade = valor / cedulas[i];
                    quantidades[i] = quantidade;
                    valor -= quantidade * cedulas[i];
                }

                // Envia o texto do TextBox para o Form2
                string textoParaEnviar = txtValorSaque.Text;
                Form2 formResultado = new Form2(cedulas, quantidades);
                formResultado.Show();

            }
            else
            {
                MessageBox.Show("Valor inválido! O saque deve ser maior que zero.");
            }
        }
    }
}
