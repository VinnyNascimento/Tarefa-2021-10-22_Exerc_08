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
            Console.Write("Descubra qual o Maior Numero");
            Console.ReadLine();
            #endregion

            #region entrada
            Console.Write("Informe o 1° numero: ");
            s.setNum1(int.Parse(Console.ReadLine()));

            Console.Write("Informe o 2° numero: ");
            s.setNum2(int.Parse(Console.ReadLine()));
            #endregion

            #region processo
            s.calcular();
            #endregion

        }
    }
}