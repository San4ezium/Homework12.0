// See https://aka.ms/new-console-template for more information
int Fib(int n)
{
    if (n == 0)
        return 0;

    if (n == 1)
        return 1;

    return Fib(n - 1) + Fib(n - 2);
}

Console.Write("Enter the Fibonacci number: ");
string input = Console.ReadLine();

if (int.TryParse(input, out int n) && n >= 0)
{
    int result = Fib(n);
    Console.WriteLine($"Fibonacci number at number {n}: {result}");
}
else
{
    Console.WriteLine("Please enter a non-negative integer.");
}

