//Ex 4
//Scrieti o functie care pentru un numar “n” primit ca parametru, va afisa
//urmatoarea piramida a numerelor:
//1
//2 2
//3 3 3
//4 4 4 4
//…
//n n n ….. n



Console.WriteLine("Enter the number of rows for the pyramid:");
int n = int.Parse(Console.ReadLine());

PrintNumberPyramid(n);

void PrintNumberPyramid(int n)
{
    for (int i = 1; i <= n; i++)
    {
        for (int j = 1; j <= i; j++)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }
}