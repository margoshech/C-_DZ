
// ДЗ Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// Console.WriteLine("Введите любое число:");
// int num = Convert.ToInt32(Console.ReadLine());
// for(int i = 1; i <= num; i++)
// {
//     Console.WriteLine($"{ Math.Pow(i, 3) }");
// }


// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

// double Rast(double x1, double y1, double a1, double x2, double y2, double a2)
// {
//     return Math.Sqrt((Math.Pow(x2 - x1,2)) + (Math.Pow(y2 - y1,2)) + (Math.Pow(a2 - a1,2)));
// }


// Console.WriteLine("Введите Координату x1 для точки А");
// double x1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите Координату y1 для точки А");
// double y1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите Координату a1 для точки A");
// double a1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите Координату x2 для точки B");
// double x2 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите Координату y2 для точки B");
// double y2 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите Координату a2 для точки B");
// double a2 = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine($"Расстояние между двумя точками равно: {Math.Round(Rast(x1,y1,a1,x2,y2,a2),2)}");


// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Через строку решать нельзя.
// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int numCopy = num;
int reverse = 0;

while (numCopy >0)
{
    int digit = numCopy % 10;

    reverse = reverse * 10 + digit;

    numCopy = numCopy / 10;

}

if (num == reverse)
{
    Console.WriteLine("полиндром");
}
else
{
    Console.WriteLine("не полиндром");
}
