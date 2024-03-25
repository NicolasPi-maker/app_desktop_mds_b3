using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUI_Score.Models
{
    public class Player
    {
        public int id { get; set; }
        public string name { get; set; }
        private string pseudo { get; set; }
        public Team team { get; set; }
        public float winrate { get; set; }
        public int nbGamesPlayed { get; set; }

        public Player(int id, string name, string pseudo, Team team, float winrate, int nbGamesPlayed)
        {
            this.id = id;
            this.name = name;
            this.pseudo = pseudo;
            this.team = team;
            this.winrate = winrate;
            this.nbGamesPlayed = nbGamesPlayed;
        }

        public Player createPlayer(int id, string name, string pseudo, Team team, float winrate, int nbGamesPlayed)
        {
            return new Player(id, name, pseudo, team, winrate, nbGamesPlayed);
        }
    }
}
