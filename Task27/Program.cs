// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();
Console.WriteLine("Type a number ");
int num = int.Parse(Console.ReadLine());

string N = Convert.ToString(num);

int res = 0;

for (int i=0;i<N.Length; i++)
{
    res += N[i]-'0';
}

Console.WriteLine(res);