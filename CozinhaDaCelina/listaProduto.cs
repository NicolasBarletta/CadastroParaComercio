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
    public partial class listaProduto : Form
    {
        public listaProduto()
        {
            InitializeComponent();
        }

        private void clientesSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientesSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bdclientesDataSet);

        }

        private void listaProduto_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bdclientesDataSet.Produto'. Você pode movê-la ou removê-la conforme necessário.
            _ = produtoTableAdapter.Fill(bdclientesDataSet.Produto);
            // TODO: esta linha de código carrega dados na tabela 'bdclientesDataSet.ClientesS'. Você pode movê-la ou removê-la conforme necessário.
            _ = clientesSTableAdapter.Fill(bdclientesDataSet.ClientesS);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            addProduto produto = new addProduto();
            produto.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            addCliente cliente = new addCliente();
            cliente.ShowDialog();
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
