using MAUI_Score.Interfaces;

namespace MAUI_Score.Services
{
    public class MatchService
    {
        private readonly DataManagerInterface<Models.Match> _MatchRepository;

        public MatchService(DataManagerInterface<Models.Match> gameRepository)
        {
            _MatchRepository = gameRepository;
        }

        // Méthodes pour accéder aux opérations CRUD pour les matchs
        public void AddMatch(Models.Match match)
        {
            _MatchRepository.Add(match);
        }

        public IEnumerable<Models.Match> GetAllMatches()
        {
            return _MatchRepository.GetAll();
        }

        public Models.Match GetMatchById(int id)
        {
            return _MatchRepository.GetById(id);
        }

        public bool UpdateMatch(Models.Match match)
        {
            return _MatchRepository.Update(match);
        }

        public bool DeleteMatch(int id)
        {
            return _MatchRepository.Delete(id);
        }
    }
}
