namespace Engine.Models
{
    public class PlayingField
    {
        public Player Player { get; set; }
        public Bomb[] Bombs { get; set; }
        public FieldSize FieldSize { get; set; }

        public PlayingField(int numberOfBombs, double width, double height)
        {
            FieldSize = new FieldSize(width, height);

            FieldGeneration(numberOfBombs);
        }

        private void FieldGeneration(int numberOfBombs)
        {
            
        }
    }
}