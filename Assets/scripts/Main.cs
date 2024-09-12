using UnityEngine;

public class MainClass : MonoBehaviour
{
    public void Start()
    {
        // สร้างตัวละคร
        IronMan ironMan = new IronMan("IronMan", 100, "Red", 50);
        CaptainAmerica captainAmerica = new CaptainAmerica("Captain America", 100, "Blue", 40);

        System.Random random = new System.Random();

        // ให้ผลัดกันโจมตี 5 รอบ
        for (int round = 1; round <= 5; round++)
        {
            Debug.Log($"Round {round}:");

            // IronMan โจมตีด้วย ShootLaser
            ironMan.ShootLaser();
            int damageToCaptain = random.Next(10, 21); // Damage แบบสุ่มระหว่าง 10-20
            captainAmerica.TakeDamage(damageToCaptain);

            // เช็คว่าตายหรือยัง
            if (captainAmerica.IsDead())
            {
                break;
            }

            // CaptainAmerica โจมตีด้วย ThrowShield
            captainAmerica.ThrowShield();
            int damageToIronMan = random.Next(10, 21); // Damage แบบสุ่มระหว่าง 10-20
            ironMan.TakeDamage(damageToIronMan);

            // เช็คว่าตายหรือยัง
            if (ironMan.IsDead())
            {
                break;
            }
        }
    }
}
