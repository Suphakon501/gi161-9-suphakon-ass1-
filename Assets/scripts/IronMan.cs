using UnityEngine;
public class IronMan : SuperHero
{
    public IronMan(string name, int hp, string suitColor, float armorStrength)
        : base(name, hp, suitColor, armorStrength) 
    {

    }

    public void Fly()
    {
        Debug.Log($"{Name} is flying.");
    }

    public void ShootLaser()
    {
        Debug.Log($"{Name} shoots a laser!");
    }
}
