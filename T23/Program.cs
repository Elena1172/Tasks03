// Задача 23 Напишите программу, которая принимает на вход число (N) и 
//выдаёт таблицу кубов чисел от 1 до N.
//5 ->
//1 | 1
//2 | 8
//3 | 27
//4 | 64
//5 | 125
void Cube(int x){
    Console.WriteLine($"{x} ->");
    int c = 1;
    while(c <= x){
        double rez = Math.Pow(c,3);
        Console.WriteLine($"{c,4} | {rez,4}");
        c++;
    }
       
}
Console.Write("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number <=0) Console.Write("Неправильный ввод числа.");
else Cube(number);