using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P_vete
{
    public partial class frmcliente : Form
    {
        public frmcliente()
        {
            InitializeComponent();
        }

        private void t_clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.t_clienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.veterinariaDataSet);

        }

        private void cliente_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'veterinariaDataSet.t_cliente' Puede moverla o quitarla según sea necesario.
            this.t_clienteTableAdapter.Fill(this.veterinariaDataSet.t_cliente);

        }
    }
}
