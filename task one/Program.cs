int divisors = 0;
int num = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= num; i++)
{
    if (num % i == 0)
    {
        divisors++;

    }
}
if (divisors > 2)
{
    Console.WriteLine("murekkebdir");
}
else Console.WriteLine("sadedir");