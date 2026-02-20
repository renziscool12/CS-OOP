namespace RPG;

class Fighter
{
    public string Name { get; set; }  // Name of the fighter, accessible publicly
    private protected int Health { get; set; }  // Health stat, accessible only in this class or child classes
    private protected int AttackPower { get; set; } // Attack power stat, accessible only in this class or child classes

    public Fighter(string name, int health, int attackPower) // Constructor: initializes fighter stats
    {
        Name = name; // Set the Name property
        Health = health;  // Set Health
        AttackPower = attackPower; // Set AttackPower
    }

    public virtual void Attack() // Virtual method allows child classes to override
    {
        Console.WriteLine($"{Name} attacks for {AttackPower} damage!"); // Prints basic attack
    }
}

class Warrior : Fighter // Warrior inherits from Fighter
{
    // Just constructor to pass values to parent, you can change its value if you want to
    public Warrior(string name, int health, int attackPower) : base(name, health, attackPower){ }

    public override void Attack()   // Overrides parent Attack method   
    {
        base.Attack();  // Calls the original Attack() from Fighter first
        Console.WriteLine($"{Name} uses PowerStrike for {AttackPower} massive damage!"); // Adds special attack
    }
}

class Mage : Fighter // Mage inherits from Fighter
{
    public Mage(string name, int health, int attackPower) : base(name, health, attackPower){ }  // Constructor passes values to parent Fighter class

    public override void Attack() // Overrides parent Attack method
    {
        base.Attack(); // Calls base Attack() first
        Console.WriteLine($"{Name} casts a fireball for {AttackPower} damage!"); // Adds special attack
    }
}
