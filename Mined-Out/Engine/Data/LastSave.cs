using System.Collections.Generic;

namespace Engine.Data
{
	public class Save
	{
		public int Time { get; set; }
		public int NumberOfMoves { get; set; }
		public int Level { get; set; }
		public Player Player { get; set; }
		public List<PlayerFootprint> PlayerFootprint { get; set; }
		public List<Barrier> Barriers { get; set; }
		public List<Bomb> Bombs { get; set; }
	}

	public abstract class Cell
	{
		public int I { get; set; }
		public int J { get; set; }
		public Save LastSave { get; set; }
	}

	public class Player : Cell
	{
		public int NumberOfBombs { get; set; }
	}

	public class PlayerFootprint : Cell
	{
	}

	public class Barrier : Cell
	{
	}

	public class Bomb : Cell
	{
	}

}
