Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "маша")
{
    Console.Write("Ура, это то же МАША!");
}
else
{
    Console.Write("Привет ");
    Console.Write(username);
}