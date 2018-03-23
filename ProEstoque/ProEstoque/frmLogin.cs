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

        //EVENTO CLICK DO BOTAO DE CANCELAR
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //FECHA A APLICACAO
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            UsuarioControl control = new UsuarioControl();
            //VERIFICA SE FOI DIGITADO ALGO NOS CAMPOS
            if (txtLogin.Text == "" || txtSenha.Text == "" )
            {
                //EXIBE MENSAGEM CASO O USUARIO NAO DIGITE O LOGIN E SENHA
                MessageBox.Show("Digite o LOGIN e SENHA");
                LimpaCampo();
                return;
            }

            //VERIFICA SE EXISTE O USUARIO CADASTRADO NO BANCO DE DADOS
            if (control.ValidaUsuario(txtLogin.Text, txtSenha.Text))
            {
                //CHAMA A TELA DE MENU
                frmMenu menu = new frmMenu(txtLogin.Text, txtSenha.Text);
                menu.Show();
                //ESCONDE A TELA DE LOGIN
                this.Hide();
            }
            else
            {
                //EXIBE MENSAGEM CASO O LOGIN/SENHA FOR INCORRETOS
                MessageBox.Show("Login/Senha incorretos!");
                LimpaCampo();
                return;
            }
        }

        //METODO DE LIMPAR OS CAMPOS 
        private void LimpaCampo()
        {
            txtLogin.Clear();
            txtSenha.Clear();
            //FOCALIZA O CURSOR NO CAMPO DE LOGIN
            txtLogin.Focus();
        }
    }
}
