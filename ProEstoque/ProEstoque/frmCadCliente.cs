using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProEstoque
{
    public partial class frmCadCliente : ProEstoque.frmCadastro
    {
        public frmCadCliente()
        {
            InitializeComponent();
        }

        private void btnCadEstado_Click(object sender, EventArgs e)
        {
            frmCadEstado cadEstado = new frmCadEstado();
            cadEstado.ShowDialog();
        }

        private void btnCadCidade_Click(object sender, EventArgs e)
        {
            frmCadCidade cadCidade = new frmCadCidade();
            cadCidade.ShowDialog();
        }
    }
}
