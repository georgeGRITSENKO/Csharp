// See https://aka.ms/new-console-template for more information
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
void method (int arg)
{
    int arg0 = arg /10/10/10/10%10;
    int arg1 = arg /10/10/10%10;
    int arg3 = arg /10%10;
    int arg4 = arg %10;
    if (arg0 == arg4 || arg1 == arg3) Console.WriteLine ("Палиндром");
        else Console.WriteLine ("Не палиндром");

}
int a0 = 14212;
int b0 = 12821;
int c0 = 23432;
method(a0);
method(b0);
method(c0);
