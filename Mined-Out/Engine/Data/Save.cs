using Engine.Models;
using System.Collections.Generic;

namespace Engine.Data
{
	public class Save
	{
		public int Id { get; set; }
		public int Time { get; set; }
		public int NumberOfMoves { get; set; }
		public int Level { get; set; }
		public int FieldCellSize { get; set; }
		public double Scores { get; set; }
		public int FieldHeight { get; set; }
		public int FieldWidth { get; set; }
		public List<Player> Players { get; set; }
		public List<PlayerFootprint> PlayerFootprints { get; set; }
		public List<Barrier> Barriers { get; set; }
		public List<Bomb> Bombs { get; set; }
	}
}
