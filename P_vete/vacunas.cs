﻿using System;
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
    public partial class frmvacunas : Form
    {
        public frmvacunas()
        {
            InitializeComponent();
        }

        private void t_vacunasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.t_vacunasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.veterinariaDataSet);

        }

        private void vacunas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'veterinariaDataSet.t_vacunas' Puede moverla o quitarla según sea necesario.
            this.t_vacunasTableAdapter.Fill(this.veterinariaDataSet.t_vacunas);

        }
    }
}
