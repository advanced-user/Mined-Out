namespace Engine.Models
{
    public class Game
    {
        public PlayingField PlayingField { get; set; }

        public Game()
        {
            int numberOfBombs = 5;
            int width = 10;
            int height = 10;
            int cellSize = 1;

            PlayingField = new PlayingField(numberOfBombs, width, height, cellSize);
        }
        
        public void PlayerMovement(string direction)
		{
            int i = PlayingField.Player.CellIndices.I;
            int j = PlayingField.Player.CellIndices.J;
            FootPrint(i, j);

            switch (direction)
            {
                case "up":
                    Move(i - 1, j);
                    break;
                case "down":
                    Move(i + 1, j);
                    break;
                case "left":
                    Move(i, j - 1);
                    break;
                case "right":
                    Move(i, j + 1);
                    break;
            }
        }

        private void Move(int i, int j)
		{
            PlayingField.Cells[i, j].Value = PlayingField.Player;
            PlayingField.Player.CellIndices = new CellIndices(i, j);
        }

        private void FootPrint(int i, int j)
		{
            PlayerFootprint playerFootprint = new PlayerFootprint(i, j);
            PlayingField.Cells[i, j].Value = playerFootprint;
        }
    }
}