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
        private int controle_operacao = -1;
        private FornecedorModel modelo = new FornecedorModel();

        public frmCadFornecedor()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimpaCampo();
            controle_operacao = 0;

            btnNovo.Enabled = false;
            btnEditar.Enabled = false;
            btnSalvar.Enabled = true;

            groupBox1.Enabled = true;

            txtRazaoSocial.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            controle_operacao = 1;

            btnNovo.Enabled = false;
            btnEditar.Enabled = false;
            btnSalvar.Enabled = true;

            groupBox1.Enabled = true;

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            try
            {
                LimpaCampo();

                FornecedorControl control = new FornecedorControl();
                FornecedorModel modelo = new FornecedorModel();

                frmBuscaFornecedor busFornecedor = new frmBuscaFornecedor();
                busFornecedor.ShowDialog();

                if (busFornecedor.codigo != 0)
                {
                    modelo = control.SelectByID(busFornecedor.codigo);

                    txtCodFornecedor.Text = Convert.ToString(modelo.for_cod);
                    txtApelido.Text = modelo.for_apelido;
                    txtRazaoSocial.Text = modelo.for_razao_social;
                    txtCnpj.Text = modelo.for_cnpj;
                    txtDataAtual.Text = Convert.ToString(modelo.for_data_cadastro);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex, "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            FornecedorControl control = new FornecedorControl();

            if (MessageBox.Show("Deseja realmente excluir este cadastro?", "Excluir cadastro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (control.Excluir(txtCodFornecedor.Text))
                {
                    MessageBox.Show("Cadastro excluido com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpaCampo();
                }
                else
                {
                    MessageBox.Show("Falha ao tentar excluir o cadastro!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
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
                SalvaFornecedor();

                LimpaCampo();
            }
            catch
            {

            }
        }

        private void SalvaFornecedor()
        {
            FornecedorControl control = new FornecedorControl(modelo);

            switch (controle_operacao)
            {
                case 0:
                    int aux = control.Inserir();
                    switch (aux)
                    {
                        case 0:
                            MessageBox.Show("Verifique todos os campos obrigatorios", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                        case 1:
                            MessageBox.Show("Item ja cadastrado no banco de dados", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                        case 2:
                            MessageBox.Show("Operação realizada com sucesso", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimpaCampo();
                            break;
                        default:
                            MessageBox.Show("Erro na operação", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                    }
                    break;
                case 1:

                    int aux2 = control.Update();
                    switch (aux2)
                    {
                        case 0:
                            MessageBox.Show("Verifique todos os campos obrigatorios", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                        case 2:
                            MessageBox.Show("Operação realizada com sucesso", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimpaCampo();
                            break;
                        default:
                            MessageBox.Show("Erro na operação", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                    }
                    break;

                default:
                    MessageBox.Show("Selecione as opções de NOVO ou EDITAR", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }
        }

        private void PreencheModelo()
        {
            try
            {
                //verifica se esta selecionado a opção de editar
                if (controle_operacao == 1) 
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
            controle_operacao = -1;

            txtDataAtual.Text = DateTime.Now.ToString();

            groupBox1.Enabled = false;

            btnNovo.Enabled = true;
            btnEditar.Enabled = true;
            btnSalvar.Enabled = false;

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
