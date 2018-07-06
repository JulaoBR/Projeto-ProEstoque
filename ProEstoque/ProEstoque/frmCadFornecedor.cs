using ProEstoque.CONTROL;
using ProEstoque.MODEL;
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
    public partial class frmCadFornecedor : ProEstoque.frmCadastro
    {
        // 0 = NOVO - 1 = EDITAR
        private int controle_opcao = -1;
        private FornecedorModel modelo = new FornecedorModel();

        public frmCadFornecedor()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            controle_opcao = 0;

            btnNovo.Enabled = false;
            btnEditar.Enabled = false;

            groupBox1.Enabled = true;

            txtRazaoSocial.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            controle_opcao = 1;

            btnNovo.Enabled = false;
            btnEditar.Enabled = false;

            groupBox1.Enabled = true;

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            try
            {
                frmBuscaFornecedor busFornecedor = new frmBuscaFornecedor();
                busFornecedor.ShowDialog();

                if (busFornecedor.codigo != 0)
                {
                    
                }
            }
            catch
            {

            }
            
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //Comando que questiona ao usuário se relamente deseja sair do programa
            DialogResult result = MessageBox.Show("Deseja excluir o item selecionado?",
               "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpaCampo();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {

                PreencheModelo();

                FornecedorControl control = new FornecedorControl(modelo);
                control.Inserir();

                LimpaCampo();
            }
            catch
            {

            }
        }

        private void PreencheModelo()
        {
            try
            {
                //verifica se esta selecionado a opção de editar
                if (controle_opcao == 1) 
                    modelo.for_cod = Convert.ToInt32(txtCodFornecedor.Text);

                modelo.for_razao_social = txtRazaoSocial.Text;
                modelo.for_apelido = txtApelido.Text;
                modelo.for_cnpj = txtCnpj.Text;
                modelo.for_data_cadastro = Convert.ToDateTime(txtDataAtual.Text);
            }
            catch
            {

            }
        }

        private void frmCadFornecedor_Load(object sender, EventArgs e)
        {
            LimpaCampo();
        }

        private void LimpaCampo()
        {
            controle_opcao = -1;

            groupBox1.Enabled = false;

            btnNovo.Enabled = true;
            btnEditar.Enabled = true;

            txtCodFornecedor.Clear();
            txtApelido.Clear();
            txtRazaoSocial.Clear();
            txtCnpj.Clear();
        }

        private void txtCodFornecedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtCnpj_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void frmCadFornecedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }
    }
}
