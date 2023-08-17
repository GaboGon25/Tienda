using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tienda
{
    public partial class Tienda : Form
    {
        public Tienda()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double Precio, Cantidad, Total;

            Precio = double.Parse(txtProducto.Text);
            Cantidad = double.Parse(txtCantidad.Text);

            Total = Precio * Cantidad;

            txtTotal.Text = Total.ToString();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtProducto.Clear();
            txtCantidad.Clear();
            txtTotal.Clear();
        }
    }
}
