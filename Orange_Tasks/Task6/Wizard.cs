using System;

namespace Task6;

public class Wizard:GameCharacter
{
    
    public Wizard(string name, int health):base(name, health){}
    public override void UseSpecialAbility()
    {
        System.Console.WriteLine($"The {Name} Wizard throws a fireball!");
    }

    public override void TakeDamage(int amount)
    {
        Health-= amount;
        Console.WriteLine($"The character's {Name} health after taking a demage: {Health}");
    }
}
