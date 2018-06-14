using ProEstoque.CONTROL;
using System;
using System.Data;
using System.Windows.Forms;

namespace ProEstoque
{
    public partial class frmBuscaFornecedor : ProEstoque.frmBusca
    {
        //recebe o codigo do fornecedor/usuario
        public int codigo = 0;

        public frmBuscaFornecedor()
        {
            InitializeComponent();
        }

        private void txtCodFornecedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void frmBuscaFornecedor_Load(object sender, EventArgs e)
        {
            ClienteControl control = new ClienteControl();

            try
            {
                PreencheGrid(control.Select(txtCodFornecedor.Text, txtRazaoSocial.Text, txtFantasia.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex , "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmBuscaFornecedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBuscaFornecedor_Load(sender, e);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            gridFornecedor.DataSource = null;
            gridFornecedor.Refresh();
            gridFornecedor.ClearSelection();
            gridFornecedor.AllowUserToAddRows = false;
        }

        private void PreencheGrid(DataTable dt)
        {
            gridFornecedor.DataSource = null;
            gridFornecedor.Refresh();
            gridFornecedor.DataSource = dt;
            gridFornecedor.ClearSelection();
            gridFornecedor.AllowUserToAddRows = false;
        }

        private void gridFornecedor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    this.codigo = Convert.ToInt32(gridFornecedor.Rows[e.RowIndex].Cells[0].Value);
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Sem dados para selecionar!!", "Operação Invalida!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
