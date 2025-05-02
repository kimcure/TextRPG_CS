using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Goblin : Character
{
    public Goblin(string name, int health, int defense, int attackpower) : base(name, health, defense, attackpower)
    {

    }

    public override void Attack(Character target)
    {
        Random rand = new Random();
        int attackpercent = rand.Next(1, 10);

        if (attackpercent < 6)
        {
            Console.WriteLine($"{Name}이/가 {target.Name}을/를 공격합니다!");
            target.TakeDamage(AttackPower - target.Defense);
        }
        else if (attackpercent < 11)
        {
            AttackSkill(target, AttackPower);
        }
    }

    public void AttackSkill(Character target, int damage)
    {
        damage = (damage - target.Defense) * 3;
        Console.WriteLine($"고블린이 깊게 찌르기 스킬을 사용하여 {damage} 만큼의 피해를 입었습니다!");
        target.TakeDamage(damage);
    }

    public override void EnemyDie(Player target)
    {
        Console.WriteLine($"{Name}를 처치했습니다! 얻은 exp: 50");
        target.Exp += 50;
    }
}
