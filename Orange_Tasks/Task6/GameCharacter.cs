using System;

namespace Task6;

public abstract class GameCharacter
{
    string _name;


    public string Name{get;set;}
    private int _health;

    public int Health{
        get
        {
            return _health;
        }
        set
        {
            if (value > 0 && value < 100)
            _health = value;
            else
            _health = 100;
        }
    }

    public GameCharacter(string name, int health)
    {
        Name = name;
        Health = health;
    }

    public abstract void UseSpecialAbility();
    
    public virtual void TakeDamage(int amount){}

    public void Heal(int Amount)
    {
        if(Health < 100)
        {
            Health+=Amount;
            Console.WriteLine($"\nHealth restored by {Amount}: {Health}");
        }
        else
        {
            Console.WriteLine($"\nHealth is already full: {Health}");
        }
    }

    public void Heal()
    {
        if(Health < 100)
        {
            Health+=10;
            Console.WriteLine($"\nHealth restored by 10: {Health}");

        }
        else
        {
            Console.WriteLine($"\nHealth is already full: {Health}");

        }
    }


}
