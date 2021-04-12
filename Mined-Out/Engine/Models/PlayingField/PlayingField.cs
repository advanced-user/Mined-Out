namespace Engine.Models
{
    public class PlayingField
    {
        public Player Player { get; set; }
        public Bomb[] Bombs { get; set; }
        public Barrier[] Barriers { get; set; }
        public FieldSize FieldSize { get; set; }

        public PlayingField(Player player,int numberOfBombs, int width, int height)
        {
            FieldSize = new FieldSize(width, height);
            Player = player;
            Bombs = new Bomb[numberOfBombs];
            Barriers = new Barrier[CountTheNumberOfBarriers()];
            
            FieldGeneration(numberOfBombs);
        }

        private int CountTheNumberOfBarriers()
        {
            return 2 * FieldSize.Height + 2 * FieldSize.Width - 10;
        }
        
        private void FieldGeneration(int numberOfBombs)
        {
            GenerationOfBarriers();
        }

        private void GenerationOfBarriers()
        {
            int coordinateX = FieldSize.Width / 2;

            for (int i = 0; i < FieldSize.Width; i++)
            {
                if (i != coordinateX - 1 && i != coordinateX && i != coordinateX + 1)
                {
                    Barrier barrier = new Barrier(i, 0);
                    
                }
            }

            for (int i = 1; i < FieldSize.Height - 1; i++)
            {
                
            }
        }
    }
}