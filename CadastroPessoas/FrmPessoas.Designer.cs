namespace CadastroPessoas
{
    partial class FrmPessoas
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvPessoas = new System.Windows.Forms.DataGridView();
            this.btnAdicionarPessoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPessoas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPessoas
            // 
            this.dgvPessoas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPessoas.Location = new System.Drawing.Point(12, 12);
            this.dgvPessoas.Name = "dgvPessoas";
            this.dgvPessoas.Size = new System.Drawing.Size(668, 194);
            this.dgvPessoas.TabIndex = 0;
            // 
            // btnAdicionarPessoa
            // 
            this.btnAdicionarPessoa.Location = new System.Drawing.Point(13, 213);
            this.btnAdicionarPessoa.Name = "btnAdicionarPessoa";
            this.btnAdicionarPessoa.Size = new System.Drawing.Size(110, 23);
            this.btnAdicionarPessoa.TabIndex = 1;
            this.btnAdicionarPessoa.Text = "Adicionar Pessoa";
            this.btnAdicionarPessoa.UseVisualStyleBackColor = true;
            this.btnAdicionarPessoa.Click += new System.EventHandler(this.btnAdicionarPessoa_Click);
            // 
            // FrmPessoas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 245);
            this.Controls.Add(this.btnAdicionarPessoa);
            this.Controls.Add(this.dgvPessoas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "FrmPessoas";
            this.Text = "Cadastro de Pessoas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPessoas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPessoas;
        private System.Windows.Forms.Button btnAdicionarPessoa;
    }
}

