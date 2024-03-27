using MAUI_Score.Interfaces;
using MAUI_Score.Models;
using MAUI_Score.Services.ModelServices;

namespace MAUI_Score.Services.DataServices
{
    public class DataInitializer
    {
        private readonly GameService _gameService;
        private readonly TeamService _teamService;
        private readonly PlayerService _playerService;
        private readonly MatchService _matchService;
        public DataInitializer(GameService gameService, TeamService teamService, PlayerService playerService, MatchService matchService)
        {
            _gameService = gameService;
            _teamService = teamService;
            _playerService = playerService;
            _matchService = matchService;
        }

        // Méthode d'initialisation des données
        public void InitGameDatas()
        {
            _gameService.AddGame(new Game(1, "League of Legends", Enum.GameType.Moba, "League of Legends est un jeu vidéo de type arène de bataille en ligne multijoueur développé et édité par Riot Games."));
            _gameService.AddGame(new Game(2, "Counter-Strike: Global Offensive", Enum.GameType.FPS, "Counter-Strike: Global Offensive est un jeu de tir à la première personne multijoueur en ligne basé sur le jeu d'équipe développé par Valve Corporation."));
            _gameService.AddGame(new Game(3, "Starcraft II", Enum.GameType.RTS, "StarCraft II est un jeu vidéo de stratégie en temps réel développé et édité par Blizzard Entertainment."));
        }

        public void InitPlayerDatas()
        {
            _playerService.AddPlayer(new Models.Player(1, "Søren Bjerg", "Bjergsen", _teamService.GetTeamById(1), 0.75f, 10));
            _playerService.AddPlayer(new Models.Player(2, "Martin Larsson", "Rekkles", _teamService.GetTeamById(2), 0.65f, 15));
            _playerService.AddPlayer(new Models.Player(3, "Lee Sang-hyeok", "Faker", _teamService.GetTeamById(3), 0.85f, 20));
        }

        public void InitTeamDatas()
        {
            _teamService.AddTeam(new Team(1, "Team1", new List<Models.Player>(), new List<Game>(), 0, 0));
            _teamService.AddTeam(new Team(2, "Team2", new List<Models.Player>(), new List<Game>(), 0, 0));
            _teamService.AddTeam(new Team(3, "Team3", new List<Models.Player>(), new List<Game>(), 0, 0));
            _teamService.AddTeam(new Team(4, "Team4", new List<Models.Player>(), new List<Game>(), 0, 0));
        }

        public void InitMatchDatas()
        {
            _matchService.AddMatch(new Models.Match(1, _teamService.GetTeamById(1), _teamService.GetTeamById(2), _gameService.GetGameById(1), new DateTime(2022, 10, 11), _teamService.GetTeamById(1), 10, 5, "test", null, null));
            _matchService.AddMatch(new Models.Match(2, _teamService.GetTeamById(3), _teamService.GetTeamById(4), _gameService.GetGameById(2), new DateTime(2022, 10, 12), _teamService.GetTeamById(3), 10, 5, "test", null, null));
            _matchService.AddMatch(new Models.Match(3, _teamService.GetTeamById(1), _teamService.GetTeamById(3), _gameService.GetGameById(3), new DateTime(2022, 10, 13), _teamService.GetTeamById(1), 10, 5, "test", null, null));
        }

    }
}
