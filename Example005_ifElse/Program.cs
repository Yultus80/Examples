Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "masha")
{
    Console.WriteLine("Привет чувиха");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}