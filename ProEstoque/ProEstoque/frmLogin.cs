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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            UsuarioControl control = new UsuarioControl();
            //VERIFICA SE FOI DIGITADO ALGO NOS CAMPOS
            if (txtLogin.Text == "" || txtSenha.Text == "" )
            {
                MessageBox.Show("Digite o LOGIN e SENHA");
                LimpaCampo();
                return;
            }

            //VERIFICA SE EXISTE O USUARIO CADASTRADO NO BANCO DE DADOS
            if (control.ValidaUsuario(txtLogin.Text, txtSenha.Text))
            {
                frmMenu menu = new frmMenu();
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login/Senha incorretos!");
                LimpaCampo();
                return;
            }
        }

        private void LimpaCampo()
        {
            txtLogin.Clear();
            txtSenha.Clear();

            txtLogin.Focus();
        }
    }
}
