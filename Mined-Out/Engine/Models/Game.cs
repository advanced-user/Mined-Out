namespace Engine.Models
{
    public class Game
    {
        public PlayingField PlayingField { get; set; }
        public bool IsLoosing { get; set; }
        public bool IsWinning { get; set; }
        public int Level { get; set; }
        public int NumberOfMoves { get; set; }
        public TimeCounter TimeCounter { get; set; }

        public Game()
        {
            Level = 1;
            LoadLevel();
        }

        public void LoadLevel()
		{
            IsLoosing = false;
            IsWinning = false;

            NumberOfMoves = 0;

            int numberOfBombs = 5 + Level*3;
            int width = 10 + Level*2;
            int height = 10 + Level * 2;
            int cellSize = 1;

            PlayingField = new PlayingField(numberOfBombs, width, height, cellSize);
        }

        public void PlayerMovement(string direction)
		{
            NumberOfMoves++;

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

        private void FootPrint(int i, int j)
        {
            PlayerFootprint playerFootprint = new PlayerFootprint(i, j);
            PlayingField.Cells[i, j].Value = playerFootprint;
        }

        private void Move(int i, int j)
		{
            if (i >= PlayingField.Cells.GetLength(0))
            {
                CountTheNumberOfBombs(i, j);
                return;
            }

            if (i < 0)
            {
                IsWinning = true;
                Level++;
                return;
            }

            if (PlayingField.Cells[i,j].Value == null || PlayingField.Cells[i,j].Value is PlayerFootprint)
			{
                PlayingField.Cells[i, j].Value = PlayingField.Player;
                PlayingField.Player.CellIndices = new CellIndices(i, j);

                CountTheNumberOfBombs(i, j);

                return;

			}

            GameOver();
        }

        private void GameOver()
		{
            IsLoosing = true;
		}

        private void CountTheNumberOfBombs(int i, int j)
		{
            PlayingField.Player.NumberOfBombs = 0;

            for(int k = i - 1; k <= i + 1; k++)
			{
                for(int g = j - 1; g <= j + 1; g++)
				{
                    if (g > 0 && g < PlayingField.Cells.GetLength(1) && k > 0 && k < PlayingField.Cells.GetLength(0))
					{
                        if (PlayingField.Cells[k, g].Value is Bomb)
                            PlayingField.Player.NumberOfBombs++;
					}
				}
			}
		}
    }
}