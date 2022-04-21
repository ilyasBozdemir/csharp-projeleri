using Voting_Uygulamasi;
Categories categories = new Categories();
CategoryHelper categoryHelper = new CategoryHelper(categories);
Console.WriteLine("Aşağıdaki kategorilere oy vererek anketimize katılabilirsiniz.");
basla:
Console.Write("Kullanıcı Adınızı Girin: ");
User user = new User();
UserControl userControl = new UserControl();
user.userName = Console.ReadLine();
if (userControl.GetUser(user))
{
   
    categoryHelper.WriteConsole(categories.FilmVoting, "film");
    categoryHelper.WriteConsole(categories.SporVoting, "spor");
    categoryHelper.WriteConsole(categories.TechStackVoting, "tech stack");
    categoryHelper.GetVotingResult();
    Console.Write("Yeniden Başlamak için \"y\" tuşlayın.");
    if (Console.ReadLine().ToLower() == "y")
    {
       goto basla;
    }
}
else
{
    Users users = new Users();
    Console.Write("Sistemde kayıtlı değilsiniz ,username girerek kaydolun."
        + "\n:Username girin: ");
    user.userName = Console.ReadLine();
    users.AddUser(user);
}



