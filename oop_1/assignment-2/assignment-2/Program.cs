using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Pokemon Battle Simulator!");
        Console.WriteLine("Enter a name for the first trainer:");
        string firstTrainerName = Console.ReadLine();
        Trainer firstTrainer = new Trainer(firstTrainerName);

        Console.WriteLine("Enter a name for the second trainer:");
        string secondTrainerName = Console.ReadLine();
        Trainer secondTrainer = new Trainer(secondTrainerName);

        // Assuming both trainers already have Charmanders in their belts
        for (int i = 0; i < 6; i++)
        {
            firstTrainer.AddPokeball(new Charmander($"Charmander {i + 1}"));
            secondTrainer.AddPokeball(new Charmander($"Charmander {i + 1}"));
        }

        bool continuePlaying = true;
        while (continuePlaying)
        {
            for (int i = 0; i < 6; i++)
            {
                firstTrainer.ThrowPokeball(i);
                secondTrainer.ThrowPokeball(i);
                firstTrainer.ReturnPokemon(i);
                secondTrainer.ReturnPokemon(i);
            }

            Console.WriteLine("Do you want to continue battling? (yes/no)");
            string response = Console.ReadLine().ToLower();
            if (response == "no")
            {
                continuePlaying = false;
            }
        }

        Console.WriteLine("Thanks for playing!");
    }
}
