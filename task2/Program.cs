// Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


var b1 = Input("Введите b1:");
var k1 = Input("Введите k1:");
var b2 = Input("Введите b2:");
var k2 = Input("Введите k2:");

double Input(string text)
{
    Console.Write(text);
    double Coordinate = Convert.ToDouble(Console.ReadLine());
    return Coordinate;
}

var x = (b2 - b1) / (k1 - k2);
var y = k1 * x + b1; //y=k1*x+b1 y=k2*x+b2 k1*x+b1-k2*x-b2=0 x(k1-k2)=b2-b1 x=(b2-b1)/(k1-k2) 


Console.WriteLine($"Коооридинаты точки пересечения({x}; {y})");
