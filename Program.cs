using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1oop
{
    class ATM
    {
        public string adres;
        public int number_human;
        private double price;

        public double Price
        {
            set
            {
                price = value;
            }
        }

        public double Calculation()
        {
            return price*number_human;
        }
        public void Print()
        {
            Console.WriteLine($"Адрес АТС: {adres}");
            Console.WriteLine($"Абонентская плата: {Calculation()}");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите количесво пользователей:");
            string number_human;

            while (true)
            {
                number_human = Console.ReadLine();

                if (int.TryParse(number_human, out int number))
                {
                    if (number >= 0)
                    {
                        Console.WriteLine($"Вы ввели число {number}");
                        break;
                    }
                }
                Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
                
            }

            ATM aTM = new ATM();
            aTM.number_human = System.Convert.ToInt32(number_human);
            aTM.adres = "Ул.Ленина";
            aTM.Price = 20;
            aTM.Print();
        }
    }
}
