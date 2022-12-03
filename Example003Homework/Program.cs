int a = 5;
int b = 8;
int countA = 1;
while(countA<a+1)
{
    if((countA % 2) == 0)
    {
        Console.Write(countA);
        Console.Write(",");
    }
    countA++;
}
Console.Write(".");
Console.WriteLine("");
int countB = 1;
while(countB<=b+1)
{
    if((countB % 2) == 0)
    {
        Console.Write(countB);
        Console.Write(",");
    }
    countB++;
}
Console.Write(".");
Console.WriteLine("");