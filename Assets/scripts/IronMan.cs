using UnityEngine;
public class IronMan : SuperHero
{
    public IronMan(string name, int hp, string suitColor, float armorStrength)
        : base(name, hp, suitColor, armorStrength) 
    {

    }

    public void Fly()
    {
        Debug.Log($"{name} is flying.");
    }

    public void ShootLaser()
    {
        Debug.Log($"{name} shoots a laser!");
    }
}
