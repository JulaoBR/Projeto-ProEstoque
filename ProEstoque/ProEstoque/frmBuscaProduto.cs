using ProEstoque.CONTROL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProEstoque
{
    public partial class frmBuscaProduto : ProEstoque.frmBusca
    {
        //recebe o codigo do fornecedor/usuario
        public int codigo = 0;

        public frmBuscaProduto()
        {
            InitializeComponent();
            CarregaTipoProduto();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            gridProduto.DataSource = null;
            gridProduto.Refresh();
            gridProduto.ClearSelection();
            gridProduto.AllowUserToAddRows = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBuscaProduto_Load(sender, e);
        }

        private void CarregaTipoProduto()
        {
            try
            {
                TipoProdutoControl control = new TipoProdutoControl();

                cbTipoProduto.DataSource = control.Select();
                cbTipoProduto.DisplayMember = "tipo_descricao";
                cbTipoProduto.ValueMember = "tipo_cod";
                cbTipoProduto.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void gridProduto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                codigo = Convert.ToInt32(gridProduto.CurrentRow.Cells[0].Value.ToString());

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Selecione um produto\n" + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmBuscaProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        private void frmBuscaProduto_Load(object sender, EventArgs e)
        {           
            ProdutoControl control = new ProdutoControl(txtCodProduto.Text, txtDescricao.Text, cbTipoProduto.Text);

            try
            {
                PreencheGrid(control.Select());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtCodProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void PreencheGrid(DataTable dt)
        {
            gridProduto.DataSource = null;
            gridProduto.Refresh();
            gridProduto.DataSource = dt;
            gridProduto.ClearSelection();
            gridProduto.AllowUserToAddRows = false;
        }

        private void txtDescricao_TextChanged(object sender, EventArgs e)
        {
            frmBuscaProduto_Load(sender, e);
        }

        private void cbTipoProduto_TextChanged(object sender, EventArgs e)
        {
            frmBuscaProduto_Load(sender, e);     
        }
    }
}
