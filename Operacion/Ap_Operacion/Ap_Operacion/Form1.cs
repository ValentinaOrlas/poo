using Lb_Operacion;

namespace Ap_Operacion
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BTN_CALCULAR_Click(object sender, EventArgs e)
        {
            double n1, n2;
            try
            {
                n1 = Convert.ToDouble(TXT_NUM1.Text);
                n2 = Convert.ToDouble(TXT_NUM2.Text);
                //Instanciar la clase 
                Operacion objSuma = new Operacion();
                objSuma.setNum1 = n1;
                objSuma.setNum2 = n2;

                if (objSuma.calcular())
                {
                    TXT_RESULTADO.Text = objSuma.getSuma.ToString();
                    return;
                }
                MessageBox.Show(objSuma.getError);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
    }
}