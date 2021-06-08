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
    public partial class listaCliente : Form
    {
        public listaCliente()
        {
            InitializeComponent();
        }

        private void clientesSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientesSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bdclientesDataSet);

        }

        private void listaCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bdclientesDataSet.ClientesS'. Você pode movê-la ou removê-la conforme necessário.
            this.clientesSTableAdapter.Fill(this.bdclientesDataSet.ClientesS);

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
    }
}
