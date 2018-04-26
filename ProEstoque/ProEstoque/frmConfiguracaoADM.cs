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


        private void rbNovoCadastro_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbEditar_CheckedChanged(object sender, EventArgs e)
        {

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
        private void btnListaUnidadeMedida_Click(object sender, EventArgs e)
        {
            UnidadeMedidaControl control = new UnidadeMedidaControl();
            UnidadeMedidaModel model = new UnidadeMedidaModel();
            //CHAMA A LISTA DE UNIDADE DE MEDIDA = CODIGO 1
            frmListaCadastrosAdm lista = new frmListaCadastrosAdm(1);
            lista.ShowDialog();

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

                if (!control.Inserir(tipo))
                {
                    MessageBox.Show("Verifique os campos digitados", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        }

        //METODO DE LIMPA OS CAMPOS DO TIPO DE PRODUTO
        private void LimpaCampoTipoProduto()
        {
            txtCodTipo.Clear();
            txtDescTipo.Clear();

            txtDescTipo.Focus();
        }

        //METODO DO BOTAO LISTA TIPO DE PRODUTO = CODIGO 2
        private void btnListaTipoProduto_Click(object sender, EventArgs e)
        {
            frmListaCadastrosAdm lista = new frmListaCadastrosAdm(2);
            lista.ShowDialog();
        }



        //======================================================================================
        //======================================================================================
    }
}
