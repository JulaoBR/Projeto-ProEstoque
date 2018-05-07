using ProEstoque.CONTROL;
using System;
using System.Windows.Forms;

namespace ProEstoque
{
    public partial class frmControleTroca : Form
    {
        public frmControleTroca()
        {
            InitializeComponent();
        }

        private void btnPesquisaCliente_Click(object sender, EventArgs e)
        {
            frmBuscaFornecedor fornecedor = new frmBuscaFornecedor();
            fornecedor.ShowDialog();
        }

        private void btnPesquisaProduto_Click(object sender, EventArgs e)
        {
            frmBuscaProduto produto = new frmBuscaProduto();
            produto.ShowDialog();
        }

        private void frmControleTroca_Load(object sender, EventArgs e)
        {
            CarregaMotivo();
        }

        private void CarregaMotivo()
        {
            try
            {
                MotivoControl control = new MotivoControl();

                cbMotivo.DataSource = control.Select();
                cbMotivo.DisplayMember = "mot_descricao";
                cbMotivo.ValueMember = "mot_cod";
                cbMotivo.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
