using MAUI_Score.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUI_Score.Datas
{
    public class TeamDataManager
    {
        private List<Team> teams = new List<Team>();

        public TeamDataManager() 
        {
            teams.Add(new Team(1, "Team1", new List<Models.Player>(), new List<Game>(), 0, 0));
            teams.Add(new Team(2, "Team2", new List<Models.Player>(), new List<Game>(), 0, 0));
            teams.Add(new Team(3, "Team3", new List<Models.Player>(), new List<Game>(), 0, 0));
            teams.Add(new Team(4, "Team4", new List<Models.Player>(), new List<Game>(), 0, 0));
        }

        public List<Team> GetTeams()
        {
            return teams;
        }

        public Team GetTeamById(int id)
        {
            return teams.Find(x => x.id == id);
        }

        public void AddTeam(Team team)
        {
            teams.Add(team);
        }

        public void UpdateTeam(Team team)
        {
            Team teamToUpdate = teams.Find(x => x.id == team.id);
            teamToUpdate = team;
        }

        public void DeleteTeam(int id)
        {
            teams.Remove(teams.Find(x => x.id == id));
        }
    }
}
