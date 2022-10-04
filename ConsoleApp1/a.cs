Console.WriteLine("Введите x");
double x = double.Parse(Console.ReadLine());
Console.WriteLine("Введите e");
double e = double.Parse(Console.ReadLine());
double leftExpressiont = 1 / Math.Sqrt(1 + x);

algorithm(x, e, leftExpressiont);


static void algorithm(double x, double e, double leftExpressiont)
{
    double res = 0;
    int amountOperations = 0;
    double rightExpression = 0;
    double minusOne =0;
    double tmpX=0;
    double oddFactorial = 1;
    double evenFactorial = 1;
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
        }
        rightExpression += (minusOne * tmpX * oddFactorial) / evenFactorial;
        res = rightExpression;
        amountOperations += 1;
    } while (Math.Abs(leftExpressiont - rightExpression) >= e);
    Console.WriteLine("Левое выражение: {0} Правое выражение: {1} Шаг: {2}",leftExpressiont,res,amountOperations);
}
