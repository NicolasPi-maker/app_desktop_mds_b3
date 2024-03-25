using Java.Util.Functions;
using MAUI_Score.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUI_Score.Datas
{
    public class TeamDataManager : Interfaces.DataManagerInterface<Team>
    {
        private List<Team> teams = new List<Team>();

        public TeamDataManager() 
        {}

        public List<Team> GetAll()
        {
            return teams;
        }

        public Team GetById(int id)
        {
            return teams.Find(x => x.id == id);
        }

        public void Add(Team team)
        {
            teams.Add(team);
        }

        public bool Update(Team team)
        {
            Team teamToUpdate = teams.Find(x => x.id == team.id);
            teamToUpdate = team;
            return true;
        }

        public bool Delete(int id)
        {
            teams.Remove(teams.Find(x => x.id == id));
            return true;
        }

        public void AddPlayerToTeam(int teamId, Models.Player player)
        {
            Team team = teams.Find(x => x.id == teamId);
            team.members.Add(player);
        }

        public void RemovePlayerFromTeam(int teamId, int playerId)
        {
            Team team = teams.Find(x => x.id == teamId);
            team.members.Remove(team.members.Find(x => x.id == playerId));
        }
    }
}
