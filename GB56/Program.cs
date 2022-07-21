
Console.Clear();
int m = Input("Введите количество строк M: ");
int n = Input("Введите количество столбцов N: ");
int maxrand = Input("Введите максимально возможное значение элемента: ");
int[,] numbers = new int [m,n];

FillArrayRandomNumbers(numbers, m, n);
Console.WriteLine("Заданный массив: ");
PrintArray(numbers, m, n);

Console.WriteLine("Заданный массив с выводом сумм элементов в строках: ");
SearchLineMinSum(numbers, m, n);


int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

void SearchLineMinSum(int[,] array, int m, int n)
{
    int minSum = 0;
    int number = 0;
    for(int i=0 ; i<m ; i++)
    {
        int tempSum = 0;
        for(int j=0 ; j<n ; j++)
        {   
            Console.Write(array[i,j] +  " \t");
            if(i == 0)
            {
                minSum = minSum + array[i,j];
                tempSum = minSum;
            }
            else
            {
                tempSum = tempSum + array[i,j];
            }
        }
        Console.Write($" Sum: {tempSum}\n");
        if(tempSum < minSum)
        {
            minSum = tempSum;
            number = i;
        }
    }
    Console.WriteLine($"Строка с наименьшей суммой элементов : {number}");
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