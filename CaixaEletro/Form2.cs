using System;
using System.Windows.Forms;

namespace CaixaEletro
{
    public partial class Form2 : Form
    {
        public Form2(int[] cedulas, int[] quantidades)
        {
            InitializeComponent();

            // Exibe o resultado do saque
            for (int i = 0; i < cedulas.Length; i++)
            {
                if (quantidades[i] > 0) // Só mostra se a quantidade for maior que 0
                {
                    string linha = $"{quantidades[i]} nota(s) de R$ {cedulas[i]}";
                    listBoxResultado.Items.Add(linha);
                }
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

}
