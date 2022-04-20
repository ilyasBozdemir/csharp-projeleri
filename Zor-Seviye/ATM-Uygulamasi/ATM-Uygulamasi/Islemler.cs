using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Uygulamasi
{
    public class Islemler
    {
        public Bankaİşlemleri bank = new Bankaİşlemleri();
        Logger _logger = new Logger();
        Client _client = new Client();
        public void IslemleriGetir()
        {
            _client = bank._client;
            Console.WriteLine($"\"{_client.Name} {_client.Surname}\" Hoşgeldiniz!");
            _logger.SaveLogger(new Logger()
            {
                TransactionName = Transaction.GirisYapıldı,
                Message = "{_client.Name} Sisteme Giriş Yaptı."
            });

secimYap:
            Console.Write("İşlem Seçin:\n1)ParaYatırma\n2ParaCekme\n3HavaleYapma\n4)Günsonu Alma ");
            int status = int.Parse(Console.ReadLine());
            var balance = 0;
            var toClientId = 4321;
            switch (status)
            {
                case 1:
                    Console.Write("Yatırmak istediğin miktar girin : ");
                    balance = int.Parse(Console.ReadLine());
                    bank.ParaYatırma(balance);
                    Console.WriteLine("İşlem Başarılı");
                    _logger.SaveLogger(new Logger()
                    {
                        TransactionName = Transaction.GirisYapıldı,
                        Message = $"{_client.Name} Para Çekti."
                    });
                    break;
                case 2:
                    Console.Write("Çekmek istediğin miktar girin : ");
                    balance = int.Parse(Console.ReadLine());
                    bank.ParaCekme(balance);
                    Console.WriteLine("İşlem Başarılı");
                    _logger.SaveLogger(new Logger()
                    {
                        TransactionName = Transaction.ParaCekildi,
                        Message = $"{_client.Name} para çekti."
                    });
                    break;
                case 3:
                    Console.Write("Havale Yapılcak HesapID Girin :");
                    toClientId = int.Parse(Console.ReadLine());
                    Console.Write("Havale Yapılcak Miktarı Girin :");
                    balance = int.Parse(Console.ReadLine());
                    if (bank.HavaleYapma(balance, toClientId))
                        Console.WriteLine("İşlem Başarılı");
                    _logger.SaveLogger(new Logger()
                    {
                        TransactionName = Transaction.ParaGonderildi,
                        Message = $"{_client.Name} {toClientId} id'li kullanıcıya para gönderdi."
                    });
                    break;
                case 4:
                    bank.GunSonuAl();
                    break;
                default:
                    Console.WriteLine("Lütfen menüden seçim yapın");
                    _logger.SaveLogger(new Logger()
                    {
                        TransactionName = Transaction.HataliSecim,
                        Message = $"{_client.Name} hatalı seçim yaptı."
                    });
                    Console.Clear();
                    goto secimYap;
                    break;
            }
            Console.Clear();
            Console.WriteLine("Ana Menuye Yonlendirildiniz.");
            goto secimYap;
        }
    }
}
