namespace Lb_Operacion
{
    public class Operacion
    {
        #region Atributos
        private double num1;
        private double num2;
        private double suma;
        private string error;
        #endregion

        #region Métodos Privados
        private bool validar()
        {
            if(num1<0 || num2 < 0)
            {
                 error="Los números ingresados son negativos";
                return false;
            }
            return true;
        }
        #endregion

        #region Métodos Públicos
        public Operacion()
        {
            num1 = 0;
            num2 = 0;
            suma = 0;
            error = ""; 
        }

        public bool calcular()
        {
            if(!validar())
                return false;
            try
            {
                suma = num1 + num2;
                return true;
            }catch(Exception ex)
            {
                error = ex.Message;
                return false;
            }
        }
        #endregion

        #region Propiedades
        public double setNum1{
            set { num1 = value; }
  
        }
        public double setNum2
        {
            set { num2 = value; }
        }

        public string getError
        {
            get { return error; }
        }

        public double getSuma
        {
            get { return suma; }
        }   
        #endregion
    }
}




