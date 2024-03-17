//Cititi de la tastatura continutul unei matrici de intregi cu 2 dimensiuni avand lungimile m, n.
//Lungimile celor doua dimensiuni ale matricii, m si n, vor fi citite de la tastaura.
// Scrieti o functie care va afisa continutul unei astfel de matrici si apelati-o.
// Scrieti o functie care va aduna doua matrici, apelati-o si afisati rezultatul.


using System.Numerics;

var mat1 = ReadMatrix();
var mat2 = ReadMatrix();

ShowMatrix(mat1);

var sumMatrix = AddMatrices(mat1, mat2);
ShowMatrix(sumMatrix);

int[,] ReadMatrix()
{
    Console.WriteLine("Insert n");
    var n = int.Parse(Console.ReadLine());    
    
    Console.WriteLine("Insert m");
    var m = int.Parse(Console.ReadLine());

    int[,] result = new int[n,m]; 

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            result[i,j] = (i+1) * (j+1);    
        }
    }
    return result;
}

void ShowMatrix(int[,] matrix)
{
    int n = matrix.GetLength(0);    
    int m = matrix.GetLength(1);

    for (int i = 0;i < n;i++)
    {
        for(int j = 0;j < m;j++)
        {
            Console.Write(matrix[i,j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] AddMatrices(int[,] matrix1, int[,] matrix2)
{
    int n = matrix1.GetLength(0);
    int m = matrix1.GetLength(1);
    
    int[,] result = new int[n,m];

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            result[i,j] = matrix1[i,j] + matrix2[i,j];
        }
        
    }

    return result;

}