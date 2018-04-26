using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProEstoque
{
    public partial class frmCadProduto : ProEstoque.frmCadastro
    {
        public frmCadProduto()
        {
            InitializeComponent();
        }

        private void btnBuscaFornecedor_Click(object sender, EventArgs e)
        {
            frmBuscaFornecedor buscaFornecedor = new frmBuscaFornecedor();
            buscaFornecedor.ShowDialog();
        }
    }
}
