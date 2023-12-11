namespace sequenciadefabianosimples
{
    class Program
    {
        static void Main()
        {
            int numeroimprecao = 0, numeroanterior = -1, i; 
            // inicia um for que define o tamanho da sequência atravez da variavel i
            for(i = 0; i < 10; i++)
            {
                // importante imprimir o numero antes que o valor seja modificado
                Console.WriteLine(numeroimprecao); 
                // soma o numero de impreção a outra variavel, que no incio serve para inciar a sequencia, mas após o primeiro laço ele reistra o ultimp balor usado na impreção
                numeroimprecao += numeroanterior; 
               // soma o numero de impreção a outra variavel, que contem o ultimo numero da sequencia, que no incio ela vale 0
                numeroanterior = numeroimprecao - numeroanterior; 
            } // atualiza o numero anterior que foi usado na impreção, por meio da diferença entre o numero impreço e o numero anterior ao anterior deste, por exemplo 8, e feita a diferença entre 8 e dois numeros anteriores a ele, assim ficaria 8 - 3 = 5 que é o numero anterior a 8
        }
    }
}