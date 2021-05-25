using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
	public class Save
	{
		public int Id { get; set; }
		public int Level { get; set; }
		public double Score { get; set; }

		public Save(int id, int level, double score)
		{
			Id = id;
			Level = level;
			Score = score;
		}
	}
}
