namespace ProEstoque
{
    partial class frmCadMedida
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
            this.gridUnidadeMedida = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodUniMedida = new System.Windows.Forms.TextBox();
            this.txtNomeUniMedida = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridUnidadeMedida)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtNomeUniMedida);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtCodUniMedida);
            this.panel1.Controls.SetChildIndex(this.txtCodUniMedida, 0);
            this.panel1.Controls.SetChildIndex(this.label3, 0);
            this.panel1.Controls.SetChildIndex(this.txtNomeUniMedida, 0);
            this.panel1.Controls.SetChildIndex(this.label1, 0);
            // 
            // gridUnidadeMedida
            // 
            this.gridUnidadeMedida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridUnidadeMedida.Location = new System.Drawing.Point(14, 227);
            this.gridUnidadeMedida.Name = "gridUnidadeMedida";
            this.gridUnidadeMedida.Size = new System.Drawing.Size(719, 278);
            this.gridUnidadeMedida.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Código*:";
            // 
            // txtCodUniMedida
            // 
            this.txtCodUniMedida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtCodUniMedida.Enabled = false;
            this.txtCodUniMedida.Location = new System.Drawing.Point(6, 28);
            this.txtCodUniMedida.Name = "txtCodUniMedida";
            this.txtCodUniMedida.Size = new System.Drawing.Size(83, 21);
            this.txtCodUniMedida.TabIndex = 9;
            // 
            // txtNomeUniMedida
            // 
            this.txtNomeUniMedida.Location = new System.Drawing.Point(6, 83);
            this.txtNomeUniMedida.Name = "txtNomeUniMedida";
            this.txtNomeUniMedida.Size = new System.Drawing.Size(486, 21);
            this.txtNomeUniMedida.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Digite a unidade de medida*:";
            // 
            // frmCadMedida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.ClientSize = new System.Drawing.Size(745, 517);
            this.Controls.Add(this.gridUnidadeMedida);
            this.Name = "frmCadMedida";
            this.Text = "CADASTRO DE UNIDADE DE MEDIDA";
            this.Controls.SetChildIndex(this.btnNovo, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.btnExcluir, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.gridUnidadeMedida, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridUnidadeMedida)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridUnidadeMedida;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodUniMedida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeUniMedida;
    }
}
