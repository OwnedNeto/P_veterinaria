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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_veterinario_Click(object sender, EventArgs e)
        {
            frmveterinario objFrnm = new frmveterinario();
            objFrnm.Show();

        }

        private void btn_cliente_Click(object sender, EventArgs e)
        {
            frmcliente objFrnm = new frmcliente();
            objFrnm.Show();
        }

        private void btn_mascotas_Click(object sender, EventArgs e)
        {
            frmmascotas objFrnm = new frmmascotas();
            objFrnm.Show();

        }

        private void btn_desp_Click(object sender, EventArgs e)
        {
            frmdesp objFrnm = new frmdesp();
            objFrnm.Show();

        }

        private void btn_vacunas_Click(object sender, EventArgs e)
        {
            frmvacunas objFrnm = new frmvacunas();
            objFrnm.Show();

        }
    }
}
