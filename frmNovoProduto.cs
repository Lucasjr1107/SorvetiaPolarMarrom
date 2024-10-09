using Sorveteria_PolarMarrom.Classe;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sorveteria_PolarMarrom

{
    public partial class frmNovoProduto : Form
    {
        private List<Produto> ListaProdutos;
        public string Sabor { get; set; }

        public string Detalhes { get; set; }
        public string Valor { get; set; }

        public frmNovoProduto()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            SalvarProduto();

            txtSabor.Text = Sabor;
            txtDetalhes.Text = Detalhes;
        }

        private void SalvarProduto()
        {
            if (txtSabor.Text.Length == 0)
            {
                MessageBox.Show("Escreva um nome para o sabor!");
                return;
            }

            if (nmrValorDoProduto.Value == 0)
            {
                MessageBox.Show("Valor nao pode ser zero!");
                return;
            }

            Produto produto = new Produto (txtSabor.Text, txtDetalhes.Text, nmrValorDoProduto.Value );
            ListaProdutos.Add( produto );

            MessageBox.Show("Sabor salvo");

            ArquivoJson.ExportarProdutosJson(ListaProdutos);

            DialogResult resultado = MessageBox.Show(
                "Deseja cadastrar outro sabor?",
                "Confirmaçao",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
              );

            if( resultado == DialogResult.Yes )
            {
                txtSabor.Clear();
                txtDetalhes.Clear();
                nmrValorDoProduto.Value = 0;

                txtSabor.Focus();
            }
            else
            {
                this.Close();
            }
           
        }

        private void frmNovoProduto_Load(object sender, EventArgs e)
        {
            ListaProdutos = (List<Produto>)ArquivoJson.ImportarProdutosJson();
        }


    }
}
