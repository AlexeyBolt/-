Console.Write("Введите имя: ");
string username = Console.ReadLine();

if(username.ToLower() == "господин")
{
    Console.WriteLine("Добро пожаловать, повелитель!");
}
else
{
    Console.Write("Беги,");
    Console.WriteLine(username);
    Console.Write("Беги!");
}