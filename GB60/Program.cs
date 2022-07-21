
Console.Clear();

int p1 = 100;
int n1 = 1;
int m1 = 1;
Console.WriteLine($"Введите размеры массива, их произведение не должно превышать {100-10} (количество неповторяющихся двузначных чисел).");

while (p1*n1*m1 > 100-10)
{
    p1 = Input("Введите количество столбцов: ");
    n1 = Input("Введите количество строк: ");
    m1 = Input("Введите количество матриц: ");
    if(p1*n1*m1 > 100-10)
    {
        Console.WriteLine($"Количество элементов в массиве ({n1} * {p1} * {m1} = {p1*n1*m1}) превышает количество неповторяющихся двузначных чисел ({100-10}). \n\nВведите другие значения.");
    }
}

int[,,] numbers1 = new int [m1,n1,p1];
FillArray3XRandomNumbers(numbers1, m1, n1, p1);
PrintArray3XPlusIndex(numbers1, m1, n1, p1);

int Input(string output)
{ 
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray3XPlusIndex(int[,,] array, int m, int n, int p)
{
    for(int i=0 ; i<m ; i++)
    {
        for(int j=0 ; j<n ; j++)
        {
            for(int s=0 ; s<p ; s++)
            {
                Console.Write($"{array[i,j,s]}[{i},{j},{s}]  ");
            }
            Console.Write("\n");
        }
        Console.Write("\n");
    }
}

void FillArray3XRandomNumbers(int[,,] array, int m, int n, int p)
{
    int nCount = 0;
    for(int i=0 ; i<m ; i++)
    {
        for(int j=0 ; j<n ; j++)
        {
            for(int s=0 ; s<p ; s++)
            {
                if(nCount == 0)
                {
                    Random rand = new Random();
                    array[i,j,s] = rand.Next(10, 100);
                }
                else
                {
                    array[i,j,s] = NonRepetitiveRandom(array, m, n, p, nCount);
                }
                nCount++;
            }
        }
    }
}

int NonRepetitiveRandom(int[,,] array, int m, int n, int p, int nCount)
{
    Random rand = new Random();
    int randCount = 0;
    int Count = 0;
    while(Count != nCount)
    {
        randCount = rand.Next(10, 100);
        Count = 0;
    
        for(int i=0 ; i<m ; i++)
        {
            for(int j=0 ; j<n ; j++)
            {
                for(int s=0 ; s<p ; s++)
                {
                    if(array[i,j,s] == randCount || Count == nCount)
                    {
                        i=m;
                        j=n;
                        s=p;
                    }
                    else
                    {
                        Count++;
                    }
                }
            }
        }
    }
    return randCount;
}
