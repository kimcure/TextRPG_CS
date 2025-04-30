using System;

public class Program
{
    static void Main()
    {
        Character player = new Character("Name", 100, 10, 20);
        Character enemy = new Character("Name2", 100, 15, 15);

        player.Attack(enemy);
        enemy.Attack(player);
    }
}