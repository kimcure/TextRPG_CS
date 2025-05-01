using System;

public class Program
{
    static void Main()
    {
        Player player = new Player("Name", 100, 10, 20, 0, 0);
        Orc orc = new Orc("오크", 50, 5, 30);

        player.AttackSkill(orc);

        if (orc.Health == 0)
        {
            orc.Die(player);
        }

        if (player.Exp >= 100)
        {
            player.LvUp();
        }
    }
}