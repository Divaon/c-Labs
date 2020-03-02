using System;


namespace ISPLABS
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Console.WriteLine("Game start");
            int AI, gamer = 0, check = 1, take = 1, card;
            while (check == 1)
            {
                gamer = 0;
                AI = rand.Next(15, 21); take = 1;
                while (take == 1)
                {
                    card = rand.Next(2, 11);
                    if (card == 11)
                    {

                        Console.WriteLine("Now you can choose take 1(give me 1) or 11(give me 2).");
                        check = Convert.ToInt32(Console.ReadLine());
                        if (check == 1) { card = 1; }
                        if (check == 2) { card = 11; }
                    }
                    check = 1;
                    gamer = gamer + card;
                    Console.WriteLine($"You have now {gamer} and get some earlier {card}.");
                    if (gamer > 21)
                    {
                        Console.WriteLine($"You get {gamer}, when AI have {AI} and loose!!");
                        take = 0;
                        break;
                    }
                    Console.WriteLine("You would like to continio(1) or end this party(another nomber)?");
                    take = Convert.ToInt32(Console.ReadLine());

                }
                if (AI >= gamer)
                {
                    Console.WriteLine($"You have {gamer}, when AI have {AI}. So, you Looser!!!");
                }
                else
                {
                    Console.WriteLine($"You have {gamer}, when AI have {AI}. So, you Winner!!!");
                }
                Console.WriteLine("You would like to repeat(1) or end this game(another nomber)?");

                check = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
