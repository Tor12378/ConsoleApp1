Console.WriteLine("Введите x");
double x = double.Parse(Console.ReadLine());
Console.WriteLine("Введите e");
double e = double.Parse(Console.ReadLine());
double leftExpressiont = 1 / Math.Sqrt(1 + x);

Console.WriteLine(algorithm(x, e, leftExpressiont));
//Console.WriteLine("Количество шагов: {0}  Результат: {1} ", amountOperations, res);

static double algorithm(double x, double e, double leftExpressiont)
{
    double res = 0;
    int amountOperations = 0;
    double rightExpression = 0;
    
    double minusOne = -1;
    double tmpX = x;
    long oddFactorial = 1;
    long evenFactorial = 1;
    do
    {
        if (amountOperations == 0)
        {

            tmpX = 1;
            minusOne = 1;
            
        }
        else
        {
            tmpX *= x;
            minusOne *= -1;
            oddFactorial *= 2 * amountOperations + 1;
            evenFactorial *= 2 * amountOperations;
          //  Console.WriteLine(evenFactorial);
        }

        amountOperations += 1;
        // Console.WriteLine((minusOne * tmpX * oddFactorial) / evenFactorial,10);
        Console.WriteLine(evenFactorial);
       
        rightExpression += (minusOne * tmpX * oddFactorial) / evenFactorial;
        res = rightExpression;
       Console.WriteLine("общий ответ шага {0}", amountOperations);
       Console.WriteLine(res);
    } while (Math.Abs(leftExpressiont - rightExpression) >= e);
    return res;
}

