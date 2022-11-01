//int[,] Генерация матрицы(n - размер)
 int[,] Gener(int size)
{
    Random random = new Random();
    int[,] mas = new int[size,size];
    for(int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
        {
            mas[i,j] = random.Next(10);
        }
    }
    return mas;
}

//void Запись матрицы в файл(матрица и имя файла)
void Write(int[,]mas, string path)
{
    using (StreamWriter sw = new StreamWriter(path))
    {
        int m = mas.GetLength(0);
        int n = mas.GetLength(1);
        sw.WriteLine($"{m} {n}");
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
                sw.Write(mas[i, j]+" ");
            sw.WriteLine();
        }
    }
}
//int[,] Чтение матрицы из файла
int[,] Read(string path)
{

    using (StreamReader reader = new StreamReader(path))
    {
        var mn = reader.ReadLine().Split(' ');
        int m = int.Parse(mn[0]);
        int n = int.Parse(mn[1]);

        var matr = new int[m, n];

        for (int i = 0; i < m; i++)
        {
            var row = reader.ReadLine().Split(' ');
            for (int j = 0; j < n; j++)
                matr[i, j] = int.Parse(row[j]);
        }
        return matr;
    }
}
//void Вывод матрицы на экран (матрица)  
void WriteConsol(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i, j]+" ");
        }
        Console.WriteLine();
    }
}


//var m = Gener(2);
//Write(m, @"C:\\Users\\tupae\\OneDrive\\Рабочий стол\\pr.txt");
//var m1 = Read(@"C:\\Users\\tupae\\OneDrive\\Рабочий стол\\pr.txt");
//WriteConsol(m1);


//Задание 1
//Сгенерировать матрицу из простых чисел ( 2.. 1 000 000). size размер maxNum макс число 
int[,] GenerSimple(int size,int maxNum)
{
    Random random = new Random();
    int[,] mas = new int[size, size];
    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
        {
            var tmp = random.Next(1,maxNum);
            while(!IsPrime(tmp))
            {
                 tmp = random.Next(1,maxNum);
            }
            mas[i, j] = tmp;
        }
    }
    return mas;
}
// проверка на простоту
bool IsPrime(int  n)
{
    for (int i = 2; i <= Math.Sqrt(n); i++)
        if (n % i == 0)
            return false;
    return true;
}
// Найти максимальное и минимальное число вывод в массиве [макс число,мин число]
int[] FindMaxMin(int[,] matr)
{
     int[] maxMin = new int[2]
     {
        matr[0,0],
        matr[0,0],
     };   
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if(matr[i, j] > maxMin[0])
            {
                maxMin[0]=matr[i, j];
            }
            if (matr[i, j] < maxMin[1])
            {
                maxMin[1] = matr[i, j];
            }
        }
    }
    
    return maxMin;
}
//Поменять строку с минимальных числом со строкой с максимальным числом  
void swapLines(int[,] matr)
{
    int maxStr = 0;
    int minStr = 0;
    int max = FindMaxMin(matr)[0];
    int min = FindMaxMin(matr)[1];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i, j] ==max)
            {
                maxStr = i;
            }
            if (matr[i, j] ==min)
            {
                minStr = i;
            }
        }
    }
    for(int i=0;i< matr.GetLength(1); i++)
    {
        var tmp = matr[maxStr, i];
        matr[maxStr, i] = matr[minStr, i];
        matr[minStr, i] = tmp;
    }
}
//Узнать есть ли симметричный столбец и посчитать его сумму. Вывод -1 , если нет . Иначе сумма
int FindSumSymmetricSolumn(int[,] matr)
{
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        bool sym = true;
        int sum = 0;
        for (int i = 0; i < matr.GetLength(0)/2; i++)
        {
            sum += matr[i, j] + matr[matr.GetLength(0) - 1 - i, j];
            if (matr[i,j]!= matr[matr.GetLength(0) - 1 - i, j])
            {
                sym = false;
            }
        }
        if (sym)
        {
            return sum;
        }
    }
    return -1;
}
//var m = GenerSimple(3, 100);
//WriteConsol(m);
//var resMaxMin=FindMaxMin(m);
//Console.WriteLine($"Max {resMaxMin[0]} Min {resMaxMin[1]}");
//swapLines(m);
//WriteConsol(m);
//var resSym=FindSumSymmetricSolumn(m);
//Console.WriteLine(resSym);
