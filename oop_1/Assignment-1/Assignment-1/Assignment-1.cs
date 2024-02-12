using System;

class Charmander // class met de naam charmander
{               // dit zijn de class properties
    public string Nickname { get; private set; }
    public string Strength { get; }
    public string Weakness { get; }

    public Charmander(string nickname) // ik geef hier de arg nickname aan Class Charmander
    {
        Nickname = nickname;
        Strength = "Fire";
        Weakness = "Water";
    }

    public void BattleCry()
    {
        Console.WriteLine($"Charmander says: {Nickname}!");
    }
}
class Pokeball
{
    public Pokeball()
    {
      
    }
}
class Program
{
    static void Main(string[] args) // Main zorgt ervoor dat de code hier begint.
    {
        Console.WriteLine("Welcome to the Pokemon Battle Simulator!");
        Console.WriteLine("Enter a name for your Charmander:");

        string charmanderName = Console.ReadLine(); // leest de vorige line's input en gebruikt het voor de string charmanderName
        Charmander charmander = new Charmander(charmanderName); // je maakt een object charmander met de naam charmander en de gegeven naam.

        bool continuePlaying = true;
        while (continuePlaying)
        {
            Console.WriteLine($"Your Charmander, {charmander.Nickname}, does its battle cry:");
            for (int i = 0; i < 10; i++)
            {
                charmander.BattleCry();
            }

            Console.WriteLine("Do you want to rename your Charmander? (yes/no)");
            string response = Console.ReadLine().ToLower();
            if (response == "yes")
            {
                Console.WriteLine("Enter a new name for your Charmander:");
                charmanderName = Console.ReadLine();
                charmander = new Charmander(charmanderName);
            }
            else if (response == "no")
            {
                continuePlaying = false;
            }
            else
            {
                Console.WriteLine("Invalid input. Exiting the game.");
                continuePlaying = false;
            }
        }

        Console.WriteLine("Thanks for playing!");
    }
}