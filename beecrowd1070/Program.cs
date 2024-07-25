int x;
int countOdd = 0;

while (countOdd < 6)
{
    if (int.TryParse(Console.ReadLine(), out x))
    {
        for (int i = x; i < x + 12; i++)
        {
            if (i % 2 != 0)
            {
                Console.WriteLine(i);
                countOdd++;
            }
        }
    }
}