namespace RPG;

class Program
{
    static void Main(string[] args)
    {
        Fighter doggo = new Fighter("Doggo", 250, 20);  // Create a basic Fighter object
        Fighter gojo = new Mage("Gojo", 250, 19);  // Create a Mage object, typed as Fighter
        Fighter sukuna = new Warrior("Sukuna", 250, 25);  // Create a Warrior object, typed as Fighter  
        
        doggo.Attack(); // Calls Fighter.Attack()
        gojo.Attack(); // Calls Mage.Attack() due to override (polymorphism)
        sukuna.Attack(); // Calls Warrior.Attack() due to override (polymorphism)
    }
}
