Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "маша") //если в терминале после запуска ввести имя МаШа или МАша и нажать enter все равно
// прога сработает
{
    Console.WriteLine("Ура, зто же МАША !");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}