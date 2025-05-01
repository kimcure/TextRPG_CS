using System;

public class Program
{
    static void Main()
    {
        Item player = new Item("Name", 100, 10, 20);
        Orc orc = new Orc("오크", 50, 5, 30);

        player.Attack(orc);
        orc.Attack(player);

        player.Heal();
    }
}