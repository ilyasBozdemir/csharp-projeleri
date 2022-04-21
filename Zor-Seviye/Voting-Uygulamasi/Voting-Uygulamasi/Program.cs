using Voting_Uygulamasi;
Console.WriteLine("Aşağıdaki kategorilere oy vererek anketimize katılabilirsiniz.");
Console.Write("Kullanıcı Adınızı Girin: ");
User user = new User();
UserControl userControl = new UserControl();
user.userName = Console.ReadLine();
if (userControl.GetUser(user))
{
    Categories categories = new Categories();
    CategoryHelper categoryHelper = new CategoryHelper();
    categoryHelper.WriteConsole(categories.FilmVoting);
    categoryHelper.WriteConsole(categories.SporVoting);
    categoryHelper.WriteConsole(categories.TechStackVoting);
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



