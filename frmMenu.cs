using Sorveteria_PolarMarrom.Classe;
using Sorvetia_PolarMarrom;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sorveteria_PolarMarrom
{
    public partial class MenuSorveteria : Form
    {
        private Pedido pedidoAtual;
        private List<Produto> listaProdutos;
        List<Produto> produtosFiltrados;

        public string Sabor { get; set; }
        public string Detalhes { get; set; }
        public string Valor { get; set; }

        public MenuSorveteria()
        {
            InitializeComponent();
        }

        private void cadastrarProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNovoProduto frmNovoProduto = new frmNovoProduto();
            frmNovoProduto.Show();
        }

        private void MenuSorveteria_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void MenuSorveteria_Load(object sender, EventArgs e)
        {
            listaProdutos = ArquivoJson.ImportarProdutosJson();
            pedidoAtual = new Pedido();
        }

        private void btnAddPedido_Click(object sender, EventArgs e)
        {
            AddPedido novoItem = new AddPedido();
            DialogResult resultado = novoItem.ShowDialog();

            if (resultado == DialogResult.Yes)
            {
                // Adiciona o Produto no item
                
                // Cria uma instancia de ITEm
                
                // Adiciona o Valor no item

                // Adiciona a quantidade no item

                // Adiciona o item no pedido

                // Atualiza o list box com os itens do pedido
            }
        }
    }
}

