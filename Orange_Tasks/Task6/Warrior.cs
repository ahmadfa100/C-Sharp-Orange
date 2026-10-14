using System;

namespace Task6;

public class Warrior:GameCharacter
{
    public Warrior(string name, int health):base(name, health){}

    public override void TakeDamage(int amount)
    {
        Health = Math.Abs(Health - amount + 2) ;
        Console.WriteLine($"The character's {Name} health after taking a demage: {Health}");

    }


    public override void UseSpecialAbility()
    {
        System.Console.WriteLine($"The {Name} Warrior attacks with a sword!");
    }



}
