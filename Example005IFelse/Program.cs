Console.WriteLine("Введите имя пользователя");
string username = Console.ReadLine ();

if(username.ToLower() == "даша")
{
    Console.WriteLine("Ура это Даша!!!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
