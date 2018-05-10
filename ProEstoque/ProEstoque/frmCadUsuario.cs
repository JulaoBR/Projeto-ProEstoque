using ProEstoque.CONTROL;
using ProEstoque.MODEL;
using System;
using System.Windows.Forms;


namespace ProEstoque
{
    public partial class frmCadUsuario : ProEstoque.frmCadastro
    {
        private int controle_opcao = -1;

        public frmCadUsuario()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            controle_opcao = 0;

            btnNovo.Enabled = false;
            btnEditar.Enabled = false;

            groupBox1.Enabled = true;
            groupBox2.Enabled = true;

            txtNomeUsuario.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            controle_opcao = 1;

            btnNovo.Enabled = false;
            btnEditar.Enabled = false;

            groupBox1.Enabled = true;
            groupBox2.Enabled = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                UsuarioModel usuario = new UsuarioModel();
                UsuarioControl control = new UsuarioControl();

                usuario.usu_nome = txtNomeUsuario.Text;
                usuario.usu_telefone = txtTelefoneUsuario.Text;
                usuario.usu_login = txtLoginUsuario.Text;
                usuario.usu_senha = txtSenhaUsuario.Text;

                control.Inserir(usuario);
            }
            catch(Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex),"Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }         
        }

        private void frmCadUsuario_Load(object sender, EventArgs e)
        {
            LimpaCampo();
        }

        private void frmCadUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpaCampo();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void btnListar_Click(object sender, EventArgs e)
        {

        }

        private void LimpaCampo()
        {
            controle_opcao = -1;

            btnNovo.Enabled = true;
            btnEditar.Enabled = true;

            groupBox1.Enabled = false;
            groupBox2.Enabled = false;

            txtId.Clear();
            txtNomeUsuario.Clear();
            txtTelefoneUsuario.Clear();
            txtLoginUsuario.Clear();
            txtSenhaUsuario.Clear();

            cbAtualizarSenha.SelectedIndex = -1;
            cbNivelAcesso.SelectedIndex = -1;
        }


    }
}
