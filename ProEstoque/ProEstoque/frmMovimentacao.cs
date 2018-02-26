using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProEstoque
{
    public partial class frmMovimentacao : Form
    {
        public frmMovimentacao()
        {
            InitializeComponent();
        }

        private void btnBuscaFornecedor_Click(object sender, EventArgs e)
        {
            frmBuscaFornecedor buscaFornecedor = new frmBuscaFornecedor();
            buscaFornecedor.ShowDialog();
        }

        private void btnBuscaProduto_Click(object sender, EventArgs e)
        {
            frmBuscaProduto buscaProduto = new frmBuscaProduto();
            buscaProduto.ShowDialog();
        }
    }
}
