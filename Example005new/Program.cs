Console.WriteLine("Введите имя пользователя:");
string username = Console.ReadLine();
if(username.ToLower() == "John")
{
    Console.WriteLine("Ypa,это же JOHN");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}