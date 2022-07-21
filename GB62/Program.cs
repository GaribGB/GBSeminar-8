Console.Clear();

int n1 = Input("Введите количество столбцов: ");
int m1 = Input("Введите количество строк: ");

int[,] numbers = new int [m1,n1];
FillArrayNumbers(numbers, m1, n1);
PrintArray(numbers, m1, n1);
Console.WriteLine(" ");


int Input(string output)
{ 
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray(int[,] array, int m, int n)
{
    for(int i=0 ; i<m ; i++)
    {
        for(int j=0 ; j<n ; j++)
        {
            Console.Write($"{array[i,j]}\t");
        }
        Console.Write("\n");
    }
}


void FillArrayNumbers(int[,] array, int m, int n)
{
    int Count = 1;
    int i = 0;
    int j = -1;
    int Point = 0;
    while(Count<=m*n)
    {
        for(i=Point ; i<n-Point; i++)
        {
            if(Count>m*n) 
            {
                break;
            }
            array[j+1,i] = Count;
            Count++;
        }
        Point++;

        for(j=Point ; j<m+1-Point; j++)
        {
            if(Count>m*n) 
            {
                break;
            }
            array[j,i-1] = Count;
            Count++;
        }

        for(i=n-1-Point; i>Point-2; i--)
        {
            if(Count>m*n) 
            {
                break;
            }
            array[j-1,i] = Count;
            Count++;
        }

        for(j=m-1-Point ; j>Point-1; j--)
        {
            if(Count>m*n) 
            {
                break;
            }
            array[j,i+1] = Count;
            Count++;
        }
    }
}
