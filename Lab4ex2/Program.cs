//Cititi de la tastatura continutul unei matrici de intregi cu 3 dimensiuni avand lungimile n, m k.
//Lungimile celor trei dimensiuni ale matricii, n, m si k, vor fi citite de la tastaura.
// Scrieti o functie care va calcula suma elementelor unei astfel de matrici , apelati-o si afisati-i rezultatul.
// Scrieti o functie care va determina elementul cu valoare maxima, apelati-o si afisati-i rezultatul.

var mat1 = ReadMatrix();
Console.WriteLine("Matrix is:");
ShowMatrix(mat1);

var count = SumElements(mat1);
Console.WriteLine($"The sum of the elements of the matrix is: {count}");

var max = MaxValue(mat1);
Console.WriteLine($"The maximum element in the matrix is: {max}");

int[,,] ReadMatrix ()
{
    Console.WriteLine("Insert n");
    var n = int.Parse(Console.ReadLine());

    Console.WriteLine("Insert m");
    var m = int.Parse(Console.ReadLine());

    Console.WriteLine("Insert k");
    var k = int.Parse(Console.ReadLine());

    int[,,] matrix = new int[n, m, k]; 

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            for (int l = 0; l < k; l++)
            {
                matrix[i, j, l] = (i + 1) * (j + 1) + (l + 1);
            }
        }
    }

    return matrix;

}

void ShowMatrix(int[,,] matrix)
{
    int n = matrix.GetLength(0);
    int m = matrix.GetLength(1);
    int k = matrix.GetLength(2);

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            for (int l = 0; l < k; l++)
            {
                Console.Write(matrix[i, j, l] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


int SumElements(int[,,] matrix)
{
    int count = 0;
    foreach (int i in matrix)
    {
        count += i;
    }

    return count;
}

int MaxValue(int[,,] matrix)
{
    int max = 0;
    foreach (int i in matrix)
    {
        if (i > max)
        {
            max = i;
        }
    }
    return max;
}
