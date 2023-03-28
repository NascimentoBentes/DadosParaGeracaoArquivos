
namespace DadosParaGeracaoArquivos
{
    partial class FormGeracaoArquivoTexto
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
            this.lblNrFuncionarios = new System.Windows.Forms.Label();
            this.txtNrFuncionarios = new System.Windows.Forms.TextBox();
            this.btnCriaLinhasRegistro = new System.Windows.Forms.Button();
            this.btnCriaArquivo = new System.Windows.Forms.Button();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.dgvFuncionarios = new System.Windows.Forms.DataGridView();
            this.sfdGravarArquivo = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNrFuncionarios
            // 
            this.lblNrFuncionarios.AutoSize = true;
            this.lblNrFuncionarios.Location = new System.Drawing.Point(13, 23);
            this.lblNrFuncionarios.Name = "lblNrFuncionarios";
            this.lblNrFuncionarios.Size = new System.Drawing.Size(102, 13);
            this.lblNrFuncionarios.TabIndex = 0;
            this.lblNrFuncionarios.Text = "Nr. de Funcionários:";
            // 
            // txtNrFuncionarios
            // 
            this.txtNrFuncionarios.Location = new System.Drawing.Point(114, 19);
            this.txtNrFuncionarios.Name = "txtNrFuncionarios";
            this.txtNrFuncionarios.Size = new System.Drawing.Size(57, 20);
            this.txtNrFuncionarios.TabIndex = 1;
            this.txtNrFuncionarios.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCriaLinhasRegistro
            // 
            this.btnCriaLinhasRegistro.Location = new System.Drawing.Point(177, 19);
            this.btnCriaLinhasRegistro.Name = "btnCriaLinhasRegistro";
            this.btnCriaLinhasRegistro.Size = new System.Drawing.Size(190, 23);
            this.btnCriaLinhasRegistro.TabIndex = 2;
            this.btnCriaLinhasRegistro.Text = "Criar linhas para registro";
            this.btnCriaLinhasRegistro.UseVisualStyleBackColor = true;
            this.btnCriaLinhasRegistro.Click += new System.EventHandler(this.btnCriaLinhasRegistro_Click);
            // 
            // btnCriaArquivo
            // 
            this.btnCriaArquivo.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCriaArquivo.Enabled = false;
            this.btnCriaArquivo.Location = new System.Drawing.Point(16, 403);
            this.btnCriaArquivo.Name = "btnCriaArquivo";
            this.btnCriaArquivo.Size = new System.Drawing.Size(185, 23);
            this.btnCriaArquivo.TabIndex = 3;
            this.btnCriaArquivo.Text = "Criar arquivo";
            this.btnCriaArquivo.UseVisualStyleBackColor = false;
            this.btnCriaArquivo.Click += new System.EventHandler(this.btnCriaArquivo_Click);
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Enabled = false;
            this.btnReiniciar.Location = new System.Drawing.Point(207, 403);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(160, 23);
            this.btnReiniciar.TabIndex = 4;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // dgvFuncionarios
            // 
            this.dgvFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionarios.Location = new System.Drawing.Point(13, 67);
            this.dgvFuncionarios.Name = "dgvFuncionarios";
            this.dgvFuncionarios.Size = new System.Drawing.Size(391, 263);
            this.dgvFuncionarios.TabIndex = 5;
            // 
            // sfdGravarArquivo
            // 
            this.sfdGravarArquivo.DefaultExt = "*.txt";
            this.sfdGravarArquivo.Filter = "Arquivos textos|*.txt";
            this.sfdGravarArquivo.Title = "Dados para geração de arquivos";
            // 
            // FormGeracaoArquivoTexto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 450);
            this.Controls.Add(this.dgvFuncionarios);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.btnCriaArquivo);
            this.Controls.Add(this.btnCriaLinhasRegistro);
            this.Controls.Add(this.txtNrFuncionarios);
            this.Controls.Add(this.lblNrFuncionarios);
            this.Name = "FormGeracaoArquivoTexto";
            this.Text = "Dados para geração de arquivos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNrFuncionarios;
        private System.Windows.Forms.TextBox txtNrFuncionarios;
        private System.Windows.Forms.Button btnCriaLinhasRegistro;
        private System.Windows.Forms.Button btnCriaArquivo;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.DataGridView dgvFuncionarios;
        private System.Windows.Forms.SaveFileDialog sfdGravarArquivo;
    }
}

