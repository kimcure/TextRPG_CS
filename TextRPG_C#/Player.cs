using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Player : Character
{
    public int Exp {  get; set; }
    public int Lv { get; set; }
    public Player(string name, int health, int defense, int attackpower, int exp, int lv) : base(name, health, defense, attackpower)
    {
        Exp = exp;
        Lv = lv;
    }

    public void AttackSkill(Character target)
    {
        int damage = (AttackPower - target.Defense) * 3;

        Console.WriteLine($"약점 베기 스킬을 사용하여 {damage}만큼의 피해를 입혔습니다!");

        target.TakeDamage(damage);
    }

    public void LvUp()
    {
        Lv++;
        Console.WriteLine("레벨 업을 했습니다! 현재 레벨: " + Lv);
    }
}
