using System;

public class Pokeball
{
    private bool isOpen;
    private Charmander charmander;

    public Pokeball()
    {
        isOpen = false;
        charmander = null; // Initialize as empty
    }

    public bool IsEmpty()
    {
        return charmander == null;
    }

    public void Throw()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Cannot throw an empty Pokeball!");
            return;
        }

        isOpen = true;
        Console.WriteLine($"Pokeball thrown! {charmander.Nickname} is out!");
        charmander.BattleCry();
    }

    public void Return()
    {
        isOpen = false;
        Console.WriteLine($"Pokeball returned! {charmander.Nickname} is back!");
    }

    public void Empty()
    {
        charmander = null;
        Console.WriteLine("Pokeball is now empty.");
    }

    public void Fill(Charmander charmander)
    {
        if (!IsEmpty())
        {
            Console.WriteLine("Cannot fill Pokeball! It's already occupied.");
            return;
        }

        this.charmander = charmander;
        Console.WriteLine($"Pokeball filled with {charmander.Nickname}.");
    }
}
