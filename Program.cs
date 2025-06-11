List<int> num = [];
int indice;
try
{
    do
    {
        Console.Clear();
        num.Clear();
        int contador = 1;
        Console.WriteLine("Informe 10 numeros inteiros:");
        for (int c = 1; c <= 10; c++)
        {
            Console.Write($"Numero {c}: ");
            num.Add(int.Parse(Console.ReadLine()));
        }
        Console.Clear();

        List<int> numpar = num.FindAll(n => n % 2 == 0);
        num.RemoveAll(n => n % 2 == 0);

        int respar = numpar.Sum(), resimpar = num.Sum();

        Console.WriteLine("Pares:");
        foreach (int numspar in numpar)
        {
            Console.WriteLine($"{contador}- {numspar}");
            contador++;
        }
        Console.WriteLine($"Soma de todos os pares: {respar}");

        contador = 1;

        Console.WriteLine("\nImpares:");
        foreach (int numsimpar in num)
        {
            Console.WriteLine($"{contador}- {numsimpar}");
            contador++;
        }
        Console.WriteLine($"Soma de todos os impares: {resimpar}");

        if (respar < resimpar)
        {
            Console.WriteLine($"\nOs impares são maiores.");
        }
        else
        {
            if (respar == resimpar)
            {
                Console.WriteLine($"\nOs dois valores são iguais.");
            }
            else
            {
                Console.WriteLine($"\nOs pares são maiores.");
            }
        }

        Console.Write($"\nPara fazer uma nova soma digite 1, para finalizar digite 2:\n1-Nova soma\n2-Finalizar\nOpção: ");
        indice = int.Parse(Console.ReadLine());

        while (indice < 1 || indice > 2)
        {
            Console.Write($"\nO numero {indice} não corresponde a 1 ou a 2, informe novamente: ");
            indice = int.Parse(Console.ReadLine());
        }

    } while (indice == 1);

} catch (Exception ex)
{
    Console.Clear();
    Console.WriteLine($"Informação recebida invalida.\nErro: {ex.Message}");
}
