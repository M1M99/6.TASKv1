using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _6.C_HomeWorkException
{
    public class Card
    {
        string Card16Num;
        public string PIN;
        string CVC;
        string Expire_Date;
        decimal Balans;

        public Card(string card16Num)
        {
            Card16Num = card16Num;
        }

        public Card(string card16Num, string pIN, string cVC, string expire_Date, decimal balans)
        {
            Card16Num = card16Num;
            PIN = pIN;
            CVC = cVC;
            Expire_Date = expire_Date;
            Balans = balans;
        }

        public void ShowI()
        {
            Console.WriteLine($"PAN : {Card16Num}\nPIN : {PIN}\nCVC : {CVC}\nLastUseDate : {Expire_Date}\nBalans : {Balans}$\n");
        }
    }

    public class User
    {
        public User(string name, string surname, Card creditcard)
        {                                                                          
            Name = name;                                                           
            Surname = surname;    
            CreditCard = creditcard;
        }

        public string Name { get; set; }
        public string Surname { get; set; }
        public Card CreditCard {  get; set; }

        public void ShowI()
        {
            Console.Write($"Name : {Name}\nSurName : {Surname}\nCard : \n");
            CreditCard.ShowI();
        }

    }
    
}
