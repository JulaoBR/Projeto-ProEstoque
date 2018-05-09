using ProEstoque.CONTROL;
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
    public partial class frmCadPedido : ProEstoque.frmCadastro
    {
        //0 = NOVO - 1 = EDITAR
        private int controle_opcao = -1;

        public frmCadPedido()
        {
            InitializeComponent();
        }

        private void btnBuscaFornecedor_Click(object sender, EventArgs e)
        {
            frmBuscaFornecedor fornecedor = new frmBuscaFornecedor();
            fornecedor.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmBuscaProduto produto = new frmBuscaProduto();
            produto.ShowDialog();
        }

        private void frmCadPedido_Load(object sender, EventArgs e)
        {
            CarregaUnidadeMedida();
            LimpaCampo();
        }

        private void CarregaUnidadeMedida()
        {
            try
            {
                UnidadeMedidaControl control = new UnidadeMedidaControl();

                cbUnidadeMedida.DataSource = control.Select();
                cbUnidadeMedida.DisplayMember = "uni_descricao";
                cbUnidadeMedida.ValueMember = "uni_cod";
                cbUnidadeMedida.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtCodCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtCodProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void frmCadPedido_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            controle_opcao = 0;

            btnNovo.Enabled = false;
            btnEditar.Enabled = false;

            groupBox1.Enabled = true;
            groupBox2.Enabled = true;
            groupBox3.Enabled = true;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            controle_opcao = 1;

            btnNovo.Enabled = false;
            btnEditar.Enabled = false;

            groupBox1.Enabled = true;
            groupBox2.Enabled = true;
            groupBox3.Enabled = true;
        }

        private void btnListar_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpaCampo();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {

        }

        private void LimpaCampo()
        {
            controle_opcao = -1;

            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
            groupBox3.Enabled = false;

            btnEditar.Enabled = true;
            btnNovo.Enabled = true;

            txtCodCliente.Clear();
            txtCodProduto.Clear();
            txtDtPedido.Clear();
            txtDtEntregaPrevista.Clear();
            txtNomeCliente.Clear();
            txtNomeFantasia.Clear();
            txtNomeProduto.Clear();
            txtObservacao.Clear();
            txtQuantidade.Clear();

            cbTipoPedido.SelectedIndex = -1;
            cbUnidadeMedida.SelectedIndex = -1;
        }
    }
}
