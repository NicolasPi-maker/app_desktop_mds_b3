using MAUI_Score.Interfaces;
using MAUI_Score.Models;

namespace MAUI_Score.Services
{
    public class GameService
    {
        private readonly DataManagerInterface<Game> _GameRepository;

        public GameService(DataManagerInterface<Game> gameRepository)
        {
            _GameRepository = gameRepository;
        }

        // Méthodes pour accéder aux opérations CRUD pour les jeux
        public void AddGame(Game game)
        {
            _GameRepository.Add(game);
        }

        public IEnumerable<Game> GetAllGames()
        {
            return _GameRepository.GetAll();
        }

        public Game GetGameById(int id)
        {
            return _GameRepository.GetById(id);
        }

        public bool UpdateGame(Game game)
        {
            return _GameRepository.Update(game);
        }

        public bool DeleteGame(int id)
        {
            return _GameRepository.Delete(id);
        }
    }
}
