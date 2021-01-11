namespace SolucaoCapitulo01
{
    partial class frmTrocaDeValores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTrocaDeValores));
            this.lblPrimeiroValor = new System.Windows.Forms.Label();
            this.txtPrimeiroValor = new System.Windows.Forms.TextBox();
            this.txtSegundoValor = new System.Windows.Forms.TextBox();
            this.lblSegundoValor = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPrimeiroValor
            // 
            this.lblPrimeiroValor.AutoSize = true;
            this.lblPrimeiroValor.Location = new System.Drawing.Point(13, 27);
            this.lblPrimeiroValor.Name = "lblPrimeiroValor";
            this.lblPrimeiroValor.Size = new System.Drawing.Size(43, 13);
            this.lblPrimeiroValor.TabIndex = 0;
            this.lblPrimeiroValor.Text = "Valor 1:";
            // 
            // txtPrimeiroValor
            // 
            this.txtPrimeiroValor.Location = new System.Drawing.Point(54, 24);
            this.txtPrimeiroValor.Name = "txtPrimeiroValor";
            this.txtPrimeiroValor.Size = new System.Drawing.Size(70, 20);
            this.txtPrimeiroValor.TabIndex = 1;
            // 
            // txtSegundoValor
            // 
            this.txtSegundoValor.Location = new System.Drawing.Point(172, 24);
            this.txtSegundoValor.Name = "txtSegundoValor";
            this.txtSegundoValor.Size = new System.Drawing.Size(70, 20);
            this.txtSegundoValor.TabIndex = 2;
            // 
            // lblSegundoValor
            // 
            this.lblSegundoValor.AutoSize = true;
            this.lblSegundoValor.Location = new System.Drawing.Point(131, 27);
            this.lblSegundoValor.Name = "lblSegundoValor";
            this.lblSegundoValor.Size = new System.Drawing.Size(43, 13);
            this.lblSegundoValor.TabIndex = 3;
            this.lblSegundoValor.Text = "Valor 2:";
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(87, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Valor 1";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmTrocaDeValores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 76);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblSegundoValor);
            this.Controls.Add(this.txtSegundoValor);
            this.Controls.Add(this.txtPrimeiroValor);
            this.Controls.Add(this.lblPrimeiroValor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmTrocaDeValores";
            this.Text = "Troca de Valores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrimeiroValor;
        private System.Windows.Forms.TextBox txtPrimeiroValor;
        private System.Windows.Forms.TextBox txtSegundoValor;
        private System.Windows.Forms.Label lblSegundoValor;
        private System.Windows.Forms.Button button1;
    }
}

