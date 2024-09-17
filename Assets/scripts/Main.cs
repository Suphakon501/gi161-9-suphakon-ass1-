using System;
using Unity.VisualScripting;
using UnityEngine;

public class MainClass : MonoBehaviour
{
    IronMan ironMan = new IronMan("IronMan", 100, "Red", 50);
    CaptainAmerica captainAmerica = new CaptainAmerica("Captain America", 100, "Blue", 40);
   

    public void Start()
    {
        // ���ҧ����Ф�
        Debug.Log($"Ironman name {ironMan.Name}, Hp:{ironMan.HP},color:{ironMan.SuitColor}");
        Debug.Log($"CaptainAmerica {captainAmerica.Name}, Hp:{captainAmerica.HP},color:{captainAmerica.SuitColor}");   
    }
    private void Update()
    {
        if (ironMan.IsDead()||(captainAmerica.IsDead()))
        {
            return;
        }
      
        System.Random random = new System.Random();
      
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
