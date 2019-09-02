using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioSalarioEmpleado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {


            double horast = double.Parse(txthorastrabajadas.Text);
            double valorh = double.Parse(txtvalorhora.Text);
            double total = horast * valorh;

            if (total > 750000){

                MessageBox.Show(" El empleado gana mas del salario minimo");
                //lbltotalpagar.Text = "$" + Convert.ToDecimal(total).ToString();
                //lbltotalpagar.Visible = true;

            else{

                total = (total * 0.20) + total;
                //lbltotalpagar.Text = "$" + Convert.ToDecimal(total).ToString();
                //lbltotalpagar.Visible = true;
                }
            lbltotalpagar.Text = "$" + Convert.ToDecimal(total).ToString();
            lbltotalpagar.Visible = true;

        }
    }
}
