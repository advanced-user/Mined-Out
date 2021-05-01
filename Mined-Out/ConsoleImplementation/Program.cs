using Engine.Models;

namespace Mined_Out
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            PlayerController playerController = new PlayerController(game);

            //Field field = new Field(game);
            //field.DrawField("b");

            playerController.HandlingKeystrokes();
        }
    }
}