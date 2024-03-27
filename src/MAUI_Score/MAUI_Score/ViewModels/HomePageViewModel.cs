using MAUI_Score.Models;
using MAUI_Score.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUI_Score.ViewModels
{
    public class HomePageViewModel
    {
        private readonly GameService _gameService;

        public HomePageViewModel(GameService gameService)
        {
            _gameService = gameService;
            _gameService.AddGame(new Game(1, "League of Legends", Enum.GameType.Moba, "League of Legends est un jeu vidéo de type arène de bataille en ligne multijoueur développé et édité par Riot Games."));
            _gameService.AddGame(new Game(2, "Counter-Strike: Global Offensive", Enum.GameType.FPS, "Counter-Strike: Global Offensive est un jeu de tir à la première personne multijoueur en ligne basé sur le jeu d'équipe développé par Valve Corporation."));
            _gameService.AddGame(new Game(3, "Starcraft II", Enum.GameType.RTS, "StarCraft II est un jeu vidéo de stratégie en temps réel développé et édité par Blizzard Entertainment."));
            _gameService.DeleteGame(1);
            _gameService.UpdateGame(new Game(2, "Counter-Stroke: Global Deffensive", Enum.GameType.RTS, "Pas de description"));
        }
    }
}
