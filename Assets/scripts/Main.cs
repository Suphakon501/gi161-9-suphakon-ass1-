using System;
using Unity.VisualScripting;
using UnityEngine;

public class MainClass : MonoBehaviour
{
    IronMan ironMan = new IronMan("IronMan", 100, "Red", 50);
    CaptainAmerica captainAmerica = new CaptainAmerica("Captain America", 100, "Blue", 40);
    System.Random random = new System.Random();

    public void Start()
    {
        // ���ҧ����Ф�
        IronMan ironMan = new IronMan("IronMan", 100, "Red", 50);
        CaptainAmerica captainAmerica = new CaptainAmerica("Captain America", 100, "Blue", 40);
        System.Random random = new System.Random();
    }
    private void Update()
    {
        if (ironMan.IsDead()||(captainAmerica.IsDead()))
        {
            return;
        }
        
    
        // IronMan ���մ��� ShootLaser
        ironMan.ShootLaser();
        int damageToCaptain = random.Next(10, 21); // Damage Ẻ���������ҧ 10-20
        captainAmerica.TakeDamage(damageToCaptain);

       
        

        // CaptainAmerica ���մ��� ThrowShield
        captainAmerica.ThrowShield();
        int damageToIronMan = random.Next(10, 21); // Damage Ẻ���������ҧ 10-20
        ironMan.TakeDamage(damageToIronMan);

      
       
    }
}
