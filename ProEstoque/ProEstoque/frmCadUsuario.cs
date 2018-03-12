using ProEstoque.CONTROL;
using ProEstoque.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProEstoque
{
    public partial class frmCadUsuario : ProEstoque.frmCadastro
    {
        public frmCadUsuario()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            UsuarioModel usuario = new UsuarioModel();
            UsuarioControl control = new UsuarioControl();

            usuario.usu_nome = txtNomeUsuario.Text;
            usuario.usu_telefone = txtTelefoneUsuario.Text;
            usuario.usu_login = txtLoginUsuario.Text;
            usuario.usu_senha = txtSenhaUsuario.Text;

            control.Inserir(usuario);
        }

    }
}
