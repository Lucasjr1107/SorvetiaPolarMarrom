using Sorveteria_PolarMarrom.Classe;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sorvetia_PolarMarrom
{
    public partial class AddPedido : Form
    {
        public Produto Produto { get; set; }

        public int Quantidade { get; set; }

        public decimal Valor {  get; set; }


        public AddPedido()
        {
            InitializeComponent();
        }

        private void AddPedido_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // Verifica se selecionou um produto no combo box

            // Verifica se a quantidade não é zero

            // Marca o DialogResult como Yes

            // Fecha o Formulário atual
        }
    }
}
