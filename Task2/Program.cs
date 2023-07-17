/*Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/

double ReadInt(string message)
{
    System.Console.WriteLine(message);
    double number = Convert.ToInt32(Console.ReadLine()); 
    return number;
}

void Intersec(double b1, double b2, double k1, double k2) 
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    Console.WriteLine($"Точка пересечения {x}, {y}");
   
}

bool Validate(double b1, double b2, double k1, double k2) 
{
    if (k1 == k2) 
    { 
        if (b1 == b2)
        { 
            Console.WriteLine("Прямые совпадают");
            return false;
        }
        else 
        {
             Console.WriteLine("Прямые параллельны");
            return false;
        }
    }
return true;
}
Console.Clear();
double b1 = ReadInt("Введите значение b1");
double k1 = ReadInt("Введите значение k1");
double b2 = ReadInt("Введите значение b2");
double k2 = ReadInt("Введите значение k2");

if (Validate(b1, b2, k1, k2))
    { 
        Intersec(b1, b2, k1, k2); 
    }

