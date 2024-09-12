using UnityEngine;

public class MainClass : MonoBehaviour
{
    public void Start()
    {
        // ���ҧ����Ф�
        IronMan ironMan = new IronMan("IronMan", 100, "Red", 50);
        CaptainAmerica captainAmerica = new CaptainAmerica("Captain America", 100, "Blue", 40);

        System.Random random = new System.Random();

        // ����Ѵ�ѹ���� 5 �ͺ
        for (int round = 1; round <= 5; round++)
        {
            Debug.Log($"Round {round}:");

            // IronMan ���մ��� ShootLaser
            ironMan.ShootLaser();
            int damageToCaptain = random.Next(10, 21); // Damage Ẻ���������ҧ 10-20
            captainAmerica.TakeDamage(damageToCaptain);

            // ����ҵ�������ѧ
            if (captainAmerica.IsDead())
            {
                break;
            }

            // CaptainAmerica ���մ��� ThrowShield
            captainAmerica.ThrowShield();
            int damageToIronMan = random.Next(10, 21); // Damage Ẻ���������ҧ 10-20
            ironMan.TakeDamage(damageToIronMan);

            // ����ҵ�������ѧ
            if (ironMan.IsDead())
            {
                break;
            }
        }
    }
}
