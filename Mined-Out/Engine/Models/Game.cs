using Engine.Data;
using System.Collections.Generic;
using System.Linq;

namespace Engine.Models
{
    public class Game
    {
        public PlayingField PlayingField { get; set; }
        public bool IsLoosing { get; set; }
        public bool IsWinning { get; set; }
        public bool IsSaved { get; set; }
        public int Level { get; set; }
        public int NumberOfMoves { get; set; }
        public int Score { get; set; } = 0;
        public TimeCounter TimeCounter { get; set; }

        public Game()
        {
            Level = 1;
            Score = 0;
            LoadLevel();
        }

        public void LoadLevel()
		{
            if(IsLoosing)
			{
                Score = 0;
                Level = 1;
			}

            IsWinning = false;
            IsLoosing = false;

            NumberOfMoves = 0;

            int numberOfBombs = 3 + Level*30;
            int width = 10 + Level*2;
            int height = 10 + Level * 2;
            int cellSize = 1;

            PlayingField = new PlayingField(numberOfBombs, width, height, cellSize);
        }

        public void PlayerMovement(string direction)
		{
            NumberOfMoves++;

            int i = PlayingField.Player.I;
            int j = PlayingField.Player.J;
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
                PlayingField.Player.I = i;
                PlayingField.Player.J = j;

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

        public void SaveTheGame()
		{
            var bombs = new List<Bomb>();
            var playerFootprints = new List<PlayerFootprint>();
            var barriers = new List<Barrier>();

            int width = PlayingField.FieldSize.Width / PlayingField.CellSize;
            int height = PlayingField.FieldSize.Height / PlayingField.CellSize;

            for (int i = 0; i < height; i++)
			{
                for(int j = 0; j < width; j++)
				{
                    if(PlayingField.Cells[i, j].Value != null)
					{
                        if(PlayingField.Cells[i, j].Value is Barrier)
						{
                            Barrier barrier = new Barrier(i , j);
                            barriers.Add(barrier);
						}
                        else if(PlayingField.Cells[i, j].Value is PlayerFootprint)
						{
                            PlayerFootprint playerFootprint = new PlayerFootprint(i, j);
                            playerFootprints.Add(playerFootprint);
                        }
                        else if(PlayingField.Cells[i, j]. Value is Bomb)
						{
                            Bomb bomb = new Bomb(i, j);
                            bombs.Add(bomb);
                        }
					}
				}
			}

            Save save = new Save();
            save.Time = TimeCounter.AmountOfTime;
            save.NumberOfMoves = NumberOfMoves;
            save.Level = Level;
            save.FieldCellSize = PlayingField.CellSize;
            save.Scores = Score;
            save.FieldHeight = PlayingField.FieldSize.Height;
            save.FieldWidth = PlayingField.FieldSize.Width;
            save.Players = new List<Player> { PlayingField.Player };
            save.Barriers = barriers;
            save.Bombs = bombs;
            save.PlayerFootprints = playerFootprints;

            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                db.Saves.Add(save);
                db.SaveChanges();
            }

            IsSaved = true;
        }

        public void CalculatePlayerPoints()
		{
            Score += Level * ((100/TimeCounter.AmountOfTime) + (PlayingField.Cells.GetLength(0) / NumberOfMoves));

            UpdateBestScore();
		}

        private void UpdateBestScore()
        {
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                var bestScore = db.BestScore.ToList()[0];
                if(bestScore.Score < Score)
                {
                    var newBestScore = new BestScore();
                    newBestScore.Score = Score;

                    db.BestScore.Remove(bestScore);
                    db.BestScore.Add(newBestScore);

                    db.SaveChanges();
				}
            }
        }
    }
}