using ProEstoque.CONTROL;
using System;
using System.Data;
using System.Windows.Forms;

namespace ProEstoque
{
    public partial class frmBuscaFornecedor : ProEstoque.frmBusca
    {
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
                PreencheGrid(control.Select());
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

        }

        private void PreencheGrid(DataTable dt)
        {
            gridFornecedor.DataSource = null;
            gridFornecedor.Refresh();
            gridFornecedor.DataSource = dt;
            gridFornecedor.ClearSelection();
            gridFornecedor.AllowUserToAddRows = false;
        }
    }
}
