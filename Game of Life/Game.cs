using System;
using System.Collections.Generic;

namespace GameOfLife
{
	class Game
	{
		public Game(int x, int y)
		{
			grid = new Grid(x, y);
		}
		
		public Grid grid;
		
		public void Set(int x, int y)
		{
			grid[x, y] = true;
		}
		
		public void Run()
		{
			draw();
			
			while(Console.ReadLine() != "q")
			{
				eval();
				Console.Clear();
				draw();
			}
		}
		
		void eval()
		{
			List<Cell> cells = grid.GetCells();
			List<Cell> toChange = new List<Cell>();
			
			foreach(Cell c in cells)
			{
				int n = grid.GetNeighbors(c);
				
				if(grid.IsAlive(c))
				{
					if(n < 2 || n > 3)
						toChange.Add(c);
				}
				else
				{
					if(n == 3)
						toChange.Add(c);
				}
			}
			
			grid.Change(toChange);
		}
		
		void draw()
		{
			Console.WriteLine("Game of Life. Enter for new generation or 'q' to quit.");
			
			for(int y = 0; y < grid.Height; y++)
			{
				for(int x = 0; x < grid.Width; x++)
				{
					if(grid.IsAlive(x, y))
						Console.Write("O");
					else
						Console.Write(".");
				}
				Console.Write("\n");
			}
		}
	}
}