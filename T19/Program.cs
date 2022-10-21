// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом.
//Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
//14212 -> нет
//12821 -> да
//23432 -> да
int NambeRevers(int x){
    string s = "";
    while(x > 0){
        int m = x % 10;
        x = x / 10;
        s = s + m;
    }
    int y = Convert.ToInt32(s);
    return y;
}
Console.Write("Введите натуральное число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a > 0){
    string st = a == NambeRevers(a)? "Да":"Нет";
    Console.Write($"{a} -> {st}");
}
else Console.Write("Неправильный ввод числа");