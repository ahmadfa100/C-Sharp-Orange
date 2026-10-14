using System;

namespace Task6;

public class HealthPotion:ICollectible
{
    public string PotionName{get;set;}
    public void Collect()
    {
        Console.WriteLine("Health potion collected!");
    }   

       public void Use(GameCharacter character, string amountText) {
            try
            {
                int newAmount = Convert.ToInt32(amountText);
                character.Heal(newAmount);
            }
            catch (Exception ex) {
                 Console.WriteLine("Invalid input! Please enter a number"); 
                 }
            
        }

}
