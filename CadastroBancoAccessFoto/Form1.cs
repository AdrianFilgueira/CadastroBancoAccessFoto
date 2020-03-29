using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroBancoAccessFoto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.clientesDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'clientesDataSet.cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.clientesDataSet.cliente);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            clienteBindingSource.EndEdit();
            clienteTableAdapter.Update(this.clientesDataSet.cliente);
            clienteTableAdapter.Fill(this.clientesDataSet.cliente);
           //muda();
        }
    }
}
