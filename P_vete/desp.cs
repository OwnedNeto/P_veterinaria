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
    public partial class frmdesp : Form
    {
        public frmdesp()
        {
            InitializeComponent();
        }

        private void t_desparacitacionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.t_desparacitacionBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.veterinariaDataSet);

        }

        private void desp_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'veterinariaDataSet.t_desparacitacion' Puede moverla o quitarla según sea necesario.
            this.t_desparacitacionTableAdapter.Fill(this.veterinariaDataSet.t_desparacitacion);

        }
    }
}
