internal class Program
{
    private static void Main(string[] args)
    {
        int digito = 0, soma_impar = 0, soma_par = 0;

        do
        {
            Console.WriteLine("Informe um número: ");
            digito = int.Parse(Console.ReadLine());
            if ((digito < 1000) && (digito > 0))
            {
                if (digito % 2 == 0)
                {
                    soma_par += digito;
                }
                else
                {
                    soma_impar += digito;
                }
            }
        } while (digito < 1000);
        Console.WriteLine("A soma de números pares digitados foi {0}", soma_par);
        Console.WriteLine("A soma de números impares digitados foi {0}", soma_impar);
    }
}