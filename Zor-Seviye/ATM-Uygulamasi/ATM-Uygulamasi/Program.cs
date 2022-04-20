/*ATM uygulaması
Uygulama ilk çalıştığında kullanıcıdan yapmak istediği işlemi öğrenmelidir.
Bunlar ATM üzerinden yapılabilecek temem işlemledir. Para çekme, para yatırma, ödeme yapma vs..
İsteğe bağlı olarak genişletilebilir.
Öncelikle ATM ye giriş yapan kullanıcın sistemde kayıtlı bir kullanıcı olduğundan emin olunmalıdır.

Uygulamada bir de gün sonu seçeneği olmalıdır.
Gün sonu alınmak istendiğinde, gün içerisinde yapılan transaction'ların 
logları ve fraud olabilecek yani hatalı giriş denemeleri log gösterilmelidir.
Aynı client'ın bilgisayarında belirlenen bir lokasyona EOD_Tarih(DDMMYYY formatında).txt adında bir dosyaya yazılmalıdır.

Kullanılması gereken teknikler:

Dosyaya Yazma
Dosyadan Okuma
İşlem listesi pre-defined olarak kullanılabilir.
 */
using ATM_Uygulamasi;

Bank bank = new Bank();
Customer customer = new Customer ();
Console.Write("Hoşgeldiniz...\n");
Console.Write("\nMüşteri Adı Girin : ");
var customerData = Console.ReadLine();
customer.customerName = customerData.Split(' ')[0];// (isim soyisim) varsayarak
customer.customerSurname = customerData.Split(' ')[1];
Console.Write("\nMüşteri Şifrenizi Girin : ");


bank.LogIn(customer);








Console.Read();