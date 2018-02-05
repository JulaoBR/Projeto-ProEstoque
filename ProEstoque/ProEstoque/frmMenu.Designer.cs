namespace ProEstoque
{
    partial class frmMenu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMovimentacao = new System.Windows.Forms.Button();
            this.btnVendas = new System.Windows.Forms.Button();
            this.btnCompras = new System.Windows.Forms.Button();
            this.btnEstoque = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cADASTROSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuáriosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.vENDASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mOVIMENTAÇÃOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mOVIMENTAÇÃOToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cONFIGURAÇÃOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sAIRLOGOUTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lOGOUTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sAIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnMovimentacao);
            this.panel1.Controls.Add(this.btnVendas);
            this.panel1.Controls.Add(this.btnCompras);
            this.panel1.Controls.Add(this.btnEstoque);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 581);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 481);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "ProEstoque";
            // 
            // btnMovimentacao
            // 
            this.btnMovimentacao.FlatAppearance.BorderSize = 0;
            this.btnMovimentacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMovimentacao.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMovimentacao.ForeColor = System.Drawing.Color.White;
            this.btnMovimentacao.Location = new System.Drawing.Point(3, 288);
            this.btnMovimentacao.Name = "btnMovimentacao";
            this.btnMovimentacao.Size = new System.Drawing.Size(194, 89);
            this.btnMovimentacao.TabIndex = 6;
            this.btnMovimentacao.Text = "Movimentação";
            this.btnMovimentacao.UseVisualStyleBackColor = true;
            this.btnMovimentacao.Click += new System.EventHandler(this.btnMovimentacao_Click);
            // 
            // btnVendas
            // 
            this.btnVendas.FlatAppearance.BorderSize = 0;
            this.btnVendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVendas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVendas.ForeColor = System.Drawing.Color.White;
            this.btnVendas.Location = new System.Drawing.Point(0, 3);
            this.btnVendas.Name = "btnVendas";
            this.btnVendas.Size = new System.Drawing.Size(194, 89);
            this.btnVendas.TabIndex = 3;
            this.btnVendas.Text = "Vendas";
            this.btnVendas.UseVisualStyleBackColor = true;
            // 
            // btnCompras
            // 
            this.btnCompras.FlatAppearance.BorderSize = 0;
            this.btnCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompras.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompras.ForeColor = System.Drawing.Color.White;
            this.btnCompras.Location = new System.Drawing.Point(6, 193);
            this.btnCompras.Name = "btnCompras";
            this.btnCompras.Size = new System.Drawing.Size(194, 89);
            this.btnCompras.TabIndex = 5;
            this.btnCompras.Text = "Compras";
            this.btnCompras.UseVisualStyleBackColor = true;
            // 
            // btnEstoque
            // 
            this.btnEstoque.FlatAppearance.BorderSize = 0;
            this.btnEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstoque.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstoque.ForeColor = System.Drawing.Color.White;
            this.btnEstoque.Location = new System.Drawing.Point(3, 98);
            this.btnEstoque.Name = "btnEstoque";
            this.btnEstoque.Size = new System.Drawing.Size(194, 89);
            this.btnEstoque.TabIndex = 4;
            this.btnEstoque.Text = "Estoque";
            this.btnEstoque.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Silver;
            this.menuStrip1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cADASTROSToolStripMenuItem,
            this.vENDASToolStripMenuItem,
            this.mOVIMENTAÇÃOToolStripMenuItem,
            this.cONFIGURAÇÃOToolStripMenuItem,
            this.sAIRLOGOUTToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1179, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cADASTROSToolStripMenuItem
            // 
            this.cADASTROSToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.cADASTROSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuáriosToolStripMenuItem,
            this.produtosToolStripMenuItem,
            this.usuáriosToolStripMenuItem1});
            this.cADASTROSToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.cADASTROSToolStripMenuItem.Name = "cADASTROSToolStripMenuItem";
            this.cADASTROSToolStripMenuItem.Size = new System.Drawing.Size(95, 21);
            this.cADASTROSToolStripMenuItem.Text = "CADASTROS";
            // 
            // usuáriosToolStripMenuItem
            // 
            this.usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            this.usuáriosToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.usuáriosToolStripMenuItem.Text = "CLIENTES";
            this.usuáriosToolStripMenuItem.Click += new System.EventHandler(this.usuáriosToolStripMenuItem_Click);
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.produtosToolStripMenuItem.Text = "PRODUTOS";
            this.produtosToolStripMenuItem.Click += new System.EventHandler(this.produtosToolStripMenuItem_Click);
            // 
            // usuáriosToolStripMenuItem1
            // 
            this.usuáriosToolStripMenuItem1.Name = "usuáriosToolStripMenuItem1";
            this.usuáriosToolStripMenuItem1.Size = new System.Drawing.Size(143, 22);
            this.usuáriosToolStripMenuItem1.Text = "USUÁRIOS";
            this.usuáriosToolStripMenuItem1.Click += new System.EventHandler(this.usuáriosToolStripMenuItem1_Click);
            // 
            // vENDASToolStripMenuItem
            // 
            this.vENDASToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.vENDASToolStripMenuItem.Name = "vENDASToolStripMenuItem";
            this.vENDASToolStripMenuItem.Size = new System.Drawing.Size(71, 21);
            this.vENDASToolStripMenuItem.Text = "VENDAS";
            // 
            // mOVIMENTAÇÃOToolStripMenuItem
            // 
            this.mOVIMENTAÇÃOToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mOVIMENTAÇÃOToolStripMenuItem1});
            this.mOVIMENTAÇÃOToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.mOVIMENTAÇÃOToolStripMenuItem.Name = "mOVIMENTAÇÃOToolStripMenuItem";
            this.mOVIMENTAÇÃOToolStripMenuItem.Size = new System.Drawing.Size(127, 21);
            this.mOVIMENTAÇÃOToolStripMenuItem.Text = "MOVIMENTAÇÃO";
            // 
            // mOVIMENTAÇÃOToolStripMenuItem1
            // 
            this.mOVIMENTAÇÃOToolStripMenuItem1.Name = "mOVIMENTAÇÃOToolStripMenuItem1";
            this.mOVIMENTAÇÃOToolStripMenuItem1.Size = new System.Drawing.Size(183, 22);
            this.mOVIMENTAÇÃOToolStripMenuItem1.Text = "MOVIMENTAÇÃO";
            this.mOVIMENTAÇÃOToolStripMenuItem1.Click += new System.EventHandler(this.mOVIMENTAÇÃOToolStripMenuItem1_Click);
            // 
            // cONFIGURAÇÃOToolStripMenuItem
            // 
            this.cONFIGURAÇÃOToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.cONFIGURAÇÃOToolStripMenuItem.Name = "cONFIGURAÇÃOToolStripMenuItem";
            this.cONFIGURAÇÃOToolStripMenuItem.Size = new System.Drawing.Size(128, 21);
            this.cONFIGURAÇÃOToolStripMenuItem.Text = "CONFIGURAÇÃO";
            // 
            // sAIRLOGOUTToolStripMenuItem
            // 
            this.sAIRLOGOUTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lOGOUTToolStripMenuItem,
            this.sAIRToolStripMenuItem});
            this.sAIRLOGOUTToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.sAIRLOGOUTToolStripMenuItem.Name = "sAIRLOGOUTToolStripMenuItem";
            this.sAIRLOGOUTToolStripMenuItem.Size = new System.Drawing.Size(104, 21);
            this.sAIRLOGOUTToolStripMenuItem.Text = "SAIR/LOGOUT";
            // 
            // lOGOUTToolStripMenuItem
            // 
            this.lOGOUTToolStripMenuItem.Name = "lOGOUTToolStripMenuItem";
            this.lOGOUTToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.lOGOUTToolStripMenuItem.Text = "LOGOUT";
            this.lOGOUTToolStripMenuItem.Click += new System.EventHandler(this.lOGOUTToolStripMenuItem_Click);
            // 
            // sAIRToolStripMenuItem
            // 
            this.sAIRToolStripMenuItem.Name = "sAIRToolStripMenuItem";
            this.sAIRToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.sAIRToolStripMenuItem.Text = "SAIR";
            this.sAIRToolStripMenuItem.Click += new System.EventHandler(this.sAIRToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(200, 584);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(979, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(100, 17);
            this.toolStripStatusLabel1.Text = "Usuário logado:";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel2.ForeColor = System.Drawing.Color.Blue;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(82, 17);
            this.toolStripStatusLabel2.Text = "JULIO CESAR";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 606);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMovimentacao;
        private System.Windows.Forms.Button btnCompras;
        private System.Windows.Forms.Button btnEstoque;
        private System.Windows.Forms.Button btnVendas;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cADASTROSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuáriosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mOVIMENTAÇÃOToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripMenuItem sAIRLOGOUTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sAIRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lOGOUTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vENDASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cONFIGURAÇÃOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mOVIMENTAÇÃOToolStripMenuItem1;
    }
}

