using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gasto_restaurante
{
    public partial class frmCalculo : Form
    {
        public frmCalculo()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            txtTotal.Text = (Convert.ToDouble(txtDespesa.Text) * 1.10).ToString("N");
        }
    }
}
