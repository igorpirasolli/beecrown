int xValue;
int cont = 0;
int pares = 0;
string? readresult;

while (cont < 5)
{

    readresult = Console.ReadLine();

    if (int.TryParse(readresult, out xValue))
    {
        if (xValue % 2 == 0)
        {
            pares++;

        }
        cont++;

    }
}
Console.WriteLine($"{pares} valores pares");