Console.WriteLine("Введите логин:");
string login = Console.ReadLine();

Console.WriteLine("Введите ваше имя:");
string name = Console.ReadLine();

Console.WriteLine("У вас есть премиум подписка? (Y/N)"); 
string isPremiumStr = Console.ReadLine();
bool isPremium = isPremiumStr == "Y" || isPremiumStr == "y";

var user = new User()
{
    Login = login,
    Name = name,
    IsPremium = isPremium
};

if (!isPremium)
    ShowAds();
else
    Console.WriteLine("Вы превосходны! 🤘");



static void ShowAds()
{
    Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
    // Остановка на 1 с
    Thread.Sleep(1000);

    Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
    // Остановка на 2 с
    Thread.Sleep(2000);

    Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
    // Остановка на 3 с
    Thread.Sleep(3000);
}


class User
{
    public string Login { get; set; }
    public string Name { get; set; }
    public bool IsPremium { get; set; }
}