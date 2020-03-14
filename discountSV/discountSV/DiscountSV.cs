using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace discountSV
{
    public partial class DiscountSV : Form
    {
        public DiscountSV()
        {
            InitializeComponent();
            
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            float salario = float.Parse(txtSalario.Text);
            CalcularSalario calcular = new CalcularSalario();
            calcular.
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            clear();
        }



        void clear()
        {
            txtSalario.Clear();
            txtAFP.Clear();
            txtAFPISSS.Clear();
            txtISSS.Clear();
            txtMensual.Clear();
            txtQuincenal.Clear();
            txtRenta.Clear();
        }
    }

}

