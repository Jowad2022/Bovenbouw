using System;
using System.Collections.Generic;

public class Trainer
{
    public string Name { get; private set; }
    public List<Pokeball> Belt { get; private set; }

    public Trainer(string name)
    {
        Name = name;
        Belt = new List<Pokeball>();
    }

    public void AddPokeball(Charmander charmander)
    {
        if (Belt.Count >= 6)
        {
            throw new Exception("Belt cannot contain more than 6 Pokeballs!");
        }

        Belt.Add(new Pokeball());
        Belt[Belt.Count - 1].Fill(charmander);
    }

    public void ThrowPokeball(int index)
    {
        Belt[index].Throw();
    }

    public void ReturnPokemon(int index)
    {
        Belt[index].Return();
    }
}
