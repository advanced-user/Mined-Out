using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Math
{
	public class Node
	{
		public bool IsMarked {get;set;}
		public bool IsEmpty { get; set; }
		public bool IsFinish { get; set; }
		public int I { get; set; }
		public int J { get; set; }
	}
}
