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
        private int controle_opcao = -1;

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

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpaCampos();
        }

        private void frmMovimentacao_Load(object sender, EventArgs e)
        {
            txtCodProduto.Focus();
            LimpaCampos();
        }

        private void frmMovimentacao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
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

        private void txtCodFornecedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtCodFornecedor_Leave(object sender, EventArgs e)
        {

        }

        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtDataFabricacao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtDataFabricacao_Leave(object sender, EventArgs e)
        {
            try
            {
                DateTime data = Convert.ToDateTime(txtDataFabricacao.Text);
                //txtDataVencimento.Text = data.AddDays(prazoValidade).ToString("dd/MM/yyyy");
            }
            catch
            {
                txtDataVencimento.Clear();
                return;
            }
        }

        private void LimpaCampos()
        {         
            controle_opcao = -1;

            txtCodFornecedor.Clear();
            txtCodProduto.Clear();
            txtNomeFantasia.Clear();
            txtDescricaoProduto.Clear();
            txtRazaoSocial.Clear();
            txtQuantidade.Clear();
            txtDataFabricacao.Clear();
            txtDataVencimento.Clear();
            txtLote.Clear();
            txtObservacao.Clear();

            rbEntrada.Checked = false;
            rbEntrada.Checked = false;
        }
    }
}
