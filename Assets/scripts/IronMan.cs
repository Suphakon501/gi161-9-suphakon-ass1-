using UnityEngine;
public class IronMan : SuperHero
{
    public void Fly()
    {
        Debug.Log($"{_name} is flying.");
    }

    public void ShootLaser()
    {
        Debug.Log($"{_name} shoots a laser!");
    }
}
