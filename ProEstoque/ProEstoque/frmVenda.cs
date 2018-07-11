using System;
using System.Data;
using System.Windows.Forms;

namespace ProEstoque
{
    public partial class frmVenda : Form
    {
        public frmVenda()
        {
            InitializeComponent();
        }

        private void btnBuscaCliente_Click(object sender, EventArgs e)
        {
            frmBuscaCliente fornecedor = new frmBuscaCliente();
            fornecedor.ShowDialog();
        }

        private void btnBuscaProduto_Click(object sender, EventArgs e)
        {
            frmBuscaProduto produto = new frmBuscaProduto();
            produto.ShowDialog();
        }

        private void btnAddLote_Click(object sender, EventArgs e)
        {

        }

        private void btnAddProduto_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void btnAjuste_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void frmVenda_Load(object sender, EventArgs e)
        {

        }

        private void frmVenda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        private void txtPedido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtPedido_Leave(object sender, EventArgs e)
        {

        }

        private void txtCodCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtCodCliente_Layout(object sender, LayoutEventArgs e)
        {

        }

        private void txtCodProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtCodProduto_Leave(object sender, EventArgs e)
        {

        }

        private void txtQtdTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtQtdLote_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void LimpaCampoCliente()
        {
            txtCodCliente.Clear();
            txtPedido.Clear();

            txtRazaoSocial.Clear();
            txtEstado.Clear();
            txtEndereco.Clear();
            txtComprador.Clear();
            txtCidade.Clear();
            txtApelido.Clear();
            txtNumero.Clear();
        }

        private void LimpaCampoProduto()
        {
            txtCodProduto.Clear();

            txtProduto.Clear();
            txtEstoqueAtual.Clear();
            txtQtdLote.Clear();
            txtQtdTotal.Clear();
            txtLote.Clear();
        }

        private void CarregaGridProduto(DataTable dt)
        {
            gridProduto.DataSource = null;
            gridProduto.DataSource = dt;
            gridProduto.Refresh();
        }

        private void CarregaGridLoteProduto()
        {

        }

        private void CarregaGridLotesDisponiveis()
        {

        }
    }
}
