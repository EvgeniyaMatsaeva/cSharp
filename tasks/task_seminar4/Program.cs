// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
// тип итоговой переменной + Название метода+()+
// {
// return sum;
// }




int GetSumN(int numString)
{
    int sum = 0;
    while (numString>0)
    {
        sum += numString % 10;
        numString /= 10;
    }
    return sum;
    }


Console.WriteLine("введите число N");
int n = Convert.ToInt32(Console.ReadLine());


Console.WriteLine(GetSumN(n));
