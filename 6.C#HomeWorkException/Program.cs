using _6.C_HomeWorkException;
using static _6.C_HomeWorkException.User;
Card card1 = new ("2190-9191-0120-8917","2120", "821","01/25", 3000);
Card card2 = new ("7810-5798-7854-4112","0919", "121","02/29", 2000);
Card card3 = new ("8576-1781-0425-0113","2229", "701","04/29", 2400);
User user = new("Arif", "Rustamov",card1);
User user1 = new("Fariz", "Shemseddin",card2);
User user2 = new("Tahir", "Orxanzade",card3);
//Card[][] cards = new Card[2][] {
    
//}
Card[][] CARDS = new Card[3][];
CARDS[0] = new Card[] { card1};
CARDS[1] = new Card[] { card2 };
CARDS[2] = new Card[] { card3 };

while (true)
{
    Console.Write("PIN i Daxil Et : ");
    string checkPin = (Console.ReadLine());
    foreach (Card[] cardss in CARDS)
    {
        foreach (Card cards in cardss)
        {
            if (checkPin == cards.PIN)
            {
                Console.WriteLine("True");
                cards.ShowI();
                return;
            }
            else
                Console.WriteLine("");
            //return;
        }
    }
}
//card1.ShowI();
//card2.ShowI();
//card3.ShowI();
//user.ShowI();   
//user1.ShowI();   
//user2.ShowI();   
//if (checkPin == ) ;
