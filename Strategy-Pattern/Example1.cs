class Character
{
    private ICombatStrategy combatStrategy;

    public Character(ICombatStrategy combatStrategy)
    {
        this.combatStrategy = combatStrategy;
    }
    public Character(){}

    public void SetCombatStrategy(ICombatStrategy combatStrategy)
    {
        this.combatStrategy = combatStrategy;
    }

    public void ApplyAttactStrategy()
    {
        combatStrategy.Attack();
    }

}
interface ICombatStrategy
{
    void Attack();
}

class AgressiveCombatStrategy : ICombatStrategy
{
    public void Attack()
    {
        Console.WriteLine("Agressive Attack");
    }
}

class DefensiveCombatStrategy : ICombatStrategy
{
    public void Attack()
    {
        Console.WriteLine("Defensive Attack");
    }
}