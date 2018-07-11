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
    public partial class frmBuscaCliente : ProEstoque.frmBusca
    {
        //recebe o codigo do fornecedor/usuario
        public int codigo = 0;

        public frmBuscaCliente()
        {
            InitializeComponent();
        }

        private void frmBuscaCliente_Load(object sender, EventArgs e)
        {
            try
            {
                ClienteControl control = new ClienteControl(txtCodFornecedor.Text, txtRazaoSocial.Text, txtFantasia.Text);
                PreencheGrid(control.Select());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimpaCampo();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBuscaCliente_Load(sender, e);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                codigo = Convert.ToInt32(gridCliente.CurrentRow.Cells[0].Value.ToString());

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Selecione um cliente\n" + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmBuscaCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        private void PreencheGrid(DataTable dt)
        {
            gridCliente.DataSource = null;
            gridCliente.Refresh();
            gridCliente.DataSource = dt;
            gridCliente.ClearSelection();
            gridCliente.AllowUserToAddRows = false;
        }

        private void txtCodFornecedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void LimpaCampo()
        {
            txtCodFornecedor.Clear();
            txtFantasia.Clear();
            txtRazaoSocial.Clear();

            gridCliente.DataSource = null;
            gridCliente.Refresh();
        }

        private void txtRazaoSocial_TextChanged(object sender, EventArgs e)
        {
            frmBuscaCliente_Load(sender, e);
        }

        private void txtFantasia_TextChanged(object sender, EventArgs e)
        {
            frmBuscaCliente_Load(sender, e);
        }
    }
}
