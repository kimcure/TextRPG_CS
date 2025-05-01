using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Item : Character
{
    public Item(string name, int health, int defense, int attackpower) : base(name, health, defense, attackpower)
    {

    }

    public void Heal()
    {
        Health += 20;
        Console.WriteLine("체력이 20 회복되었습니다! 남은 체력: " + Health);
    }

    public void AttackPowerUp()
    {
        AttackPower += 20;
        Console.WriteLine("공격력이 20 증가했습니다!");
    }
}
