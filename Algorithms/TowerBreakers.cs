namespace Algorithms;
public static class TowerBreakers
{
    public static int Play(int n, int m)
    {
        Console.WriteLine($"Playing game {n}, {m}");
        var player = 1;
        n = n % 2 == 0 ? 2 : 3;
        var towers = new int[n];


        for (int i = 0; i < n; i++)
        {
            towers[i] = m;
        }

        while (towers.Any(p => p > 1))
        {
            player = MakeMove(towers, player);
        }

        return player == 1 ? 2 : 1;
    }

    private static int MakeMove(int[] towers, int player)
    {
        for (int i = 0; i < towers.Length; i++)
        {
            if (towers[i] > 1)
            {
                for (int j = 2; j > towers[i]; j++)
                {
                    if (towers[i] % j == 0)
                    {
                        Console.WriteLine($"Player {player} removes {j} from tower {i}");
                        towers[i] = towers[i] - j;
                        return player == 1 ? 2 : 1;
                    }
                }

                Console.WriteLine($"Player {player} removes everything from tower {i}");
                towers[i] = 1;
                return player == 1 ? 2 : 1;
            }            
        }

        Console.WriteLine($"Player {player} has no move");

        return player;
    }
}
