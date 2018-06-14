﻿using ProEstoque.CONTROL;
using ProEstoque.MODEL;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProEstoque
{
    public partial class frmCadProduto : ProEstoque.frmCadastro
    {
        // 0 = NOVO - 1 = EDITAR
        private int controle_opcao = -1;
        private List<ClienteModel> listaCliente = new List<ClienteModel>();

        public frmCadProduto()
        {
            InitializeComponent();
            gridProduto.AutoGenerateColumns = false;
        }

        private void btnBuscaFornecedor_Click(object sender, EventArgs e)
        {
            ClienteControl control = new ClienteControl();
            ClienteModel model = new ClienteModel();
            try
            {
                frmBuscaFornecedor buscaFornecedor = new frmBuscaFornecedor();
                buscaFornecedor.ShowDialog();
  
                if (buscaFornecedor.codigo != 0)
                {
                    model = control.SelectByID(buscaFornecedor.codigo);

                    txtCodFornecedor.Text = Convert.ToString(model.cli_cod_original);
                    txtNomeFornecedor.Text = model.cli_nome_fantasia;
                }
                else
                {
                    LimpaCampo();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex, "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmCadProduto_Load(object sender, EventArgs e)
        {
            CarregaUnidadeMedida();
            CarregaTipoProduto();
            LimpaCampo();
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

        private void txtPrazoValidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtCodFornecedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtCodigoBarra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtEstMinimo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtEstMaximo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtPesoBruto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtPesoLiquido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void frmCadProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        private void btnAdicionarFornecedor_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCodFornecedor.Text != "" && txtNomeFornecedor.Text != "")
                {
                    ClienteModel model = new ClienteModel();
                    ProdutoControl control = new ProdutoControl();

                    if (!control.VarificaCliente(listaCliente, Convert.ToInt32(txtCodFornecedor.Text)))
                    {
                        model.cli_cod_original = Convert.ToInt32(txtCodFornecedor.Text);
                        model.cli_nome_fantasia = txtNomeFornecedor.Text;

                        txtCodFornecedor.Clear();
                        txtNomeFornecedor.Clear();

                        listaCliente.Add(model);

                        AtualizaGrid();
                    }
                    else
                    {
                        MessageBox.Show("Fornecedor ja esta na lista...", "Operação Invalida!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }                  
                }
                else
                {
                    MessageBox.Show("Não existe dados para serem adicionados...","Operação Invalida!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex )
            {
                MessageBox.Show("Erro: " + ex,"Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            controle_opcao = 0;

            btnNovo.Enabled = false;
            btnEditar.Enabled = false;

            groupBox2.Enabled = true;
            groupBox3.Enabled = true;
            groupBox4.Enabled = true;
            groupBox5.Enabled = true;

            txtNomeProduto.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            controle_opcao = 1;

            btnNovo.Enabled = false;
            btnEditar.Enabled = false;

            groupBox2.Enabled = true;
            groupBox3.Enabled = true;
            groupBox4.Enabled = true;
            groupBox5.Enabled = true;
        }

        private void btnListar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpaCampo();
        }

        private void LimpaCampo()
        {
            controle_opcao = -1;

            groupBox2.Enabled = false;
            groupBox3.Enabled = false;
            groupBox4.Enabled = false;
            groupBox5.Enabled = false;

            btnNovo.Enabled = true;
            btnEditar.Enabled = true;

            txtCodFornecedor.Clear();
            txtNomeFornecedor.Clear();
            txtCodigoBarra.Clear();
            txtNomeProduto.Clear();
            txtPrazoValidade.Clear();
            txtPesoBruto.Clear();
            txtPesoLiquido.Clear();
            txtEstMaximo.Clear();
            txtEstMinimo.Clear();
            txtId.Clear();

            listaCliente.Clear();
            AtualizaGrid();

            cbTipoProduto.SelectedIndex = -1;
            cbUnidadeMedida.SelectedIndex = -1;
        }

        private void AtualizaGrid()
        {
            gridProduto.DataSource = null;
            gridProduto.DataSource = listaCliente;
            gridProduto.ClearSelection();
            gridProduto.AllowUserToAddRows = false;
        }

        private void gridProduto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    int codigo = Convert.ToInt32(gridProduto.Rows[e.RowIndex].Cells[0].Value);

                    foreach (var item in listaCliente)
                    {
                        if (codigo == item.cli_cod_original)
                        {
                            //Comando que questiona ao usuário se relamente deseja sair do programa
                            DialogResult result = MessageBox.Show("Deseja remover este item?",
                               "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (result == DialogResult.Yes)
                            {
                                listaCliente.Remove(item);
                                AtualizaGrid();
                            }
                        }
                    }
                }
            }
            catch
            {
              //tratamento sem necessidade
            }
        }
    }
}
