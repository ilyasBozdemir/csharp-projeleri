using ATM_Uygulamasi;

Bankaİşlemleri bank = new Bankaİşlemleri();
Client client = new Client();
Islemler islemler = new Islemler();

islemler.bank = bank;

client.Id = 12345;//doğru bilgileri hatırlama amaçlı
client.Password = "1234";//

Console.Write("Kullanıcı Numarası Girin : ");
int Id = int.Parse(Console.ReadLine());
Console.Write("Kullanıcı Şifre Girin : ");
string Password = Console.ReadLine();

client.Id = Id;
client.Password = Password;

bool state = bank.isLogin(client);
string LoginInfoMessage = (state == true)
    ? "Başarıyla Giriş Yapıldı."
    : "Giriş Yapma Başarısız";
Console.WriteLine(LoginInfoMessage);
if (state)
    islemler.IslemleriGetir();

Console.Read();