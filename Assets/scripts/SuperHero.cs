using UnityEngine;
public class SuperHero:MonoBehaviour
{
    protected string _name;
    public string Name
    {
        get { return _name; }
        set
        {
            if (value == null || value == "")
            {
                value = "N/A";
                _name = value;
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
        _name = newName; 
    }
    

    public  void TakeDamage(int damage)
    {
        hp -= damage;
        Debug.Log($"{_name} took {damage} damage. Remaining HP: {hp}");
        if (IsDead())
        {
            Debug.Log($"{_name} has fallen.");
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
