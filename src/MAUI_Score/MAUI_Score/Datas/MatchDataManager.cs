using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUI_Score.Datas
{
    public class MatchDataManager
    {
        private List<Models.Match> matches { get; set; }

        public MatchDataManager() 
        {
            matches.Add(new Models.Match(
                    1, 
                    new Models.Team(1, "Team1", new List<Models.Player>(), new List<Models.Game>(), 0, 0), 
                    new Models.Team(2, "Team2", new List<Models.Player>(), new List<Models.Game>(), 0, 0), 
                    new Models.Game(1, "Game1", Enum.GameType.FPS, "Description"), 
                    DateTime.Now, 
                    new Models.Team(1, "Team1", new List<Models.Player>(), new List<Models.Game>(), 0, 0),
                    10, 
                    5, 
                    "Statistics",
                    new Models.Player(1, "Player1", "Pseudo1", new Models.Team(1, "Team1", new List<Models.Player>(), new List<Models.Game>(), 0, 0), 0, 0), 
                    new Models.Player(2, "Player2", "Pseudo2", new Models.Team(2, "Team2", new List<Models.Player>(), new List<Models.Game>(), 0, 0), 0, 0)
                ));
        }

        public List<Models.Match> GetMatches()
        {
            return matches;
        }

        public Models.Match GetMatchById(int id)
        {
            return matches.Find(x => x.id == id);
        }

        public void AddMatch(Models.Match match)
        {
            matches.Add(match);
        }

        public void UpdateMatch(Models.Match match)
        {
            Models.Match matchToUpdate = matches.Find(x => x.id == match.id);
            matchToUpdate = match;
        }

        public void DeleteMatch(int id)
        {
            matches.Remove(matches.Find(x => x.id == id));
        }
    }
}
