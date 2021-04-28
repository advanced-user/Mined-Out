using Engine.Data;

namespace Engine.Models
{
	public abstract class PreservedCell
	{
		public int Id { get; set; }
		public int I { get; set; }
		public int J { get; set; }
		public Save Save { get; set; }
	}
}
