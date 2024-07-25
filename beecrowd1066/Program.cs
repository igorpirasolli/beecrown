int cont = 0;
int x;
int par = 0, impar = 0, negativo = 0, positivo = 0;

while (cont < 5)
{
    while (int.TryParse(Console.ReadLine(), out x))
    {
        if (x > 0)
        {
            positivo++;
        }
        if (x < 0)
        {
            negativo++;
        }
        if (x % 2 == 0)
        {
            par++;
        }
        if (x % 2 != 0)
        {
            impar++;
        }
        cont++;
    }
}
Console.WriteLine($"{par} valor(es) par(es)");
Console.WriteLine($"{impar} valor(es) impar(es)");
Console.WriteLine($"{positivo} valor(es) positivo(s)");
Console.WriteLine($"{negativo} valor(es) negativo(s)");