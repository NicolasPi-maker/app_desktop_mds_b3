using MAUI_Score.Interfaces;
using System.Collections.Generic;

namespace MAUI_Score.Services.ModelServices
{
    public class PlayerService
    {
        private readonly DataManagerInterface<Models.Player> _PlayerRepository;

        public PlayerService(DataManagerInterface<Models.Player> PlayerRepository)
        {
            _PlayerRepository = PlayerRepository;
        }

        // Méthodes pour accéder aux opérations CRUD pour les joueurs
        public void AddPlayer(Models.Player player)
        {
            _PlayerRepository.Add(player);
        }

        public IEnumerable<Models.Player> GetAllPlayers()
        {
            return _PlayerRepository.GetAll();
        }

        public Models.Player GetPlayerById(int id)
        {
            return _PlayerRepository.GetById(id);
        }

        public bool UpdatePlayer(Models.Player player)
        {
            return _PlayerRepository.Update(player);
        }

        public bool DeletePlayer(int id)
        {
            return _PlayerRepository.Delete(id);
        }
    }


}

