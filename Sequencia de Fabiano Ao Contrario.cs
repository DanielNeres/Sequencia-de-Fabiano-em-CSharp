using System;

namespace sequenciadefabiano
{

    class program
    {

        public static void main()
        {
            int numeroimprecao, i;
            // incia um for que percorre todas a sequencia de fibonacci, comeÃ§ando de i atÃ© i=0
            for (i = 10; i >= 0; i--)
            {
                // para calcular a sequencia de Fibonacci uso a formula: F(i) = (pow((1 + sqrt(5)), i) - pow((1 - sqrt(5)), i)) / (pow(2, i) * sqrt(5))
                numeroimprecao = (pow((1 + sqrt(5)), i) - (pow((1 - sqrt(5)), i))) / (pow(2, i) * sqrt(5));
                console.WriteLine(numeroimprecao);
            }
        }
    }
}