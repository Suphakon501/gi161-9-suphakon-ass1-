using UnityEngine;

public class CaptainAmerica : SuperHero
{
    public CaptainAmerica(string name, int hp, string suitColor, float armorStrength)
        : base(name, hp, suitColor, armorStrength) 
    {
    }

    public void LeapAndJump()
    {
        Debug.Log($"{name} leaps and jumps.");
    }

    public void ThrowShield()
    {
        Debug.Log($"{name} throws a shield!");
    }
}
