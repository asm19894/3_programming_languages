// username - повторяет в точности введенное имя, а username.ToLower - переводит все буквы в нижний регистр
// if и else - ниже описан синтаксис этих комманд

Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "Маша")
{
    Console.WriteLine("УРА, это же МАХА!!!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}