namespace ProEstoque
{
    partial class frmCadFornecedor
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCnpj = new System.Windows.Forms.TextBox();
            this.txtApelido = new System.Windows.Forms.TextBox();
            this.txtRazaoSocial = new System.Windows.Forms.TextBox();
            this.txtCodFornecedor = new System.Windows.Forms.TextBox();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            // btnListar
            // 
            this.btnListar.FlatAppearance.BorderSize = 0;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.SetChildIndex(this.panel3, 0);
            this.panel1.Controls.SetChildIndex(this.groupBox1, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCnpj);
            this.groupBox1.Controls.Add(this.txtApelido);
            this.groupBox1.Controls.Add(this.txtRazaoSocial);
            this.groupBox1.Controls.Add(this.txtCodFornecedor);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(4, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(744, 227);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do fornecedor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Cnpj *:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Apelido:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(142, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Razão Social *:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Código *:";
            // 
            // txtCnpj
            // 
            this.txtCnpj.Location = new System.Drawing.Point(6, 148);
            this.txtCnpj.MaxLength = 11;
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Size = new System.Drawing.Size(322, 23);
            this.txtCnpj.TabIndex = 3;
            this.txtCnpj.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCnpj_KeyPress);
            // 
            // txtApelido
            // 
            this.txtApelido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApelido.Location = new System.Drawing.Point(6, 94);
            this.txtApelido.MaxLength = 100;
            this.txtApelido.Name = "txtApelido";
            this.txtApelido.Size = new System.Drawing.Size(732, 23);
            this.txtApelido.TabIndex = 2;
            // 
            // txtRazaoSocial
            // 
            this.txtRazaoSocial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRazaoSocial.Location = new System.Drawing.Point(145, 40);
            this.txtRazaoSocial.MaxLength = 100;
            this.txtRazaoSocial.Name = "txtRazaoSocial";
            this.txtRazaoSocial.Size = new System.Drawing.Size(593, 23);
            this.txtRazaoSocial.TabIndex = 1;
            // 
            // txtCodFornecedor
            // 
            this.txtCodFornecedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtCodFornecedor.Location = new System.Drawing.Point(6, 40);
            this.txtCodFornecedor.MaxLength = 6;
            this.txtCodFornecedor.Name = "txtCodFornecedor";
            this.txtCodFornecedor.ReadOnly = true;
            this.txtCodFornecedor.Size = new System.Drawing.Size(114, 23);
            this.txtCodFornecedor.TabIndex = 0;
            this.txtCodFornecedor.TabStop = false;
            this.txtCodFornecedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodFornecedor_KeyPress);
            // 
            // frmCadFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 560);
            this.KeyPreview = true;
            this.Name = "frmCadFornecedor";
            this.Text = "CADASTRO DE FORNECEDOR";
            this.Load += new System.EventHandler(this.frmCadFornecedor_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCadFornecedor_KeyDown);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtCnpj;
        public System.Windows.Forms.TextBox txtApelido;
        public System.Windows.Forms.TextBox txtRazaoSocial;
        public System.Windows.Forms.TextBox txtCodFornecedor;
        public System.Windows.Forms.GroupBox groupBox1;
    }
}