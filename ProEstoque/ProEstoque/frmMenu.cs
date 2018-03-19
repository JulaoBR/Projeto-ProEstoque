using System;
using System.Windows.Forms;

namespace ProEstoque
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void usuáriosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCadUsuario cadUsuario = new frmCadUsuario();
            cadUsuario.ShowDialog();
        }

        private void sAIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Comando que questiona ao usuário se relamente deseja sair do programa
            DialogResult result = MessageBox.Show("Deseja realmente encerrar a aplicação?",
               "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {               
                Application.Exit();
            }
        }

        private void lOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Comando que questiona ao usuário se relamente deseja sair do programa
            DialogResult result = MessageBox.Show("Deseja fazer logout?",
               "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Restart();
            }
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadCliente cadCliente = new frmCadCliente();
            cadCliente.ShowDialog();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadProduto cadProduto = new frmCadProduto();
            cadProduto.ShowDialog();
        }

        private void mOVIMENTAÇÃOToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmMovimentacao movim = new frmMovimentacao();
            movim.ShowDialog();
        }

        private void btnMovimentacao_Click(object sender, EventArgs e)
        {
            mOVIMENTAÇÃOToolStripMenuItem1_Click(sender, e);
        }

        private void vENDASToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmVenda venda = new frmVenda();
            venda.ShowDialog();
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            frmVenda venda = new frmVenda();
            venda.ShowDialog();
        }

        private void pEDIDOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadPedido pedido = new frmCadPedido();
            pedido.ShowDialog();
        }

        private void mATÉRIAPRIMAToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
