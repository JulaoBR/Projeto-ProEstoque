using ProEstoque.CONTROL;
using ProEstoque.MODEL;
using System;
using System.Windows.Forms;

namespace ProEstoque
{
    public partial class frmCadCliente : ProEstoque.frmCadastro
    {
        //0 = novo // 1 = editar
        private int controle_operacao = -1;

        public frmCadCliente()
        {
            InitializeComponent();
        }

        private void frmCadCliente_Load(object sender, EventArgs e)
        {
            CarregaEstado();
            LimpaCampos();
        }

        private void CarregaEstado()
        {
            try
            {
                EstadoControl control = new EstadoControl();

                cbEstado.DataSource = control.Select();
                cbEstado.DisplayMember = "est_nome";
                cbEstado.ValueMember = "est_cod";
                cbEstado.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CarregaCidade()
        {
            try
            {
                CidadeControl control = new CidadeControl();

                if(cbEstado.SelectedValue != null && cbEstado.ValueMember != "")
                {
                    cbCidade.DataSource = control.Select(Convert.ToInt32(cbEstado.SelectedValue));
                    cbCidade.DisplayMember = "cid_nome";
                    cbCidade.ValueMember = "cid_cod";
                }              
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cbEstado_SelectedValueChanged(object sender, EventArgs e)
        {
            CarregaCidade();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            ClienteModel modelo = new ClienteModel();

            try
            {
                if(controle_operacao == 1)
                    modelo.cli_cod = Convert.ToInt32(txtId.Text);
                if (txtCli_cod_original.Text != "")
                    modelo.cli_cod_original = Convert.ToInt32(txtCli_cod_original.Text);
                modelo.cli_nome_social = txtNomeCliente.Text;
                modelo.cli_nome_fantasia = txtNomeFantasia.Text;
                modelo.cli_endereco = txtEndereco.Text;
                modelo.cli_bairro = txtBairro.Text;
                modelo.cli_cep = txtCep.Text;
                if(txtNumero.Text != "")
                    modelo.cli_numero = Convert.ToInt32(txtNumero.Text);
                modelo.est_cod = Convert.ToInt32(cbEstado.SelectedValue);
                modelo.cid_cod = Convert.ToInt32(cbCidade.SelectedValue);
                modelo.cli_data_cadastro = Convert.ToDateTime(txtDataAtual.Text);
                if (rbPessoaFisica.Checked)
                    modelo.cli_tipo_pessoa = "FISICA";

                if (rbPessoaJuridica.Checked)
                    modelo.cli_tipo_pessoa = "JURIDICA";

                SalvaCliente(modelo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex,"ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            controle_operacao = 0;

            btnNovo.Enabled = false;
            btnEditar.Enabled = false;
                   
            groupBox1.Enabled = true;
            groupBox2.Enabled = true;

            txtCli_cod_original.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            controle_operacao = 1;

            btnNovo.Enabled = false;
            btnEditar.Enabled = false;

            groupBox1.Enabled = true;
            groupBox2.Enabled = true;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            LimpaCampos();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpaCampos();

        }

        private void LimpaCampos()
        {
            controle_operacao = -1;

            groupBox1.Enabled = false;
            groupBox2.Enabled = false;

            btnNovo.Enabled = true;
            btnEditar.Enabled = true;

            txtId.Clear();
            txtNomeCliente.Clear();
            txtNomeFantasia.Clear();
            txtEndereco.Clear();
            txtBairro.Clear();
            txtCep.Clear();
            txtNumero.Clear();
            txtCli_cod_original.Clear();

            cbCidade.SelectedIndex = -1;
            cbEstado.SelectedIndex = -1;

            rbPessoaFisica.Checked = false;
            rbPessoaJuridica.Checked = false;
        }

        private void SalvaCliente(ClienteModel modelo)
        {
            ClienteControl control = new ClienteControl();

            switch (controle_operacao)
            {
                case 0:
                    int aux = control.Inserir(modelo);
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
                            LimpaCampos();
                            break;
                        default:
                            MessageBox.Show("Erro na operação", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                    }
                    break;
                case 1:

                    int aux2 = control.Update(modelo);
                    switch (aux2)
                    {
                        case 0:
                            MessageBox.Show("Verifique todos os campos obrigatorios", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                        case 1:
                            MessageBox.Show("Operação realizada com sucesso", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimpaCampos();
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

        private void txtCli_cod_original_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void frmCadCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
       }

        private void txtCli_cod_original_Leave(object sender, EventArgs e)
        {
            ClienteControl control = new ClienteControl();
            try
            {
                if (control.ValidarUsuario(Convert.ToInt32(txtCli_cod_original.Text)))
                {
                    MessageBox.Show("Cliente/Fornecedor ja cadastrado!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCli_cod_original.Clear();
                    txtCli_cod_original.Focus();
                    return;
                }
            }
            catch
            {
                //SEM MENSAGEM DE TRATAMENTO
                return;
            }
                   
        }
    }
}
