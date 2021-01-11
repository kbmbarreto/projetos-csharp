namespace RestoDaDivisao
{
    partial class frmRestoDivisao
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
            this.lblDividendo = new System.Windows.Forms.Label();
            this.lblDivisor = new System.Windows.Forms.Label();
            this.lblResto = new System.Windows.Forms.Label();
            this.txtDividendo = new System.Windows.Forms.TextBox();
            this.txtDivisor = new System.Windows.Forms.TextBox();
            this.txtResto = new System.Windows.Forms.TextBox();
            this.btnRealizarDivisao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDividendo
            // 
            this.lblDividendo.AutoSize = true;
            this.lblDividendo.Location = new System.Drawing.Point(12, 28);
            this.lblDividendo.Name = "lblDividendo";
            this.lblDividendo.Size = new System.Drawing.Size(58, 13);
            this.lblDividendo.TabIndex = 0;
            this.lblDividendo.Text = "Dividendo:";
            // 
            // lblDivisor
            // 
            this.lblDivisor.AutoSize = true;
            this.lblDivisor.Location = new System.Drawing.Point(185, 28);
            this.lblDivisor.Name = "lblDivisor";
            this.lblDivisor.Size = new System.Drawing.Size(42, 13);
            this.lblDivisor.TabIndex = 1;
            this.lblDivisor.Text = "Divisor:";
            // 
            // lblResto
            // 
            this.lblResto.AutoSize = true;
            this.lblResto.Location = new System.Drawing.Point(185, 66);
            this.lblResto.Name = "lblResto";
            this.lblResto.Size = new System.Drawing.Size(38, 13);
            this.lblResto.TabIndex = 2;
            this.lblResto.Text = "Resto:";
            // 
            // txtDividendo
            // 
            this.txtDividendo.Location = new System.Drawing.Point(76, 25);
            this.txtDividendo.Name = "txtDividendo";
            this.txtDividendo.Size = new System.Drawing.Size(100, 20);
            this.txtDividendo.TabIndex = 3;
            // 
            // txtDivisor
            // 
            this.txtDivisor.Location = new System.Drawing.Point(237, 25);
            this.txtDivisor.Name = "txtDivisor";
            this.txtDivisor.Size = new System.Drawing.Size(100, 20);
            this.txtDivisor.TabIndex = 4;
            // 
            // txtResto
            // 
            this.txtResto.Location = new System.Drawing.Point(237, 63);
            this.txtResto.Name = "txtResto";
            this.txtResto.ReadOnly = true;
            this.txtResto.Size = new System.Drawing.Size(100, 20);
            this.txtResto.TabIndex = 5;
            // 
            // btnRealizarDivisao
            // 
            this.btnRealizarDivisao.Location = new System.Drawing.Point(15, 61);
            this.btnRealizarDivisao.Name = "btnRealizarDivisao";
            this.btnRealizarDivisao.Size = new System.Drawing.Size(118, 23);
            this.btnRealizarDivisao.TabIndex = 6;
            this.btnRealizarDivisao.Text = "Realizar Divisão";
            this.btnRealizarDivisao.UseVisualStyleBackColor = true;
            this.btnRealizarDivisao.Click += new System.EventHandler(this.btnRealizarDivisao_Click);
            // 
            // frmRestoDivisao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 102);
            this.Controls.Add(this.btnRealizarDivisao);
            this.Controls.Add(this.txtResto);
            this.Controls.Add(this.txtDivisor);
            this.Controls.Add(this.txtDividendo);
            this.Controls.Add(this.lblResto);
            this.Controls.Add(this.lblDivisor);
            this.Controls.Add(this.lblDividendo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmRestoDivisao";
            this.Text = "Resto de uma divisão";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDividendo;
        private System.Windows.Forms.Label lblDivisor;
        private System.Windows.Forms.Label lblResto;
        private System.Windows.Forms.TextBox txtDividendo;
        private System.Windows.Forms.TextBox txtDivisor;
        private System.Windows.Forms.TextBox txtResto;
        private System.Windows.Forms.Button btnRealizarDivisao;
    }
}

