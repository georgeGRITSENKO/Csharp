// See https://aka.ms/new-console-template for more information
// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine(" Hello, It's first exercise of homework !");
Console.WriteLine(" Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.");
Console.WriteLine(" 2, 3, 7 -> 7");
Console.WriteLine(" 44 5 78 -> 78");
Console.WriteLine(" 22 3 9 -> 22");
int a0 = 2;
int b0 = 3;
int c0 = 7;

int a1 = 44;
int b1 = 5;
int c1 = 78;

int a2 = 22;
int b2 = 3;
int c2 = 9;

int max0 = a0;

int max1 = a1;

int max2 = a2;

if(a0 > max0 ) max0 = a0 ;
if(b0 > max0 ) max0 = b0 ;
if(c0 > max0 ) max0 = c0 ;

if(a1 > max1 ) max1 = a1 ;
if(b1 > max1 ) max1 = b1 ;
if(c1 > max1 ) max1 = c1 ;

if(a2 > max2 ) max2 = a2 ;
if(b2 > max2 ) max2 = b2 ;
if(c2 > max2 ) max2 = c2 ;

Console.WriteLine(max0);

Console.WriteLine(max1);

Console.WriteLine(max2);