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
    }
}
