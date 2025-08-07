using System;

class Program
{
    static void Main()
    {
        Random rng = new Random();
        int playerHP = 100;
        int botHP = 100;

        while (playerHP > 0 && botHP > 0)
        {
            Console.WriteLine($"Your hp: {playerHP}, Enemy hp: {botHP}");
            Console.WriteLine("1 to attack");
            Console.WriteLine("2 to defend");
            Console.WriteLine("3 to flee");
            char choice = Console.ReadKey().KeyChar;

            if (choice == '1')
            {
                Console.Clear();
                int botchoice = rng.Next(1, 3);
                if (botchoice == 2)
                {
                    Console.WriteLine("\nBot defended. No damage");
                }
                else
                {
                    int playerdmg = rng.Next(1, 16);
                    Console.WriteLine($"Enemy took {playerdmg} damage!");
                    botHP -= playerdmg;
                    int botdmg = rng.Next(1, 16);
                    Console.WriteLine($"You took {botdmg} damage!");
                    playerHP -= botdmg;
                }
            }
            else if (choice == '2')
            {
                Console.Clear();
                int botchoice = rng.Next(1, 3);
                if (botchoice == 1)
                {
                    int dmgchance = rng.Next(1, 3);
                    if (dmgchance == 2)
                    {
                        int botdmg = rng.Next(1, 16);
                        playerHP -= botdmg;
                        Console.WriteLine($"\nYou took {botdmg} damage!");
                    }
                    else
                    {
                        Console.WriteLine("\nYou defended yourself. No damage taken.");
                    }
                }
                else
                {
                    Console.WriteLine("\nBoth of you defended. Skipping round.");
                }
            }
            else if (choice == '3')
            {
                Console.Clear();
                Console.WriteLine("\nYou ran away. What a coward, your enemy says.");
                return;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("\nSelect a valid option.");
            }
        }
        if (playerHP <= 0 && botHP <= 0)
        {
            Console.WriteLine("It's a draw! You both died at the same time.");
        }
        else if (playerHP <= 0)
        {
            Console.WriteLine("You died. Game over.");
        }
        else if (botHP <= 0)
        {
            Console.WriteLine("You defeated the enemy! Goodjob.");
        }
    }
}
