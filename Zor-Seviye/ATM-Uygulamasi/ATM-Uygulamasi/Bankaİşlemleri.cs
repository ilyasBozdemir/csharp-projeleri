using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Uygulamasi
{
    public class Bankaİşlemleri
    {
        public Clients _clients = new Clients();
        public Client _client = new Client();
        public Client _clientTo = new Client();
        public Logger _logger = new Logger();
        public bool isLogin(Client client)
        {
            _client = _clients.clientList.Where(c => c.Id == client.Id
                                              && c.Password == client.Password)
                                              .FirstOrDefault();

            return _clients.clientList.Contains(_client);
        }
        public void ParaYatırma(double Balance)
        {
            _client.Balance += Balance;
        }
        public void ParaCekme(double Balance)
        {
            _client.Balance -= Balance;
        }
        public bool HavaleYapma(double Balance, int clientId)
        {
            bool state = false;
            _clientTo = _clients.clientList.Where(c => c.Id == clientId).FirstOrDefault();
            if (_clientTo is null)
            {
                state = false;
            }
            _client.Balance -= Balance;
            _clientTo.Balance += Balance;
            return state=true;
        }
        public void GunSonuAl()
        {
            var rootPath = Directory.GetCurrentDirectory();
            string GunSonuKlasoruAdi = "EOD_Tarih";
            string today = DateTime.Now.ToString("ddMMyyy");
            string fileName = $"EOD_Tarih({today}).txt";
            string path = $"{rootPath}/{GunSonuKlasoruAdi}/{fileName}";
            using (FileStream fs = File.Create(path))
            {
                string content = GetContent();
                File.WriteAllText(path, content);
            }
            Console.WriteLine("Günsonu Alındı.");
        }
        private string GetContent()
        {
            List<Logger> _loggerList = Logger.loggers;
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var _logger in _loggerList)
            {
                string data =
                    $"No:{_logger.LogID} " +
                    $"Mesaj :{_logger.Message} " +
                    $"Yapılan İşlem : {_logger.TransactionName} " +
                    $"Tarih: {_logger.DateTime} ";
                stringBuilder.Append(data);
            }
            return stringBuilder.ToString();
        }
    }
}
