using System.Diagnostics.CodeAnalysis;

namespace Lb_Promedio
{
    public class Promedio
    {
        #region Atributos
        private double num1;
        private double num2;
        private double num3;
        private double promedio;
        private string error;
        #endregion

        #region Métodos Públicos
        public Promedio()
        {
            num1 = 0;
            num2 = 0;
            num3 = 0;
            promedio = 0;
            error = "";
        }
        public Boolean calcular()
        {
            if (!validar())
            {
                return false;
            }
            try
            {
                promedio = (num1 + num2 + num3) / 3.0;

                return true;
            }
            catch (Exception x)
            {
                error = x.Message;
                return false;
            }


        }
        #endregion

        #region Métodos Privados

        private Boolean validar()
        {
            if (num1 < 0 || num2 < 0 || num3 < 0)
            {
                error = "Los valores son negativos";
                return false;
            }

            return true;
        }
        #endregion

        #region Propiedades

        public double setNum1
        {
            set { num1 = value; }

        }
        public double setNum2
        {
            set { num2 = value; }
        }
        public double setNum3
        {
            set { num3 = value; }
        }
        public string getError
        {
            get { return error; }
        }

        public double getPromedio
        {
            get { return promedio; }
        }


        #endregion
    }
}