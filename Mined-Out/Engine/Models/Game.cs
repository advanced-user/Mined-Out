namespace Engine.Models
{
    public class Game
    {
        public PlayingField PlayingField { get; set; }

        public Game()
        {
            int numberOfBombs = 10;
            int width = 10;
            int height = 10;
            int cellSize = 1;

            PlayingField = new PlayingField(numberOfBombs, width, height, cellSize);
        }
    }
}