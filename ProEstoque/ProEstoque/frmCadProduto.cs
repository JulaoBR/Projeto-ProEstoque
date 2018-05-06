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
    public partial class frmCadProduto : ProEstoque.frmCadastro
    {
        public frmCadProduto()
        {
            InitializeComponent();
        }

        private void btnBuscaFornecedor_Click(object sender, EventArgs e)
        {
            frmBuscaFornecedor buscaFornecedor = new frmBuscaFornecedor();
            buscaFornecedor.ShowDialog();
        }

        private void frmCadProduto_Load(object sender, EventArgs e)
        {
            CarregaUnidadeMedida();
            CarregaTipoProduto();
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
                MessageBox.Show("Erro: " + ex,"Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Comando que questiona ao usuário se relamente deseja sair do programa
            DialogResult result = MessageBox.Show("Deseja excluir o item selecionado?",
               "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {

            }
        }
    }
}
