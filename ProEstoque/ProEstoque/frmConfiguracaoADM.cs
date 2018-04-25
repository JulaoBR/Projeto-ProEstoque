using ProEstoque.CONTROL;
using ProEstoque.MODEL;
using System;
using System.Windows.Forms;

namespace ProEstoque
{
    public partial class frmConfiguracaoADM : Form
    {
        public frmConfiguracaoADM()
        {
            InitializeComponent();
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

                //CHAMA METODO DA CLASSE CONTROLE
                if (!control.Inserir(unidade)){
                    MessageBox.Show("Verifique os campos digitados", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        private void btnExcluirUnidadeMedida_Click(object sender, EventArgs e)
        {
            
        }

        //METODO DE LIMPA OS CAMPOS DA UNIDADE DE MEDIDA
        private void LimpaCampoUnidadeMedida()
        {
            txtCodUnidadeMedida.Clear();
            txtDescUnidadeMedida.Clear();

            txtDescUnidadeMedida.Focus();
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

                control.Inserir(tipo);

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

        }

        //METODO DE LIMPA OS CAMPOS DO TIPO DE PRODUTO
        private void LimpaCampoTipoProduto()
        {
            txtCodTipo.Clear();
            txtDescTipo.Clear();

            txtDescTipo.Focus();
        }

        //======================================================================================
        //======================================================================================
    }
}
