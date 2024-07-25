int xValue;
decimal yValue;
int cont = 0;
int positivos = 0;
string? readresult = "";

while (cont < 5)
{

    readresult = Console.ReadLine();

    if (int.TryParse(readresult, out xValue))
    {
        if (xValue > 0)
        {
            positivos++;
        }
    }
    else if (decimal.TryParse(readresult, out yValue))
    {
        if (yValue > 0)
        {
            positivos++;
        }
    }
    else
    {
        Console.WriteLine();
    }
    cont++;

}
Console.WriteLine($"{positivos} valores positivos");