using Task6;

System.Console.WriteLine("\n===== ADVENTURE GAME =====\n");

Warrior warrior = new Warrior("Ahmad", 70);
Wizard  wizard = new Wizard("Mohammad", 100);

List<GameCharacter> characters = new() { warrior, wizard };

foreach (var character in characters)
{
    System.Console.WriteLine($"\n ----- Character's name : {character.Name} ");
    character.UseSpecialAbility();
    System.Console.WriteLine("\n now the character after taking a demage : \n");
    character.TakeDamage(10);
    System.Console.WriteLine("\n now the character after taking a Heal : \n");
    character.Heal();
    character.Heal(3);

}

System.Console.WriteLine("\n now the HealthPoint object turn \n");

HealthPotion obj = new HealthPotion();
obj.Collect();

obj.Use(wizard,"7");
obj.Use(warrior,"abc");