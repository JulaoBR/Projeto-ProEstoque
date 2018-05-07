using ProEstoque.CONTROL;
using System;
using System.Windows.Forms;

namespace ProEstoque
{
    public partial class frmCadCliente : ProEstoque.frmCadastro
    {
        public frmCadCliente()
        {
            InitializeComponent();
        }

        private void frmCadCliente_Load(object sender, EventArgs e)
        {
            CarregaEstado();
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
    }
}
