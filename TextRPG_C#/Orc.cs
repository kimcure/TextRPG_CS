using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Orc : Character
{
    public Orc(string name, int health, int defense, int attackpower) : base(name, health, defense, attackpower)
    {
        
    }


    public override void Attack(Character target)
    {
        Random rand = new Random();
        int attackpercent = rand.Next(1, 10);

        if (attackpercent < 6)
        {
            Console.WriteLine($"{Name}이/가 {target.Name}을/를 공격합니다!");
            target.TakeDamage(AttackPower);
        }
        else if (attackpercent < 11)
        {
            AttackSkill(target, AttackPower);
        }
    }

    public void AttackSkill(Character target, int damage)
    {
        damage = (AttackPower - target.Defense) * 3;
        if (damage < 0)
        {
            Console.WriteLine("공격을 1회 방어하셨습니다.");
            target.TakeDamage(0);
        }
        else
        {    
            Console.WriteLine($"오크가 강타 스킬을 사용하여 {damage} 만큼의 피해를 입었습니다!");
            target.TakeDamage(damage);
        }
    }

    public void Die(Player target)
    {
        Console.WriteLine("오크를 처치했습니다! 얻은 exp: 100");
        target.Exp += 100;
    }
}
