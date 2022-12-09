// See https://aka.ms/new-console-template for more information
// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
int ColichestvoChisel ( int arg1)
{
 int count = 0;
 while(arg1>0) 
 {
     count++;
     arg1 = arg1 / 10;
  }
  return count;
}
int ThirdNumber (int arg1)
{

    int arg2 = ColichestvoChisel (arg1);
    if (arg2==1) arg1 = 555;
    if (arg2==2) arg1 = 555;
    if (arg2==3) arg1 = arg1 % 10;
    if (arg2==4) arg1 = arg1 /10 % 10;
    if (arg2==5) arg1 = arg1 /10 /10 % 10;
    if (arg2==6) arg1 = arg1 /10 /10 /10 % 10;
    if (arg2==7) arg1 = arg1 /10 /10 /10 /10% 10;
    if (arg2==8) arg1 = arg1 /10 /10 /10 /10 /10% 10;
    if (arg2==9) arg1 = arg1 /10 /10 /10 /10 /10 /10% 10;
    return arg1;
}
int a0 = 645;
int b0 = 78;
int c0 = 32679;
int a1 = ThirdNumber (a0);
int b1 = ThirdNumber (b0);
int c1 = ThirdNumber (c0);
Console.WriteLine(a1);
Console.WriteLine(b1);
Console.WriteLine(c1);
Console.WriteLine("Если вы видете 555 это означает, что третьего числа там нет");
Console.WriteLine("P.S. Справился как смог xD");