using MAUI_Score.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUI_Score.Datas
{
    public class GameDataManager : Interfaces.DataManagerInterface<Game>
    {
       private List<Game> games = new List<Game>();

        public GameDataManager()
        {}

        public List<Game> GetAll()
        {
            return games;
        }

        public Game GetById(int id)
        {
            return games.Find(x => x.id == id);
        }

        public void Add(Game game)
        {
            games.Add(game);
        }

        public bool Update(Game game)
        {
            Game gameToUpdate = games.Find(x => x.id == game.id);
            gameToUpdate = game;
            return true;
        }

        public bool Delete(int id)
        {
            games.Remove(games.Find(x => x.id == id));
            return true;
        }
    }
}
