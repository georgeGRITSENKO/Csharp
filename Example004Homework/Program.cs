// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int SecondNumber (int arg1 )

{
    int result = arg1 / 10;
    result = result%10;
    return result;
}
int a0 = 456;
int b0 = 782;
int c0 = 918;

int a1 = SecondNumber (a0);
int b1 = SecondNumber (b0);
int c1 = SecondNumber (c0);


Console.WriteLine (a1);
Console.WriteLine (b1);
Console.WriteLine (c1);

