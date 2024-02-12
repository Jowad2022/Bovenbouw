using System;

public class Charmander
{
    public string Nickname { get; private set; }
    public string Strength { get; }
    public string Weakness { get; }

    public Charmander(string nickname)
    {
        Nickname = nickname;
        Strength = "Fire";
        Weakness = "Water";
    }

    public void BattleCry()
    {
        Console.WriteLine($" Charmander says: {Nickname}!");
    }
}
