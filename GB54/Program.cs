
Console.Clear();
int m = Input("Введите количество строк M: ");
int n = Input("Введите количество столбцов N: ");
int maxrand = Input("Введите максимально возможное значение элемента: ");
int[,] numbers = new int [m,n];

FillArrayRandomNumbers(numbers, m, n);
Console.WriteLine("Заданный массив: ");
PrintArray(numbers, m, n);

SortArray(numbers, m, n);
Console.WriteLine("Упорядоченный заданный массив: ");
PrintArray(numbers, m, n);



int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

void SortArray(int[,] array, int m, int n)
{
    for(int i=0 ; i<m ; i++)
    {
        for(int j=0 ; j<n ; j++)
        {   
            int max=array[i,j];
            for(int k=j+1; k<n; k++)
            {
                if(array[i,k]>max)
                {
                    max=array[i,k];
                    array[i,k]=array[i,j];
                    array[i,j]=max;
                }

            }
        }
    }
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

void FillArrayRandomNumbers(int[,] array, int m, int n)
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