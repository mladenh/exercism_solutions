abstract class Character
{
    private string characterType;

    protected Character(string characterType)
    {
        this.characterType = characterType;
    }

    public abstract int DamagePoints(Character target);

    public virtual bool Vulnerable()
    {
        return false;
    }

    public override string ToString()
    {
        return "Character is a " + characterType;
    }
}

class Warrior : Character
{
    public Warrior() : base("Warrior")
    {
    }

    public override int DamagePoints(Character target)
    {
        if (target.Vulnerable() == true)
        {
            return 10;
        }
        return 6;
    }
}

class Wizard : Character
{
    private bool preparedSpell = false;

    public Wizard() : base("Wizard")
    {
    }

    public override int DamagePoints(Character target)
    {
        if (preparedSpell != false)
        {
            return 12;
        }
        return 3;
    }

    public void PrepareSpell()
    {
        preparedSpell = true;
    }

    public override bool Vulnerable()
    {
        if (preparedSpell == false)
        {
            return true;
        }
        return false;
    }
}
