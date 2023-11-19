//Usar la lógica de negocio
using Lb_Promedio;

namespace App_Promedio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Obtener los valores de las cajas de texto 
            double n1, n2, n3;
            try{
                n1 = Convert.ToDouble(txtNum1.Text);
                n2 = Convert.ToDouble(txtNum2.Text);
                n3 = Convert.ToDouble(txtNum3.Text);

                //Instancié la lógica de negocio
                Promedio promedio = new Promedio();

                //Enviando los valores a la lógica de negocio
                promedio.setNum1 = n1;
                promedio.setNum2 = n2;
                promedio.setNum3 = n3;

                if (!promedio.calcular())
                {
                    MessageBox.Show(promedio.getError);
                    return;
                }

                txtResult.Text = promedio.getPromedio.ToString("0.0");
            }
            catch(Exception x)
            {
                MessageBox.Show("Ingresar solo números");
               
            } 

        }

        private void txtNum3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}