﻿//задача 1
/*
int a;
int b;

a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
if (a < b)
{
    a = b;
}
b = Convert.ToInt32(Console.ReadLine());
if (a < b)
{
    a = b;
}
Console.WriteLine(a);


*/
//задача 3
/*
var a1 = Convert.ToDouble(Console.ReadLine());
var b1 = Convert.ToDouble(Console.ReadLine());
var c1 = Convert.ToDouble(Console.ReadLine());
if( a1!=0 && (b1 * b1 - 4 * a1 * c1) > 0){
    Console.WriteLine((-b1 + Math.Sqrt(b1 * b1 - 4 * a1 * c1)) / 2 * a1);
    Console.WriteLine((-b1 - Math.Sqrt(b1 * b1 - 4 * a1 * c1)) / 2 * a1);
}
else if (a1 != 0 && (b1 * b1 - 4 * a1 * c1) == 0)
{
    Console.WriteLine(-b1 / (2 * a1));
}

*/
//задача 2 
//переворот + задача 
/*
int g;
g = Convert.ToInt32(Console.ReadLine());
if (g>100 && g < 1000)
{
    
    Console.WriteLine(g % 10 + (g / 10 % 10) + (g / 100 % 10));
    Console.WriteLine(g % 10 * 100 + (g / 10 % 10) * 10 + (g / 100 % 10));
}
*/

/*
int min = 0;

string res = " ";
var a = Convert.ToDouble(Console.ReadLine());
var b = Convert.ToDouble(Console.ReadLine());
var c = Convert.ToDouble(Console.ReadLine());
if (a < 0)
{
    min += 1;
}
if (b < 0)
{
    min += 1;
}
if (c < 0)
{
    min += 1;
}

if (min > 0)
{
    res += "Yes ";
}
else
{
    res += "No ";
}
if (min == 3)
{
    res += "Yes ";
}
else
{
    res += "No ";
}
if (min == 1)
{
    res += "Yes ";
}
else
{
    res += "No ";
}
Console.WriteLine(res);

*/

/*var st = Convert.ToInt32(Console.ReadLine());
var end = Convert.ToInt32(Console.ReadLine());
int res = 0;
for (int i=st; i <= end; i++)
{
    if( (i % 4 == 0 && i%100==0 && i%400==0)|| (i % 4 == 0 && i % 100 != 0)){
        res += 1;
    }
}
Console.WriteLine(res);

*/
/*
var x = Convert.ToDouble(Console.ReadLine());
var y = Convert.ToDouble(Console.ReadLine());
if ((x < 0 && x>-1 &&(x * x + y * y) < 1) || (x >= 0 && x<=1 && y <= 1 && y >= -1))
{
    Console.WriteLine("Точка в фигуре");
}
else
{
    Console.WriteLine("Точка не в фигуре");
}
*/
/*
if (x < 0 && x > -1)
{
    if ( (x * x + y * y) < 1){
        Console.WriteLine("Точка в фигуре");
    }
}
else if (x >= 0 && x <= 1)
{
    if (y <= 1 && y >= -1)
    {
        Console.WriteLine("Точка в фигуре");
    }
}
else
{
    Console.WriteLine("Точка не в фигуре");
}*/
/*
var x = Convert.ToDouble(Console.ReadLine());
var y = Convert.ToDouble(Console.ReadLine());
if (Math.Abs(x)+ Math.Abs(y)<=1)
{
    Console.WriteLine("В ромбе");
}else
{
    Console.WriteLine("Не в ромбе");
}
*/

/*
var x = Convert.ToDouble(Console.ReadLine());
var y = Convert.ToDouble(Console.ReadLine());
if ((y<=1 && y>=0 &&x<=1 && x>=-1 && (y <= x * x))|| (y<=0 && y>=-1&&x==0))
{
    Console.WriteLine("yes");
}
else
{
    Console.WriteLine("no");
}
*/
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
/*
var a = Convert.ToDouble(Console.ReadLine());
var b = Convert.ToDouble(Console.ReadLine());
var c = Convert.ToDouble(Console.ReadLine());
var d = Convert.ToDouble(Console.ReadLine());
if (a!=b && a != c)
{
Console.WriteLine(a);
}
else if (a != b && b != c)
{
Console.WriteLine(b);
}
else if (c != a && c != b)
{ 
Console.WriteLine(c);
}
else
{
Console.WriteLine(d);
}
*/
/*
var a = Convert.ToDouble(Console.ReadLine());
var b = Convert.ToDouble(Console.ReadLine());
var c = Convert.ToDouble(Console.ReadLine());
var max = Math.Max(Math.Max(a, b), c);
var min = Math.Min(Math.Min(a, b), c);
var med = Math.Max(Math.Min(a, b), Math.Min(c, b));

Console.WriteLine(max);
Console.WriteLine(med);
Console.WriteLine(min);
*/
/*
var x = Convert.ToDouble(Console.ReadLine());
var y = Convert.ToDouble(Console.ReadLine());
if (x % 2 == 0)
{
    Console.WriteLine(Math.Max(x,y));
}
else
{
    Console.WriteLine(Math.Min(x, y));
}
*/
/*
 static double Calculate(string userInput)
{
    string[] depositParameters = userInput.Split(' ');
    
    double amountMoney = Convert.ToDouble(depositParameters[0]);
    int perpercent = Convert.ToInt32(depositParameters[1]);
    int period = Convert.ToInt32(depositParameters[2]);
   // Console.WriteLine("{0},{1},{2}", amountMoney, perpercent, period);
    return Math.Ceiling(Math.Pow(amountMoney, (double)period / 12 * perpercent /100));
   
}
Console.WriteLine(Calculate("100,00 12 3"));
*/

/*int numberA, numberB;
char chA, chB;
chA =char.Parse(Console.ReadLine());
numberA = int.Parse(Console.ReadLine());
chB = char.Parse(Console.ReadLine());
numberB = int.Parse(Console.ReadLine());
Console.WriteLine("пешка");
if (numberA>=2 && numberB<=8 && chA>='A' && chB <= 'H')
{
    if ((numberA == 2 && numberB <= 4 && chB == chA) || (numberA != 2 && numberB - numberA == 1 && chB == chA))
    {
        Console.WriteLine("True");
    }
    else
    {
        Console.WriteLine("false");
    }
}
else
{
    Console.WriteLine("false");
}
Console.WriteLine("слон");
if (numberA >= 1 && numberB <= 8 && numberB >= 1 && numberA <= 8 && chA >= 'A' && chB <= 'H'&& chA <= 'H' && chB >= 'A' && Math.Abs(numberB-numberA)==Math.Abs(chB-chA))
{
    Console.WriteLine("True");
}
else
{
    Console.WriteLine("false");
}
Console.WriteLine("конь");
if (numberA >= 1 && numberB <= 8 && numberB >= 1 && numberA <= 8 && chA >= 'A' && chB <= 'H' && chA <= 'H' && chB >= 'A' && ((Math.Abs(numberB - numberA) ==2 && Math.Abs(chB - chA)==1)||(Math.Abs(numberB - numberA) == 1 && Math.Abs(chB - chA) == 2)))
{
    Console.WriteLine("True");
}
else
{
    Console.WriteLine("false");
}
Console.WriteLine("ладья");
if (numberA >= 1 && numberB <= 8 && numberB >= 1 && numberA <= 8 && chA >= 'A' && chB <= 'H' && chA <= 'H' && chB >= 'A' && ((Math.Abs(numberB - numberA) == 0 && Math.Abs(chB - chA) !=0) || (Math.Abs(numberB - numberA) !=0 && Math.Abs(chB - chA) == 0)))
{
    Console.WriteLine("True");
}
else
{
    Console.WriteLine("false");
}
Console.WriteLine("ферзь");
if (numberA >= 1 && numberB <= 8 && numberB >= 1 && numberA <= 8 && chA >= 'A' && chB <= 'H' && chA <= 'H' && chB >= 'A' && ((Math.Abs(numberB - numberA) == 0 && Math.Abs(chB - chA) != 0) || (Math.Abs(numberB - numberA) != 0 && Math.Abs(chB - chA) == 0)||(Math.Abs(numberB - numberA) == Math.Abs(chB - chA))))
{
    Console.WriteLine("True");
}
else
{
    Console.WriteLine("false");
}
/*Console.WriteLine($"{chA} {numberA}");
Console.WriteLine(chB+" "+ numberB);
Console.WriteLine(chA-chB);*/



/*for(int i = 1; i <= n; i++)
{
    fact*= i;
}
*/
/*int i = int.Parse(Console.ReadLine());
int o = int.Parse(Console.ReadLine());
int res = 0;
int res1 = 0;
while (i > 0){
    res += 1;
    i /= 10;
}
Console.WriteLine(res);
while (o > 0 && o%2==0)
{
    
    o /= 2;
}
if (o == 1)
{
    Console.WriteLine("true");
}
else
{
    Console.WriteLine("false");
}*/

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
   // Console.WriteLine(minusOne * tmpX * oddFactorial / evenFactorial);
    rightExpression += minusOne * tmpX * oddFactorial / evenFactorial;
    res = rightExpression;
   // Console.WriteLine("общий ответ шага {0}", amountOperations);
   // Console.WriteLine(res);
} while (Math.Abs(leftExpressiont - rightExpression) > e);
Console.WriteLine("Количество шагов: {0}  Результат: {1} ", amountOperations, res);














/*Console.WriteLine("общий ответ {0}", amountOperations);
res = rightExpression;
Console.WriteLine(res);
while (Math.Abs(leftExpressiont - rightExpression) > e) 
{
    amountOperations += 1;
    rightExpression += algorithm(x, amountOperations);
    res = rightExpression;
    Console.WriteLine("общий ответ {0}",amountOperations);
    Console.WriteLine(res);
}
Console.WriteLine(amountOperations);
Console.WriteLine(res);

static double Fact2(double n)
{
    double result = 1;
    for (int i = n % 2 == 0 ? 2 : 1; i <= n; i += 2)
    {
        result *= i;
    }
    return result;
}

static double algorithm(double x, double k)
{
    double tmpRes = ((Math.Pow(-1, k)* Math.Pow(x, k)*Fact2(2*k+1))/Fact2(2*k));
    Console.WriteLine("вычисление элемента {0}", k);
    Console.WriteLine(tmpRes);
    return tmpRes;
}



*/