using System;

namespace GameOfLife
{
	class Cell
	{
		public Cell(int x, int y)
		{
			X = x;
			Y = y;
		}
		
		public int X { get; set; }
		public int Y { get; set; }
		
		public override bool Equals(object obj)
		{
			if(obj == null)
				return false;
			Cell b = obj as Cell;
			if(b == null)
				return false;
			if(X == b.X && Y == b.Y)
				return true;
			return false;
		}

		public override int GetHashCode()
		{
			return Tuple.Create(X, Y).GetHashCode();
		}
	}
}