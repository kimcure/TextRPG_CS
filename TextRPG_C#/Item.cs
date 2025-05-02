using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Item
{
    public Item()
    {

    }

    public void Heal(Player target)
    {
        target.Health += 60;
        Console.WriteLine("체력이 60 회복되었습니다! 남은 체력: " + target.Health);
    }

    public void AttackPowerUp(Player target)
    {
        target.AttackPower += 20;
        Console.WriteLine("공격력이 1회 20 증가합니다!");
    }
}
