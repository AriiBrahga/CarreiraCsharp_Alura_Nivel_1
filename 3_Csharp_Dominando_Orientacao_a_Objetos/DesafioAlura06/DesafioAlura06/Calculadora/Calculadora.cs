/*
 4 - Escrever um programa que funcione como uma calculadora, que pode realizar as 4 operações básicas, além de calcular raiz quadrada e potências. 
    O usuario deve entrar com dois números e um simbolo que represente a operação a ser feita.
*/

namespace DesafioAlura06.Calculadora
{
    public class Calculadora
    {
        public static double Operacao(double num1, double num2, char operacao)
        {
            double resultado = 0;

            switch(operacao)
            {
                case '+':
                    resultado = num1 + num2;
                    break;
                case '-':
                    resultado = num1 - num2;
                    break;
                case '/':
                    resultado = num1 / num2;
                    break;
                case '*':
                    resultado = num1 * num2;
                    break;
                case 'r':
                    resultado = Math.Sqrt(num1);
                    break;
                case '^':
                    resultado = Math.Pow(num1, num2);
                    break;
                default:
                    Console.WriteLine("Operacao invalida");
                    break;
            }
            return resultado;

        }
    }
}
