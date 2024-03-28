using MAUI_Score.Interfaces;
using MAUI_Score.Models;
using MAUI_Score.Services.ModelServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUI_Score.ViewModels
{
    public class PlayerTeamViewModel
    {
        private readonly PlayerService _playerService;
        public PlayerTeamViewModel(PlayerService playerService)
        {
            _playerService = playerService;
            Models.Team team = new Models.Team(1, "Team1", new List<Models.Player>(), new List<Game>(), 0, 0);
            _playerService.AddPlayer(new Models.Player(1, "Søren Bjerg", "Bjergsen", team, 0.75f, 10));
            _playerService.AddPlayer(new Models.Player(2, "Martin Larsson", "Rekkles", team, 0.65f, 15));
            _playerService.AddPlayer(new Models.Player(3, "Lee Sang-hyeok", "Faker", team, 0.85f, 20));
        }

        public List<Models.Player> PlayerList
        {
            get { return _playerService.GetAllPlayers().ToList(); }
        }
    }
}
