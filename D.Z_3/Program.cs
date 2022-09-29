Zadacha_19();
void Zadacha_19()
{
    // Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
    Console.WriteLine("Введите пятизначное число");
    string? number = Console.ReadLine();
        if (number[0] == number[4] & number[1] == number[3])
        {
            Console.WriteLine("Число " + (number) + " является палиндромом" );
        }
        else Console.WriteLine("Число " + (number) + " не является палиндромом"); 
}       


//  Zadacha_21();
 void Zadacha_21()
 {
    //Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве
    Console.WriteLine("Введите координаты точки А");
Console.WriteLine("Введите x1");
int x_first = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y1");
int y_first = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите z1");
int z_first = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки B");
Console.WriteLine("Введите x2");
int x_second = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y2");
int y_second = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите z2");
int z_second = Convert.ToInt32(Console.ReadLine());
int k = x_second - x_first;
int m = y_second - y_first;
int f = z_second - z_first;
double t = Math.Sqrt(k * k + m * m + f * f);
t = Math.Round(t, 2);
Console.WriteLine($"Расстояние между двумя точками = {t}");
}


// Zadacha_23();
void Zadacha_23()
{
    // Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N
    Console.WriteLine("Введите число");
    int num = Convert.ToInt32(Console.ReadLine());
    int i = 1;
    double kub;
    while(i <= num)
    {
        kub = Math.Pow(i, 3); 
        Console.WriteLine($"{i}    {kub}");
        i++;
    }
}