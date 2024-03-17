//Cititi de la tastatura continutul a doua matrici de intregi cu 2 dimensiuni avand lungimile n m,
//respectiv m, n. Lungimile celor doua dimensiuni ale matricilor, m si n, vor fi citite de la tastaura.
//Scrieti o functie care va calcula produsul celor doua matrici, apelati-o si afisati matricea rezultata


Console.WriteLine("Enter the number of rows (n) for the first matrix:");
int n = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the number of columns (m) for the first matrix:");
int m = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the number of rows (m) for the second matrix:");
int m2 = int.Parse(Console.ReadLine());

if (m != m2)
{
    Console.WriteLine("The number of columns in the first matrix should be equal to the number of rows in the second matrix.");
    return;
}

Console.WriteLine("Enter the number of columns (n) for the second matrix:");
int n2 = int.Parse(Console.ReadLine());

int[,] matrix1 = ReadMatrixFromInput(n, m);
int[,] matrix2 = ReadMatrixFromInput(m2, n2);

Console.WriteLine("The first matrix is:");
PrintMatrix(matrix1);

Console.WriteLine("The second matrix is:");
PrintMatrix(matrix2);

int[,] productMatrix = MultiplyMatrices(matrix1, matrix2);
Console.WriteLine("The product matrix is:");
PrintMatrix(productMatrix);


int[,] ReadMatrixFromInput(int n, int m)
{
    int[,] matrix = new int[n, m];

    Console.WriteLine($"Enter {n * m} elements for the matrix:");

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            matrix[i, j] = int.Parse(Console.ReadLine());
        }
    }

    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    int n = matrix.GetLength(0);
    int m = matrix.GetLength(1);

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
{
    int n1 = matrix1.GetLength(0);
    int m1 = matrix1.GetLength(1);
    int n2 = matrix2.GetLength(0);
    int m2 = matrix2.GetLength(1);

    int[,] product = new int[n1, m2];

    for (int i = 0; i < n1; i++)
    {
        for (int j = 0; j < m2; j++)
        {
            for (int k = 0; k < m1; k++)
            {
                product[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }

    return product;
}