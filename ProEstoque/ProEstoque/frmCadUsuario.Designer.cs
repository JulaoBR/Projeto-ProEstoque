namespace ProEstoque
{
    partial class frmCadUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNomeUsuario = new System.Windows.Forms.TextBox();
            this.txtLoginUsuario = new System.Windows.Forms.TextBox();
            this.txtSenhaUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbNivelAcesso = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNovo
            // 
            this.btnNovo.FlatAppearance.BorderSize = 0;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cbNivelAcesso);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtSenhaUsuario);
            this.panel1.Controls.Add(this.txtLoginUsuario);
            this.panel1.Controls.Add(this.txtNomeUsuario);
            this.panel1.Size = new System.Drawing.Size(760, 536);
            this.panel1.Controls.SetChildIndex(this.txtNomeUsuario, 0);
            this.panel1.Controls.SetChildIndex(this.txtLoginUsuario, 0);
            this.panel1.Controls.SetChildIndex(this.txtSenhaUsuario, 0);
            this.panel1.Controls.SetChildIndex(this.label1, 0);
            this.panel1.Controls.SetChildIndex(this.label2, 0);
            this.panel1.Controls.SetChildIndex(this.label3, 0);
            this.panel1.Controls.SetChildIndex(this.cbNivelAcesso, 0);
            this.panel1.Controls.SetChildIndex(this.label4, 0);
            this.panel1.Controls.SetChildIndex(this.comboBox1, 0);
            this.panel1.Controls.SetChildIndex(this.label5, 0);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            // 
            // txtNomeUsuario
            // 
            this.txtNomeUsuario.Location = new System.Drawing.Point(2, 78);
            this.txtNomeUsuario.Name = "txtNomeUsuario";
            this.txtNomeUsuario.Size = new System.Drawing.Size(424, 22);
            this.txtNomeUsuario.TabIndex = 1;
            // 
            // txtLoginUsuario
            // 
            this.txtLoginUsuario.Location = new System.Drawing.Point(2, 119);
            this.txtLoginUsuario.Name = "txtLoginUsuario";
            this.txtLoginUsuario.Size = new System.Drawing.Size(424, 22);
            this.txtLoginUsuario.TabIndex = 2;
            // 
            // txtSenhaUsuario
            // 
            this.txtSenhaUsuario.Location = new System.Drawing.Point(2, 160);
            this.txtSenhaUsuario.Name = "txtSenhaUsuario";
            this.txtSenhaUsuario.Size = new System.Drawing.Size(424, 22);
            this.txtSenhaUsuario.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome*:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Login*:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Senha*:";
            // 
            // cbNivelAcesso
            // 
            this.cbNivelAcesso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNivelAcesso.FormattingEnabled = true;
            this.cbNivelAcesso.Location = new System.Drawing.Point(2, 220);
            this.cbNivelAcesso.Name = "cbNivelAcesso";
            this.cbNivelAcesso.Size = new System.Drawing.Size(272, 25);
            this.cbNivelAcesso.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nivel de acesso:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "SIM",
            "NÃO"});
            this.comboBox1.Location = new System.Drawing.Point(2, 295);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(272, 25);
            this.comboBox1.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(222, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Atualizar senha primeiro acesso:";
            // 
            // frmCadUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(911, 560);
            this.Name = "frmCadUsuario";
            this.Text = "CADASTRO DE USUÁRIOS";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSenhaUsuario;
        private System.Windows.Forms.TextBox txtLoginUsuario;
        private System.Windows.Forms.TextBox txtNomeUsuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbNivelAcesso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
