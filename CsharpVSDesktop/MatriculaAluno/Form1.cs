using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatriculaAluno
{
    public partial class frmMatriculaAluno : Form
    {
        public frmMatriculaAluno()
        {
            InitializeComponent();
        }

        private void txtAnoAniversario_Enter(object sender, EventArgs e)
        {
            if(txtAnoNascimento.Text.Trim().Length < 4)
            {
                MessageBox.Show("É preciso informar o ano de nascimento com 4 digitos", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAnoNascimento.Focus();
            }
        }

        private void txtAnoAniversario_Validating(object sender, CancelEventArgs e)
        {
            if(txtAnoAniversario.Text != String.Empty && Convert.ToInt32(txtAnoAniversario.Text) <= Convert.ToInt32(txtAnoNascimento.Text))
            {
                MessageBox.Show("O ano do último aniversário deve ser superior ao ano de nascimento.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }

        private void btnIdentificarCategoria_Click(object sender, EventArgs e)
        {
            if(txtNome.Text == String.Empty || txtAnoNascimento.Text == String.Empty || txtAnoAniversario.Text == String.Empty)
            {
                MessageBox.Show("Todos os dados solicitados devem ser informados.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {
                int idade = Convert.ToInt32(txtAnoAniversario.Text) - Convert.ToInt32(txtAnoNascimento.Text);
                if(idade > 17)
                {
                    lblCategoriaResult.Text = "Adulto";
                } else if(idade > 13)
                {
                    lblCategoriaResult.Text = "Juvenil B";
                } else if(idade > 10)
                {
                    lblCategoriaResult.Text = "Juvenil A";
                } else if(idade > 7)
                {
                    lblCategoriaResult.Text = "Infantil B";
                } else if(idade >= 5)
                {
                    lblCategoriaResult.Text = "Infantil A";
                } else
                {
                    lblCategoriaResult.Text = "Não existe categoria";
                }
            }
        }
    }
}
