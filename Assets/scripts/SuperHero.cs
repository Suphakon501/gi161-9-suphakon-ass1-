using UnityEngine;
public class SuperHero
{
    protected string name;
    public string Name
    {
        get { return name; }
        set
        {
            if (value == null || value == "")
            {
                value = "N/A";
                name = value;
            }
        }
    }
        
    protected int hp;
    public int HP
    {
        get { return hp; }
        set { hp = value; }
    }

    protected string suitColor;
    public string SuitColor
    { get;set;}
    protected float armorStrength;
    public string GetSuitColor()
    { 
        return suitColor; 
    }
    public void SetName(string newName)
    {
        name = newName; 
    }
    public SuperHero(string newName, int newHp, string newSuitColor, float newArmorStrength)
    {
        name = newName;
        hp = newHp;
        suitColor = newSuitColor;
        armorStrength = newArmorStrength;
    }

    public  void TakeDamage(int damage)
    {
        hp -= damage;
        Debug.Log($"{name} took {damage} damage. Remaining HP: {hp}");
        if (IsDead())
        {
            Debug.Log($"{name} has fallen.");
        }
    }

    public bool IsDead()
    {
        return hp <= 0;
    }

    public void UpdateStrength(float newStrength)
    {
        armorStrength = newStrength;
    }
}
