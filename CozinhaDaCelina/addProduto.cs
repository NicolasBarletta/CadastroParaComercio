using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CozinhaDaCelina
{
    public partial class addProduto : Form
    {
        private object produtoTableAdapter;

        public addProduto()
        {
            InitializeComponent();
        }

        private void produtoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.produtoBindingSource.EndEdit();
           

        }

        private void addProduto_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bdclientesDataSet.Produto'. Você pode movê-la ou removê-la conforme necessário.
            

        }

        private void mercadoLabel_Click(object sender, EventArgs e)
        {

        }

        private void quantidadeLabel_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listaProduto listProduto = new listaProduto();
            listProduto.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listaCliente listCliente = new listaCliente();
            listCliente.ShowDialog();
        }
    }
}
