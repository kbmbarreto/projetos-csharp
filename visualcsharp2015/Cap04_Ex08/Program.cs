using System;

/* Programa que apresenta uma variável RESULTADO com o valor 1, pois o incremento de 1 ao valor da 
 * variável VALOR ocorre depois da atribuição à variável RESULTADO. Assim sendo, a variável RESULTADO 
 * recebe o valor 1 da variável VALOR. Após essa operação, a variável VALOR é acrescida de 1, passando
 * a ter o valor 2, que é então apresentado.
 */

namespace Cap04_Ex08
{
    class Program
    {
        static void Main(string[] args)
        {
            int VALOR = 1, RESULTADO;

            RESULTADO = VALOR++;
            Console.WriteLine("RESULTADO = {0}", RESULTADO);
            Console.WriteLine("VALOR = {0}", VALOR);
            Console.WriteLine();

            Console.Write("Tecle algo para encerrar... ");
            Console.ReadKey();
        }
    }
}
