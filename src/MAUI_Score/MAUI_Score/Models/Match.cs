using AudioUnit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUI_Score.Models
{
    public class Match
    {
        public int id { get; set; }
        public Team team1 { get; set; }
        public Player player1 { get; set; }
        public Team team2 { get; set; }
        public Player player2 { get; set; }
        public Game game { get; set; }
        public DateTime date { get; set; }
        public int team1Score { get; set; }
        public int team2Score { get; set; }
        public string statistics { get; set; }
        public Team winner { get; set; }

        public Match(int id, Team team1, Team team2, Game game, DateTime date, Team winner, int team1Score, int team2Score, string statistics, Player player1, Player player2)
        {
            this.id = id;
            this.team1 = team1;
            this.team2 = team2;
            this.game = game;
            this.date = date;
            this.team1Score = team1Score;
            this.team2Score = team2Score;
            this.statistics = statistics;
            this.winner = winner;
            this.player1 = player1;
            this.player2 = player2;
        }

        public Match createMatch(int id, Team team1, Team team2, Game game, DateTime date, Team winner, int team1Score, int team2Score, string statistics, Player player1, Player player2)
        {
            return new Match(id, team1, team2, game, date, winner, team1Score, team2Score, statistics, player1, player2);
        }
    }
}
