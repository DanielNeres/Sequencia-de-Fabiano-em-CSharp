namespace sequenciadefabiano
{

    class Program
    {

        static void Main()
        {
            int numeroimprecao, i;
            // incia um for que percorre todas a sequencia de fibonacci, comeÃ§ando de i atÃ© i=0
            for (i = 10; i >= 0; i--)
            {
                // para calcular a sequencia de Fibonacci uso a formula: F(i) = (pow((1 + sqrt(5)), i) - pow((1 - sqrt(5)), i)) / (pow(2, i) * sqrt(5))
                numeroimprecao = (int)((Math.Pow((1 + Math.Sqrt(5)), i) - (Math.Pow((1 - Math.Sqrt(5)), i))) / (Math.Pow(2, i) * Math.Sqrt(5)));
                Console.WriteLine(numeroimprecao);
            }
        }
    }
}