using MAUI_Score.Interfaces;
using MAUI_Score.Models;

namespace MAUI_Score.Services.ModelServices
{
    public class TeamService
    {
        private readonly DataManagerInterface<Team> _TeamRepository;

        public TeamService(DataManagerInterface<Team> TeamRepository)
        {
            _TeamRepository = TeamRepository;
        }

        // Méthodes pour accéder aux opérations CRUD pour les équipes
        public void AddTeam(Team team)
        {
            _TeamRepository.Add(team);
        }

        public IEnumerable<Team> GetAllTeams()
        {
            return _TeamRepository.GetAll();
        }

        public Team GetTeamById(int id)
        {
            return _TeamRepository.GetById(id);
        }

        public void UpdateTeam(Team team)
        {
            _TeamRepository.Update(team);
        }

        public void DeleteTeam(int id)
        {
            _TeamRepository.Delete(id);
        }
    }
}
