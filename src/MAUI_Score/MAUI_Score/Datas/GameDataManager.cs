using MAUI_Score.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUI_Score.Datas
{
    public class GameDataManager
    {
       private List<Game> games = new List<Game>();

        public GameDataManager()
        {
            games.Add(new Game(1, "Counter Strike", Enum.GameType.FPS, "jeu de tir à la première personne (piou piou)"));
            games.Add(new Game(2, "League of Legends", Enum.GameType.Moba, "Jeu de stratégie en équipe"));
            games.Add(new Game(3, "Starcraft 2", Enum.GameType.RTS, "Jeu de stratégie solo"));
        }

        public List<Game> GetGames()
        {
            return games;
        }

        public Game GetGameById(int id)
        {
            return games.Find(x => x.id == id);
        }

        public void AddGame(Game game)
        {
            games.Add(game);
        }

        public void UpdateGame(Game game)
        {
            Game gameToUpdate = games.Find(x => x.id == game.id);
            gameToUpdate = game;
        }

        public void DeleteGame(int id)
        {
            games.Remove(games.Find(x => x.id == id));
        }
    }
}
