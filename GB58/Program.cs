
Console.Clear();

int m1 = Input("Введите количество строк в матрице 1: ");
int n1 = Input("Введите количество столбцов в матрице 1: ");
int maxrand1 = Input("Введите максимально возможное значение элемента в матрице 1: ");
int[,] numbers1 = new int [m1,n1];
FillArrayRandomNumbers(numbers1, m1, n1, maxrand1);

int m2 = Input("\nВведите количество строк в матрице 2: ");
if(m2 != n1)
{
    while(m2 != n1)
    {
        Console.WriteLine("  Ошибка! Количество строк матрицы 2 должно быть равно количеству столбцов матрицы 1. \n Поэтому количество строк матрицы 2 примем равным: " + n1);
        m2 = n1;
    }
}
int n2 = Input("Введите количество столбцов в матрице 2: ");

int maxrand2 = Input("Введите максимально возможное значение элемента в матрице 2: ");
int[,] numbers2 = new int [m2,n2];
FillArrayRandomNumbers(numbers2, m2, n2, maxrand2);

Console.WriteLine("\nМетодом случайных чисел получена матрица 1: ");
PrintArray(numbers1, m1, n1);
Console.WriteLine("Методом случайных чисел получена матрица 2: ");
PrintArray(numbers2, m2, n2);

Console.WriteLine("Произведение матрица 1 * матрица 2: ");
ProductOf2Matrices(numbers1, numbers2);

int Input(string output)
{ 
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

void ProductOf2Matrices(int[,] array1, int[,] array2)
{
    for(int i=0 ; i<m1 ; i++)
    {
        for(int j=0 ; j<n2 ; j++)
        {   
            int SumProduct = 0;
            for(int s = 0 ; s<n1 ; s++)
            {
                SumProduct = SumProduct + ( array1[i,s] * array2[s,j] );
            }
            Console.Write(SumProduct + " \t");
        }
        Console.Write("\n");
    }
    Console.Write("\n");
}

void PrintArray(int[,] array, int m, int n)
{
    for(int i=0 ; i<m ; i++)
    {
        for(int j=0 ; j<n ; j++)
        {
            Console.Write(array[i,j] +  " \t");
        }
        Console.Write("\n");
    }
    Console.Write("\n");
}

void FillArrayRandomNumbers(int[,] array, int m, int n, int maxrand)
{
    for(int i=0 ; i<m ; i++)
    {
        for(int j=0 ; j<n ; j++)
        {
            Random rand = new Random();
            array[i,j] = rand.Next(maxrand+1);
        }
    }
}
