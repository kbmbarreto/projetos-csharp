
namespace MatriculaAluno
{
    partial class frmMatriculaAluno
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblAnoNascimento = new System.Windows.Forms.Label();
            this.lblAnoAniversario = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtAnoAniversario = new System.Windows.Forms.TextBox();
            this.txtAnoNascimento = new System.Windows.Forms.TextBox();
            this.btnIdentificarCategoria = new System.Windows.Forms.Button();
            this.lblCategoriaResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(23, 20);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(45, 17);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // lblAnoNascimento
            // 
            this.lblAnoNascimento.AutoSize = true;
            this.lblAnoNascimento.Location = new System.Drawing.Point(23, 64);
            this.lblAnoNascimento.Name = "lblAnoNascimento";
            this.lblAnoNascimento.Size = new System.Drawing.Size(109, 17);
            this.lblAnoNascimento.TabIndex = 1;
            this.lblAnoNascimento.Text = "Ano nascimento";
            // 
            // lblAnoAniversario
            // 
            this.lblAnoAniversario.AutoSize = true;
            this.lblAnoAniversario.Location = new System.Drawing.Point(268, 64);
            this.lblAnoAniversario.Name = "lblAnoAniversario";
            this.lblAnoAniversario.Size = new System.Drawing.Size(148, 17);
            this.lblAnoAniversario.TabIndex = 2;
            this.lblAnoAniversario.Text = "Ano ultimo aniversário";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(268, 104);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(69, 17);
            this.lblCategoria.TabIndex = 3;
            this.lblCategoria.Text = "Categoria";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(75, 17);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(447, 22);
            this.txtNome.TabIndex = 4;
            // 
            // txtAnoAniversario
            // 
            this.txtAnoAniversario.Location = new System.Drawing.Point(422, 61);
            this.txtAnoAniversario.Name = "txtAnoAniversario";
            this.txtAnoAniversario.Size = new System.Drawing.Size(100, 22);
            this.txtAnoAniversario.TabIndex = 6;
            this.txtAnoAniversario.Enter += new System.EventHandler(this.txtAnoAniversario_Enter);
            this.txtAnoAniversario.Validating += new System.ComponentModel.CancelEventHandler(this.txtAnoAniversario_Validating);
            // 
            // txtAnoNascimento
            // 
            this.txtAnoNascimento.Location = new System.Drawing.Point(140, 61);
            this.txtAnoNascimento.Name = "txtAnoNascimento";
            this.txtAnoNascimento.Size = new System.Drawing.Size(100, 22);
            this.txtAnoNascimento.TabIndex = 7;
            // 
            // btnIdentificarCategoria
            // 
            this.btnIdentificarCategoria.Location = new System.Drawing.Point(26, 102);
            this.btnIdentificarCategoria.Name = "btnIdentificarCategoria";
            this.btnIdentificarCategoria.Size = new System.Drawing.Size(214, 31);
            this.btnIdentificarCategoria.TabIndex = 8;
            this.btnIdentificarCategoria.Text = "Identificar Categoria";
            this.btnIdentificarCategoria.UseVisualStyleBackColor = true;
            this.btnIdentificarCategoria.Click += new System.EventHandler(this.btnIdentificarCategoria_Click);
            // 
            // lblCategoriaResult
            // 
            this.lblCategoriaResult.AutoSize = true;
            this.lblCategoriaResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCategoriaResult.Location = new System.Drawing.Point(388, 109);
            this.lblCategoriaResult.Name = "lblCategoriaResult";
            this.lblCategoriaResult.Size = new System.Drawing.Size(2, 19);
            this.lblCategoriaResult.TabIndex = 9;
            // 
            // frmMatriculaAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 155);
            this.Controls.Add(this.lblCategoriaResult);
            this.Controls.Add(this.btnIdentificarCategoria);
            this.Controls.Add(this.txtAnoNascimento);
            this.Controls.Add(this.txtAnoAniversario);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblAnoAniversario);
            this.Controls.Add(this.lblAnoNascimento);
            this.Controls.Add(this.lblNome);
            this.Name = "frmMatriculaAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Matrícula de Aluno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblAnoNascimento;
        private System.Windows.Forms.Label lblAnoAniversario;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtAnoAniversario;
        private System.Windows.Forms.TextBox txtAnoNascimento;
        private System.Windows.Forms.Button btnIdentificarCategoria;
        private System.Windows.Forms.Label lblCategoriaResult;
    }
}

