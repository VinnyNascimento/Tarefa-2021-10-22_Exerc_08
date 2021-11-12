using System;

namespace Exerc_08
{
    class Program
    {
        static void Main(string[] args)
        {
            #region declarações & instâncias
            Calculo s;
            s = new Calculo();
            #endregion

            #region Introducao
            Console.Write("Descubra qual número é maior, ou se saõ idênticos");
            Console.ReadLine();
            #endregion

            #region entrada
            Console.Write("Informe o 1° número ");
            s.setNum1(double.Parse(Console.ReadLine()));

            Console.Write("Informe o 2° número ");
            s.setNum2(double.Parse(Console.ReadLine()));
            #endregion

            #region processo
            s.calcular();
            #endregion

            #region saída
            Console.WriteLine("O número {0} é maior que o número {1}", s.getNum1(), s.getNum2());
            #endregion
        }
    }
}
