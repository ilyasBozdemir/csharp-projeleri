using Voting_Uygulamasi;
Console.WriteLine("Aşağıdaki kategorilere oy vererek anketimize katılabilirsiniz.");
Console.Write("Kullanıcı Adınızı Girin: ");
User user = new User();
UserControl userControl = new UserControl();
user.userName = Console.ReadLine();
if (userControl.GetUser(user))
{
    Categories categories = new Categories();
    CategoryHelper categoryHelper = new CategoryHelper(categories);
    categoryHelper.WriteConsole(categories.FilmVoting, "film");
    categoryHelper.WriteConsole(categories.SporVoting, "spor");
    categoryHelper.WriteConsole(categories.TechStackVoting, "tech stack");
    categoryHelper.GetVotingResult();
}
else
{
    Users users = new Users();
    Console.Write("Sistemde kayıtlı değilsiniz ,username girerek kaydolun."
        + "\n:Username girin: ");
    user.userName = Console.ReadLine();
    users.AddUser(user);
}



