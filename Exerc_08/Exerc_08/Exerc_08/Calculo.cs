using System;
using System.Collections.Generic;
using System.Text;

namespace Exerc_08
{
    class Calculo
    {
        #region atributos
        private double num1;
        private double num2;
        #endregion

        #region construtores
        public Calculo()
        {
            this.num1 = 0;
            this.num2 = 0;
        }

        public Calculo(double num1, double num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }
        #endregion

        #region métodos de interface (Setter's & Getter's)
        public void setNum1(double num1)
        {
            this.num1 = num1;
        }

        public void setNum2(double num2)
        {
            this.num2 = num2;
        }

        public double getNum1()
        {
            return this.num1();
        }

        public double getNum2()
        {
            return this.num2;
        }
        #endregion

        #region métodos funcionais
        public void calcular()
        {
            if (this.num1 > this.num2)
            {
                getNum1(); = this.num1;
                getNum2(); = this.num2;
            }
            else
            {
                getNum2(); = this.num1;
                getNum1(); = this.num2;
            }
            
        }
        #endregion
    }
}