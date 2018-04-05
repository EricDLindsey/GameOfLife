using System;

namespace GameOfLife
{
	class Program
	{
		static void Main()
		{
			Game g = new Game(60, 30);

			// F-pentomino
			g.Set(26, 16);
			g.Set(27, 16);
			g.Set(25, 17);
			g.Set(26, 17);
			g.Set(26, 18);

			// Acorn
			/*g.Set(30, 15);
			g.Set(32, 16);
			g.Set(29, 17);
			g.Set(30, 17);
			g.Set(33, 17);
			g.Set(34, 17);
			g.Set(35, 17);*/

			// T
			/*g.Set(30, 15);
			g.Set(29, 16);
			g.Set(30, 16);
			g.Set(31, 16);*/

			// Glider
			/*g.Set(5, 5);
			g.Set(6, 6);
			g.Set(4, 7);
			g.Set(5, 7);
			g.Set(6, 7);*/

			// Glider gun
			/*g.Set(2, 6);
			g.Set(3, 6);
			g.Set(2, 7);
			g.Set(3, 7);
			g.Set(14, 4);
			g.Set(15, 4);
			g.Set(13, 5);
			g.Set(12, 6);
			g.Set(12, 7);
			g.Set(12, 8);
			g.Set(13, 9);
			g.Set(14, 10);
			g.Set(15, 10);
			g.Set(16, 7);
			g.Set(17, 5);
			g.Set(18, 6);
			g.Set(18, 7);
			g.Set(19, 7);
			g.Set(18, 8);
			g.Set(17, 9);
			g.Set(22, 4);
			g.Set(22, 5);
			g.Set(22, 6);
			g.Set(23, 4);
			g.Set(23, 5);
			g.Set(23, 6);
			g.Set(24, 3);
			g.Set(24, 7);
			g.Set(26, 2);
			g.Set(26, 3);
			g.Set(26, 7);
			g.Set(26, 8);
			g.Set(36, 4);
			g.Set(37, 4);
			g.Set(36, 5);
			g.Set(37, 5);*/

			g.Run();
		}
	}
}