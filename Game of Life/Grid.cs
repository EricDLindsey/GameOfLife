using System.Collections.Generic;
using System.Linq;

namespace GameOfLife
{
	class Grid
	{
		public Grid(int x, int y)
		{
			width = x;
			height = y;
			grid = new HashSet<Cell>();
		}
		
		int width;
		int height;
		HashSet<Cell> grid;

		public int Width { get { return width; } }
		public int Height { get { return height; } }
		
		public bool this[int x, int y]
		{
			set
			{
				if(isCell(x, y))
				{
					if(value == false)
						removeCell(x, y);
				}
				else
				{
					if(value == true)
						grid.Add(new Cell(x, y));
				}
			}
		}
		
		public bool IsAlive(Cell c)
		{
			return grid.Contains(c);
		}
		
		public bool IsAlive(int x, int y)
		{
			if(isCell(x, y))
				return true;
			else
				return false;
		}
		
		public List<Cell> GetCells()
		{
			HashSet<Cell> cl = new HashSet<Cell>();
			
			foreach(Cell c in grid)
			{
				cl.Add(c);
				
				for(int x = -1; x <= 1; x++)
					for(int y = -1; y <= 1; y++)
						if(c.X+x >= 0 && c.X+x < width && c.Y+y >= 0 && c.Y+y < height)
							if(c.Equals(new Cell(c.X + x, c.Y + y)) == false)
								cl.Add(new Cell(c.X + x, c.Y + y));
			}
			
			return cl.ToList();
		}
		
		public int GetNeighbors(Cell c)
		{
			int nl = 0;

			for(int x = -1; x <= 1; x++)
				for(int y = -1; y <= 1; y++)
					if(c.Equals(new Cell(c.X+x, c.Y+y)) == false)
						if(isCell(c.X + x, c.Y + y))
							nl++;
			
			return nl;
		}
		
		public void Change(List<Cell> cl)
		{
			foreach(Cell c in cl)
			{
				if(grid.Contains(c))
					grid.Remove(c);
				else
					grid.Add(c);
			}
		}
		
		bool isCell(int x, int y)
		{
			return grid.Contains(new Cell(x, y));
		}
		
		void removeCell(int x, int y)
		{
			grid.Remove(new Cell(x, y));
		}
	}
}