namespace Engine.Models
{
    public class Player : PreservedCell
    {
        public int NumberOfBombs { get; set; }

        public Player(int i, int j)
        {
            I = i;
            J = j;
        }
    }
}