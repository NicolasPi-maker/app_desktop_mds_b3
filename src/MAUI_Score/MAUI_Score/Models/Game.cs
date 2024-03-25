using MAUI_Score.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUI_Score.Models
{
    public class Game
    {
        public int id { get; set; }
        public string name { get; set; }
        public GameType type { get; set; }
        public string description { get; set; }
        

        public Game(int id, string name, GameType type, string description)
        {
            this.id = id;
            this.name = name;
            this.type = type;
            this.description = description;
        }

        public Game createGame(int id, string name, string type, string description)
        {
            return new Game(id, name, type, description);
        }
    }
}
