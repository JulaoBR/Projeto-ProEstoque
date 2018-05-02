using ProEstoque.CONTROL;
using ProEstoque.MODEL;
using System;
using System.Windows.Forms;

namespace ProEstoque
{
    public partial class frmConfiguracaoADM : Form
    {
        //VARIAVEL DE SELECAO DE NOVO CADASTRO OU EDITAR
        //ONDE 0 = NOVO CADASTRO E 1 = EDITAR CADASTRO JA EXISTENTE
        private int seletor = -1;

        public frmConfiguracaoADM()
        {
            InitializeComponent();
        }

        //SELETOR DO RADION BUTTON
        private void rbNovoCadastro_CheckedChanged(object sender, EventArgs e)
        {
            seletor = 0;
        }

        //SELETOR DO RADION BUTTON
        private void rbEditar_CheckedChanged(object sender, EventArgs e)
        {
            seletor = 1;
        }



        //========== UNIDADE MEDIDA ============================================================

        //METODO DO BOTÂO DE SALVAR
        private void btnSalvaUnidadeMedida_Click(object sender, EventArgs e)
        {
            try
            {
                UnidadeMedidaControl control = new UnidadeMedidaControl();
                UnidadeMedidaModel unidade = new UnidadeMedidaModel();

                //ATIBUI VALOR AO OBJETO
                unidade.uni_descricao = txtDescUnidadeMedida.Text;
                
                switch (seletor)
                {
                    case 0:
                        //CHAMA METODO DA CLASSE CONTROLE
                        if (!control.Inserir(unidade))                       
                            MessageBox.Show("Verifique os campos digitados", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);                        
                        break;
                    case 1:
                        //SE FOR EDITAR PEGA O CODIGO DO ITEM NO CAMPO DELE
                        if(txtCodUnidadeMedida.Text != string.Empty)
                            unidade.uni_cod = Convert.ToInt32(txtCodUnidadeMedida.Text);

                        //CHAMA METODO DA CLASSE CONTROLE
                        if (!control.Update(unidade))
                            MessageBox.Show("Verifique os campos digitados", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    default:
                        MessageBox.Show("Selecione a opção NOVO CADASTRO ou EDITAR", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                }           

            }
            catch(Exception ex)
            {
                MessageBox.Show("ERRO: " + ex, "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                //CHAMA METODO DE LIMA CAMPO
                LimpaCampoUnidadeMedida();
            }

        }

        //METODO DO BOTAO DE EXCLUIR
        private void btnListaUnidadeMedida_Click(object sender, EventArgs e)
        {
            UnidadeMedidaControl control = new UnidadeMedidaControl();
            UnidadeMedidaModel model = new UnidadeMedidaModel();
            //CHAMA A LISTA DE UNIDADE DE MEDIDA = CODIGO 1
            frmListaCadastrosAdm lista = new frmListaCadastrosAdm(1);
            lista.ShowDialog();

            try
            {
                if (lista.codigo != 0)
                {
                    model = control.SelectByID(lista.codigo);

                    txtCodUnidadeMedida.Text = Convert.ToString(model.uni_cod);
                    txtDescUnidadeMedida.Text = model.uni_descricao;
                }
                else
                {
                    LimpaCampoUnidadeMedida();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERRO: " + ex, "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }

        //METODO DE LIMPA OS CAMPOS DA UNIDADE DE MEDIDA
        private void LimpaCampoUnidadeMedida()
        {
            txtCodUnidadeMedida.Clear();
            txtDescUnidadeMedida.Clear();
            txtDescUnidadeMedida.Focus();

            rbEditar.Checked = false;
            rbNovoCadastro.Checked = false;

            seletor = -1;
        }

        //METODO DO BOTAO EXCLIR
        private void btnExcluirUnidadeMedida_Click(object sender, EventArgs e)
        {
            UnidadeMedidaControl control = new UnidadeMedidaControl();
            try
            {
                if (control.Excluir(txtCodUnidadeMedida.Text))
                {
                    LimpaCampoUnidadeMedida();
                    MessageBox.Show("Item excluido com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Erro na exclusão do item", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex, "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }          
        }

        //======================================================================================
        //======================================================================================

        //=========== TIPO DE PRODUTO ==========================================================

        //METODO DO BOTAO DE SALVAR
        private void btnSalvarTipo_Click(object sender, EventArgs e)
        {
            try
            {
                TipoProdutoControl control = new TipoProdutoControl();
                TipoProdutoModel tipo = new TipoProdutoModel();

                tipo.tipo_descricao = txtDescTipo.Text;

                switch (seletor)
                {
                    case 0:
                        if (!control.Inserir(tipo))
                            MessageBox.Show("Verifique os campos digitados", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    case 1:

                        if (txtCodTipo.Text != string.Empty)
                            tipo.tipo_cod = Convert.ToInt32(txtCodTipo.Text);

                        if (!control.Update(tipo))
                            MessageBox.Show("Verifique os campos digitados", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    default:
                        MessageBox.Show("Selecione a opção NOVO CADASTRO ou EDITAR", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                }

               

            }catch(Exception ex)
            {
                MessageBox.Show("ERRO: " + ex, "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                //CHAMA METODO PARA LIMPAR OS CAMPOS
                LimpaCampoTipoProduto();
            }

        }

        //METODO DO BOTAO EXCLUIR
        private void btnExcluirTipo_Click(object sender, EventArgs e)
        {
            TipoProdutoControl control = new TipoProdutoControl();
            try
            {
                if (control.Excluir(txtCodTipo.Text))
                {
                    LimpaCampoTipoProduto();
                    MessageBox.Show("Item excluido com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Erro na exclusão do item", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex, "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //METODO DE LIMPA OS CAMPOS DO TIPO DE PRODUTO
        private void LimpaCampoTipoProduto()
        {
            txtCodTipo.Clear();
            txtDescTipo.Clear();
            txtDescTipo.Focus();

            rbEditar.Checked = false;
            rbNovoCadastro.Checked = false;

            seletor = -1;
        }

        //METODO DO BOTAO LISTA TIPO DE PRODUTO = CODIGO 2
        private void btnListaTipoProduto_Click(object sender, EventArgs e)
        {
            TipoProdutoControl control = new TipoProdutoControl();
            TipoProdutoModel model = new TipoProdutoModel();
            frmListaCadastrosAdm lista = new frmListaCadastrosAdm(2);
            lista.ShowDialog();

            if (lista.codigo != 0)
            {
                model = control.SelectByID(lista.codigo);

                txtCodTipo.Text = Convert.ToString(model.tipo_cod);
                txtDescTipo.Text = model.tipo_descricao;
            }
            else
            {
                LimpaCampoUnidadeMedida();
            }
        }


        //======================================================================================
        //======================================================================================

        //=========== MOTIVOS DE TROCAS ========================================================

        private void btnSalvarMotivo_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluirMotivo_Click(object sender, EventArgs e)
        {

        }

        private void btnListarMotivo_Click(object sender, EventArgs e)
        {

        }

        private void LimpaCampoMotivo()
        {
            txtDescTipo.Clear();
            txtDescMotivo.Clear();
            txtCodMotivo.Focus();

            rbEditar.Checked = false;
            rbNovoCadastro.Checked = false;

            seletor = -1;
        }

        //======================================================================================
        //======================================================================================
    }
}
