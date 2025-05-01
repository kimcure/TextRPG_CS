using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Character
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int Defense { get; set; }
    public int AttackPower { get; set; }

    public Character(string name, int health, int defense, int attackpower)
    {
        Name = name;
        Health = health;
        Defense = defense;
        AttackPower = attackpower;
    }

    public virtual void Attack(Character target)
    {
        Console.WriteLine($"{Name}이/가 {target.Name}을/를 공격합니다!");
        target.TakeDamage(AttackPower - target.Defense);
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;

        if (Health < 0)
        {
            Health = 0;
        }

        Console.WriteLine(Name + "의 남은 체력: " + Health);
    }
}
