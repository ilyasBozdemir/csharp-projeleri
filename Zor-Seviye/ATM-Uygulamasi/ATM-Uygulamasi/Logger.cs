using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Uygulamasi
{
    public enum Transaction
    {
        GirisYapıldı = 0,
        GirisBasarisiz,
        HataliSecim,
        ParaCekildi,
        ParaYatırıldı,
        ParaGonderildi
    }
    public class Logger
    {
        public static List<Logger> loggers = new List<Logger>();
        public int LogID { get;private set; }
        public Transaction TransactionName { get; set; }
        public string Message { get; set; }
        private DateTime dateTime;
        public DateTime DateTime 
          { 
            get => dateTime;
            private set => dateTime = DateTime.Now;
           }
        public Logger()
        {
            Sayac = 0;
        }
        int Sayac = 0;
        public void SaveLogger(Logger logger)
        {
            Sayac++;
            logger.LogID += Sayac;
            loggers.Add(logger);
        }
        public List<Logger> GetLoggers()
        {
            return loggers;
        }

    }
}
