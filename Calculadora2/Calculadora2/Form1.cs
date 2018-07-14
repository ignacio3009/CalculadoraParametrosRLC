using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Double;


namespace Calculadora2
{
    public partial class Form2 : Form
    {   
        Double resultado = 0;
        Double Rprima, Cprima, Lprima, Zbase, Vbase, Sbase;
        Double Zc, gamma;
        Double rcond, Deq, reqc, Ds, Area, d, d12, d23, d31;
 
        

        

        public Form2()
        {
            InitializeComponent();
        }

        private void boton_calcular(object sender, EventArgs e)
        {
            // R prima
            Rprima = Double.Parse(rconductor.Text)/Double.Parse(n_conductores_por_fase.Text);
            rprima.Text = Rprima.ToString();

            // C prima
            
            d12 = Double.Parse(dab.Text);
            d23 = Double.Parse(dbc.Text);
            d31 = Double.Parse(dca.Text);
            Deq = Math.Pow(d12 * d23 * d31, 1.0/3);

            Area = Double.Parse(mcm.Text) * 0.5067;
            rcond = Math.Sqrt(Area * 1E-6 / Math.PI);

            d = Double.Parse(d_fasciculos.Text);
            reqc = 0.0;
            if (n_conductores_por_fase.Text == "1")
                reqc = rcond;
            else if (n_conductores_por_fase.Text == "2")
                reqc = Math.Sqrt(rcond * d);
            else if (n_conductores_por_fase.Text == "3")
                reqc = Math.Pow(rcond * d * d, 1.0 / 3);
            else if (n_conductores_por_fase.Text == "4")
                reqc = 1.09*Math.Pow(rcond * d * d * d, 1.0 / 4);

            Cprima = 2 * Math.PI * 8.85E-12 / Math.Log(Deq / reqc) * 1E3;
            cprima.Text = Cprima.ToString("E4");

            // L prima
            Ds = 0.0;
            if (n_conductores_por_fase.Text == "1")
                Ds = Math.Exp(-1.0/4)*rcond;
            else if (n_conductores_por_fase.Text == "2")
                Ds = Math.Sqrt(Math.Exp(-1.0 / 4) * rcond * d);
            else if (n_conductores_por_fase.Text == "3")
                Ds = Math.Pow(Math.Exp(-1.0 / 4) * rcond * d * d, 1.0 / 3);
            else if (n_conductores_por_fase.Text == "4")
                Ds = 1.09 * Math.Pow(Math.Exp(-1.0 / 4) * rcond * d * d * d, 1.0 / 4);

            Lprima = 2E-4 * Math.Log(Deq/Ds);
            lprima.Text = Lprima.ToString("E4");
        }
    }
}
