using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUI_Score.Models
{
    public class Team
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<Player> members { get; set; }
        public List<Game> games { get; set; }
        public float winrate { get; set; }
        public int nbGamesPlayed { get; set; }

        public Team(int id, string name, List<Player> members, List<Game> games, float winrate, int nbGamesPlayed)
        {
            this.id = id;
            this.name = name;
            this.members = members;
            this.games = games;
            this.winrate = winrate;
            this.nbGamesPlayed = nbGamesPlayed;
        }
        public Team createTeam(int id, string name, List<Player> members, List<Game> games, float winrate, int nbGamesPlayed)
        {
            return new Team(id, name, members, games, winrate, nbGamesPlayed);
        }

    }
}
