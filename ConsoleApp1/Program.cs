
Console.WriteLine("Введите x");
double x = double.Parse(Console.ReadLine());
Console.WriteLine("Введите e");
double e = double.Parse(Console.ReadLine());
double res = 0;
double amountOperations = 0;
double rightExpression=0;
double leftExpressiont = 1 / Math.Sqrt(1 + x);
double minusOne = -1;
double tmpX = x;
double oddFactorial = 1;
double evenFactorial = 1;

do
{
    if (amountOperations == 0)
    {
        tmpX = 1;
        minusOne = 1;
        oddFactorial = 1;
        evenFactorial = 1;
    }
    else
    {
        tmpX *=x;
        minusOne *=-1;
        oddFactorial *= 2 * amountOperations + 1;
        evenFactorial *= 2 * amountOperations;
    }
    
    amountOperations += 1;
  
    rightExpression += minusOne * tmpX * oddFactorial / evenFactorial;
    res = rightExpression;
   
} while (Math.Abs(leftExpressiont - rightExpression) > e);
Console.WriteLine("Количество шагов: {0}  Результат: {1} ", amountOperations, res);


