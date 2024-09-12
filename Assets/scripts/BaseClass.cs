using UnityEngine;
public class SuperHero
{
    public string Name;
    public int Hp;
    public string SuitColor;
    protected float armorStrength;

    public SuperHero(string name, int hp, string suitColor, float armorStrength)
    {
        Name = name;
        Hp = hp;
        SuitColor = suitColor;
        this.armorStrength = armorStrength;
    }

    public virtual void TakeDamage(int damage)
    {
        Hp -= damage;
        Debug.Log($"{Name} took {damage} damage. Remaining HP: {Hp}");
        if (IsDead())
        {
            Debug.Log($"{Name} has fallen.");
        }
    }

    public bool IsDead()
    {
        return Hp <= 0;
    }

    public void UpdateStrength(float newStrength)
    {
        armorStrength = newStrength;
    }
}
