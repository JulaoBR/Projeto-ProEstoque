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
    public partial class frmListaCadastrosAdm : Form
    {
        //VARIAVEL PARA GUARDAR A OPÇÃO DO TIPO DE DADO A SER CARREGADO
        private int opcao;
        public int codigo;

        public frmListaCadastrosAdm(int opcao)
        {
            InitializeComponent();
            //CARREGA A OPCAO ESCOLHIDA 
            this.opcao = opcao;
        }


        //EVENTO DE LOAD DO FORMULARIO
        private void frmListaCadastrosAdm_Load(object sender, EventArgs e)
        {   
            try
            {
                UnidadeMedidaControl unidade = new UnidadeMedidaControl();
                TipoProdutoControl tipo = new TipoProdutoControl();

                //VERIFICA A OPCAO PARA CARREGAMENTO DOS DADOS
                switch (opcao)
                {
                    case 1:
                        PreencheGrid(unidade.Select());
                        break;
                    case 2:
                        PreencheGrid(tipo.Select());
                        break;
                    case 3:

                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex,"Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {

            }
                          
        }

        //EVENTO DE DUBLO CLICK NO GRID
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    this.codigo = Convert.ToInt32(gridCadastros.Rows[e.RowIndex].Cells[0].Value);
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Sem dados para selecionar!!", "Operação Invalida!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //METODO DE PREENCHER O GRID COM OS DADOS
        private void PreencheGrid(DataTable dt)
        {
            gridCadastros.DataSource = null;
            gridCadastros.Refresh();
            gridCadastros.DataSource = dt;
            gridCadastros.ClearSelection();
            gridCadastros.AllowUserToAddRows = false;
        }
    }
}
