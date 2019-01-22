using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AstraPlat
{
    public class Astra
    {
        public string CardType { get; set; }
       public  int Balanсe { get;  set; }
        public int Recharge { get; set; }
        public string BusType { get; set; }
        private int _express = 150;
        private int _cityBus = 90;
        private int _cityBusChildren = 40;
        private int _cityBusPreferential = 0;
        private int _shuttleBus = 100;

        public void Choose()
        {
            Balanсe = 0;
            
                
             Console.WriteLine("Пополните баланс на любую сумму");
                Balanсe = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Сумма  на Вашем балансе: " + Balanсe);
            Console.WriteLine("Выберите тип автобуса:Эспресс,городской или пригородный");
            BusType = Console.ReadLine();
            Console.WriteLine("Выберите тип карты:Детский, обычный или льготный");
            CardType = Console.ReadLine();

            if (BusType=="Экспресс"&&CardType=="Детский"|| BusType == "Экспресс" && CardType == "Обычный"|| BusType == "Экспресс" && CardType == "Льготный")
            {
                Console.WriteLine("Стоимость проезда 150тг");
                Console.WriteLine("Баланс:" +(Balanсe - _express));
            }
             if (BusType=="Городской"&&CardType=="Детский")
            {
                Console.WriteLine("Стоимость проезда 40тг");
                Console.WriteLine("Баланс:" + (Balanсe - _cityBusChildren));
            }
            if (BusType == "Городской" && CardType == "Обычный")
            {
                Console.WriteLine("Стоимость проезда 90тг");
                Console.WriteLine("Баланс:" + (Balanсe - _cityBus));
            }
            if (BusType == "Городской" && CardType == "Льготная")
            {
                Console.WriteLine("Стоимость проезда 0тг");
                Console.WriteLine("Баланс:" + (Balanсe - _cityBusPreferential));
            }

            if (BusType == "Пригородный" && CardType == "Детский" || BusType == "Пригородный" && CardType == "обычный" || BusType == "Пригородный" && CardType == "льготный")
            {
                Console.WriteLine("Стоимость проезда 100тг");
                Console.WriteLine("Баланс:" + (Balanсe - _shuttleBus));
            }










            Console.ReadLine();
        }
    }
}
