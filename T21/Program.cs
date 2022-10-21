// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и 
//находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53
double Distance(int ax,int ay,int az,int bx,int by,int bz){
    int k1 = ax  - bx;
    int k2 = ay - by;
    int k3 = az - bz;
    int r = k1 * k1 + k2 * k2 + k3 * k3;
    double d =  Math.Sqrt(r);
    double res = Math.Round(d, 2, MidpointRounding.ToZero);
    return res;
}
Console.Write("Введите координаты для точки А: ax = ");
int ax = Convert.ToInt32(Console.ReadLine());
Console.Write("ay = ");
int ay = Convert.ToInt32(Console.ReadLine());
Console.Write("");
Console.Write("az = ");
int az = Convert.ToInt32(Console.ReadLine());
Console.Write("");
Console.Write("Введите координаты для точки B: bx = ");
int bx = Convert.ToInt32(Console.ReadLine());
Console.Write("by = ");
int by = Convert.ToInt32(Console.ReadLine());
Console.Write("");
Console.Write("bz = ");
int bz = Convert.ToInt32(Console.ReadLine());
Console.Write("");
double rr = Distance(ax,ay,az,bx,by,bz);
Console.Write($"A ({ax} , {ay} , {az} ); B ({bx} , {by} , {bz}) -> {rr}");