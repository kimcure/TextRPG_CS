using System;
using System.Numerics;

public class Program
{
    static void Main()
    {
        Console.WriteLine("C# RPG에 오신 것을 환영합니다!");
        Console.WriteLine("이름을 입력해주세요.");
        
        string? name = Console.ReadLine();

        Player player = new Player(name, 100, 10, 20, 0, 0);
        Orc orc = new Orc("오크", 50, 5, 30);
        Goblin goblin = new Goblin("고블린", 30, 10, 20);
        Item item = new Item();

        Console.WriteLine($"반갑습니다. {name}.");

        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("메뉴를 번호로 선택해주세요.");
            Console.WriteLine("1. 모험하기");
            Console.WriteLine("2. 게임 종료");

            string? startinput = Console.ReadLine();

            if (startinput == "1")
            {
                Random rand = new Random();
                int randommonster = rand.Next(1, 100);

                if (randommonster < 66)
                {
                    Console.WriteLine("모험을 진행하던 중... 고블린이 등장합니다!");

                    goblin.Health = 30;
                    Battle(player, goblin, item);
                }
                else if (randommonster < 101)
                {
                    Console.WriteLine("모험을 진행하던 중... 오크가 등장합니다!");

                    orc.Health = 50;
                    Battle(player, orc, item);
                }
            }
            else if (startinput == "2")
            {
                Console.WriteLine("게임을 종료합니다.");
                break;
            }
            else
            {
                Console.WriteLine("올바른 번호를 입력해주셔야 합니다.");
            }
        }
    }

    public static void Battle(Player player, Character enemy, Item item)
    {
        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("1. 방어하기");
            Console.WriteLine("2. 공격하기");
            Console.WriteLine("3. 아이템 사용");

            string? input = Console.ReadLine();

            if (input == "1")
            {
                player.DefenseSkill();
            }
            else if (input == "2")
            {
                Console.WriteLine();
                player.Attack(enemy);
                if (enemy.Health == 0)
                {
                    enemy.EnemyDie(player);
                    player.AttackPower = 20;

                    if (player.Exp >= 100)
                    {
                        player.LvUp();
                    }
                    break;
                }
                else
                {
                    enemy.Attack(player);
                    player.AttackPower = 20;
                }

            }
            else if (input == "3")
            {
                Console.WriteLine();
                Console.WriteLine("두 가지의 아이템이 있습니다.");
                Console.WriteLine("1. 회복물약");
                Console.WriteLine("2. 공격력 증가 물약");

                string? input2 = Console.ReadLine();
                if (input2 == "1")
                {
                    Console.WriteLine();
                    item.Heal(player);
                    enemy.Attack(player);
                }
                else if (input2 == "2")
                {
                    Console.WriteLine();
                    item.AttackPowerUp(player);
                    enemy.Attack(player);
                }
                else
                {
                    Console.WriteLine("잘못된 번호입니다. 턴이 지나갑니다.");
                }
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("올바른 번호를 선택해주셔야 합니다.");
            }

            if (player.Health == 0)
            {
                player.Die();
            }
        }
    }
}