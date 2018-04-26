namespace ProEstoque
{
    partial class frmConfiguracaoADM
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnListaUnidadeMedida = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExcluirUnidadeMedida = new System.Windows.Forms.Button();
            this.btnSalvaUnidadeMedida = new System.Windows.Forms.Button();
            this.txtDescUnidadeMedida = new System.Windows.Forms.TextBox();
            this.txtCodUnidadeMedida = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnListaTipoProduto = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescTipo = new System.Windows.Forms.TextBox();
            this.txtCodTipo = new System.Windows.Forms.TextBox();
            this.btnExcluirTipo = new System.Windows.Forms.Button();
            this.btnSalvarTipo = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.rbNovoCadastro = new System.Windows.Forms.RadioButton();
            this.rbEditar = new System.Windows.Forms.RadioButton();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 40);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(760, 441);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightGray;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage1.Controls.Add(this.btnListaUnidadeMedida);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnExcluirUnidadeMedida);
            this.tabPage1.Controls.Add(this.btnSalvaUnidadeMedida);
            this.tabPage1.Controls.Add(this.txtDescUnidadeMedida);
            this.tabPage1.Controls.Add(this.txtCodUnidadeMedida);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(752, 411);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "CAD UNIDADE DE MED";
            // 
            // btnListaUnidadeMedida
            // 
            this.btnListaUnidadeMedida.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListaUnidadeMedida.Location = new System.Drawing.Point(667, 370);
            this.btnListaUnidadeMedida.Name = "btnListaUnidadeMedida";
            this.btnListaUnidadeMedida.Size = new System.Drawing.Size(75, 31);
            this.btnListaUnidadeMedida.TabIndex = 7;
            this.btnListaUnidadeMedida.Text = "LISTAR";
            this.btnListaUnidadeMedida.UseVisualStyleBackColor = true;
            this.btnListaUnidadeMedida.Click += new System.EventHandler(this.btnListaUnidadeMedida_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Descrição da unidade de medida*:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Código:";
            // 
            // btnExcluirUnidadeMedida
            // 
            this.btnExcluirUnidadeMedida.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirUnidadeMedida.Location = new System.Drawing.Point(586, 370);
            this.btnExcluirUnidadeMedida.Name = "btnExcluirUnidadeMedida";
            this.btnExcluirUnidadeMedida.Size = new System.Drawing.Size(75, 31);
            this.btnExcluirUnidadeMedida.TabIndex = 4;
            this.btnExcluirUnidadeMedida.Text = "EXCLUIR";
            this.btnExcluirUnidadeMedida.UseVisualStyleBackColor = true;
            // 
            // btnSalvaUnidadeMedida
            // 
            this.btnSalvaUnidadeMedida.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvaUnidadeMedida.Location = new System.Drawing.Point(505, 370);
            this.btnSalvaUnidadeMedida.Name = "btnSalvaUnidadeMedida";
            this.btnSalvaUnidadeMedida.Size = new System.Drawing.Size(75, 31);
            this.btnSalvaUnidadeMedida.TabIndex = 3;
            this.btnSalvaUnidadeMedida.Text = "SALVAR";
            this.btnSalvaUnidadeMedida.UseVisualStyleBackColor = true;
            this.btnSalvaUnidadeMedida.Click += new System.EventHandler(this.btnSalvaUnidadeMedida_Click);
            // 
            // txtDescUnidadeMedida
            // 
            this.txtDescUnidadeMedida.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescUnidadeMedida.Location = new System.Drawing.Point(6, 73);
            this.txtDescUnidadeMedida.MaxLength = 100;
            this.txtDescUnidadeMedida.Name = "txtDescUnidadeMedida";
            this.txtDescUnidadeMedida.Size = new System.Drawing.Size(736, 23);
            this.txtDescUnidadeMedida.TabIndex = 2;
            // 
            // txtCodUnidadeMedida
            // 
            this.txtCodUnidadeMedida.Location = new System.Drawing.Point(6, 22);
            this.txtCodUnidadeMedida.Name = "txtCodUnidadeMedida";
            this.txtCodUnidadeMedida.ReadOnly = true;
            this.txtCodUnidadeMedida.Size = new System.Drawing.Size(100, 23);
            this.txtCodUnidadeMedida.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightGray;
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage2.Controls.Add(this.btnListaTipoProduto);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.txtDescTipo);
            this.tabPage2.Controls.Add(this.txtCodTipo);
            this.tabPage2.Controls.Add(this.btnExcluirTipo);
            this.tabPage2.Controls.Add(this.btnSalvarTipo);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(752, 411);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "CAD TIPO PROD";
            // 
            // btnListaTipoProduto
            // 
            this.btnListaTipoProduto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListaTipoProduto.Location = new System.Drawing.Point(666, 370);
            this.btnListaTipoProduto.Name = "btnListaTipoProduto";
            this.btnListaTipoProduto.Size = new System.Drawing.Size(75, 31);
            this.btnListaTipoProduto.TabIndex = 14;
            this.btnListaTipoProduto.Text = "LISTAR";
            this.btnListaTipoProduto.UseVisualStyleBackColor = true;
            this.btnListaTipoProduto.Click += new System.EventHandler(this.btnListaTipoProduto_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Descrição do tipo de produto*:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Código:";
            // 
            // txtDescTipo
            // 
            this.txtDescTipo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescTipo.Location = new System.Drawing.Point(5, 74);
            this.txtDescTipo.MaxLength = 100;
            this.txtDescTipo.Name = "txtDescTipo";
            this.txtDescTipo.Size = new System.Drawing.Size(736, 23);
            this.txtDescTipo.TabIndex = 11;
            // 
            // txtCodTipo
            // 
            this.txtCodTipo.Location = new System.Drawing.Point(5, 23);
            this.txtCodTipo.Name = "txtCodTipo";
            this.txtCodTipo.ReadOnly = true;
            this.txtCodTipo.Size = new System.Drawing.Size(100, 23);
            this.txtCodTipo.TabIndex = 10;
            // 
            // btnExcluirTipo
            // 
            this.btnExcluirTipo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirTipo.Location = new System.Drawing.Point(585, 370);
            this.btnExcluirTipo.Name = "btnExcluirTipo";
            this.btnExcluirTipo.Size = new System.Drawing.Size(75, 31);
            this.btnExcluirTipo.TabIndex = 9;
            this.btnExcluirTipo.Text = "EXCLUIR";
            this.btnExcluirTipo.UseVisualStyleBackColor = true;
            this.btnExcluirTipo.Click += new System.EventHandler(this.btnExcluirTipo_Click);
            // 
            // btnSalvarTipo
            // 
            this.btnSalvarTipo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarTipo.Location = new System.Drawing.Point(504, 370);
            this.btnSalvarTipo.Name = "btnSalvarTipo";
            this.btnSalvarTipo.Size = new System.Drawing.Size(75, 31);
            this.btnSalvarTipo.TabIndex = 8;
            this.btnSalvarTipo.Text = "SALVAR";
            this.btnSalvarTipo.UseVisualStyleBackColor = true;
            this.btnSalvarTipo.Click += new System.EventHandler(this.btnSalvarTipo_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage3.Location = new System.Drawing.Point(4, 26);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(752, 411);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "CAD GRUPO USU";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage4.Location = new System.Drawing.Point(4, 26);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(752, 411);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "CONFI MENU";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 26);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(752, 411);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "CAD MOTIVOS DE TROCA";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // rbNovoCadastro
            // 
            this.rbNovoCadastro.AutoSize = true;
            this.rbNovoCadastro.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNovoCadastro.Location = new System.Drawing.Point(523, 12);
            this.rbNovoCadastro.Name = "rbNovoCadastro";
            this.rbNovoCadastro.Size = new System.Drawing.Size(159, 22);
            this.rbNovoCadastro.TabIndex = 1;
            this.rbNovoCadastro.TabStop = true;
            this.rbNovoCadastro.Text = "NOVO CADASTRO";
            this.rbNovoCadastro.UseVisualStyleBackColor = true;
            this.rbNovoCadastro.CheckedChanged += new System.EventHandler(this.rbNovoCadastro_CheckedChanged);
            // 
            // rbEditar
            // 
            this.rbEditar.AutoSize = true;
            this.rbEditar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEditar.Location = new System.Drawing.Point(697, 12);
            this.rbEditar.Name = "rbEditar";
            this.rbEditar.Size = new System.Drawing.Size(75, 22);
            this.rbEditar.TabIndex = 2;
            this.rbEditar.TabStop = true;
            this.rbEditar.Text = "EDITAR";
            this.rbEditar.UseVisualStyleBackColor = true;
            this.rbEditar.CheckedChanged += new System.EventHandler(this.rbEditar_CheckedChanged);
            // 
            // frmConfiguracaoADM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 493);
            this.Controls.Add(this.rbEditar);
            this.Controls.Add(this.rbNovoCadastro);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmConfiguracaoADM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADMINISTRADOR";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TextBox txtCodUnidadeMedida;
        private System.Windows.Forms.TextBox txtDescUnidadeMedida;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExcluirUnidadeMedida;
        private System.Windows.Forms.Button btnSalvaUnidadeMedida;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescTipo;
        private System.Windows.Forms.TextBox txtCodTipo;
        private System.Windows.Forms.Button btnExcluirTipo;
        private System.Windows.Forms.Button btnSalvarTipo;
        private System.Windows.Forms.Button btnListaUnidadeMedida;
        private System.Windows.Forms.Button btnListaTipoProduto;
        private System.Windows.Forms.RadioButton rbNovoCadastro;
        private System.Windows.Forms.RadioButton rbEditar;
    }
}