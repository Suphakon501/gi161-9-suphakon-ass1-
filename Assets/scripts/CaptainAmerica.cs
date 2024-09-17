using UnityEngine;

public class CaptainAmerica : SuperHero
{
    public void LeapAndJump()
    {
        Debug.Log($"{_name} leaps and jumps.");
    }

    public void ThrowShield()
    {
        Debug.Log($"{_name} throws a shield!");
    }
}
