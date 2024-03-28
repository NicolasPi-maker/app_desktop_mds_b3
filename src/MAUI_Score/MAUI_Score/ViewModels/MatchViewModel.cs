using MAUI_Score.Models;
using MAUI_Score.Services.ModelServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using static NPOI.HSSF.Util.HSSFColor;

namespace MAUI_Score.ViewModels 
{
    public class MatchViewModel : INotifyPropertyChanged
    {
        private readonly PlayerService _playerService;
        private readonly TeamService _teamService;
        private readonly MatchService _matchService;
        private readonly GameService _gameService;

        

        public ICommand SubmitCommand { get; private set; }
        public ICommand SetSelectedPlayerCommand { get; private set; }

        public ICommand DeletePlayerCommand { get; private set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public MatchViewModel(PlayerService playerService, TeamService teamService, MatchService matchService, GameService gameService)
        {
            _playerService = playerService;
            _teamService = teamService;
            _matchService = matchService;
            _gameService = gameService;

            _gameService.AddGame(new Game(1, "League of Legends", Enum.GameType.Moba, "League of Legends est un jeu vidéo de type arène de bataille en ligne multijoueur développé et édité par Riot Games."));
            _gameService.AddGame(new Game(2, "Counter-Strike: Global Offensive", Enum.GameType.FPS, "Counter-Strike: Global Offensive est un jeu de tir à la première personne multijoueur en ligne basé sur le jeu d'équipe développé par Valve Corporation."));
            _gameService.AddGame(new Game(3, "Starcraft II", Enum.GameType.RTS, "StarCraft II est un jeu vidéo de stratégie en temps réel développé et édité par Blizzard Entertainment."));

            _teamService.AddTeam(new Team(1, "Team1", new List<Models.Player>(), new List<Game>(), 0, 0));
            _teamService.AddTeam(new Team(2, "Team2", new List<Models.Player>(), new List<Game>(), 0, 0));
            _teamService.AddTeam(new Team(3, "Team3", new List<Models.Player>(), new List<Game>(), 0, 0));
            _teamService.AddTeam(new Team(4, "Team4", new List<Models.Player>(), new List<Game>(), 0, 0));

            _playerService.AddPlayer(new Models.Player(1, "Søren Bjerg", "Bjergsen", null, 0.75f, 10));
            _playerService.AddPlayer(new Models.Player(2, "Martin Larsson", "Rekkles", null, 0.65f, 15));
            _playerService.AddPlayer(new Models.Player(3, "Lee Sang-hyeok", "Faker", null, 0.85f, 20));

            SubmitCommand = new Command(Submit);
            SetSelectedPlayerCommand = new Command<int>(SetSelectedMatch);
            DeletePlayerCommand = new Command<int>(DeletePlayer);
        }

        public List<Models.Player> PlayerList
        {
            get { return _playerService.GetAllPlayers().ToList(); }
        }

        public List<Team> TeamList
        {
            get { return _teamService.GetAllTeams().ToList(); }
        }

        public List<Game> GameList
        {
            get { return _gameService.GetAllGames().ToList(); }
        }

        public List<Models.Match> MatchList
        {
            get { return _matchService.GetAllMatches().ToList(); }
        }

        public void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public int NewMatchId = 0;

        public int setNewMatchId
        {
            get
            {
                return NewMatchId;
            }
            set
            {
                NewMatchId = value;
                OnPropertyChanged();
            }
        }

        public Team team1 = null;
        
        public Team setTeam1
        {
            get
            {
                return team1;
            }
            set
            {
                if(team2 != null && team1 != null && team1.id == team2.id)
                {
                    team1 = null;
                }
                else
                {
                    team1 = value;
                    OnPropertyChanged();
                }
                
            }
        }
        public Models.Player player1 = null;

        public Models.Player setPlayer1
        {
            get
            {
                return player1;
            }
            set
            {
                if (player2 != null && player1 != null && player1.id == player2.id)
                {
                    player1 = null;
                }
                else
                {
                    player1 = value;
                    OnPropertyChanged();
                }
            }
        }

        public Team team2 = null;

        public Team setTeam2
        {
            get
            {
                return team2;
            }
            set
            {
                if(team1 != null && team2 != null && team1.id == team2.id)
                {
                    team2 = null;
                }
                else
                {
                    team2 = value;
                    OnPropertyChanged();
                }
            }
        }
        public Models.Player player2 = null;

        public Models.Player setPlayer2
        {
            get
            {
                return player2;
            }
            set
            {
                if (player1 != null && player2 != null && player2.id == player1.id)
                {
                    player2 = null;
                }
                else
                {
                    player2 = value;
                    OnPropertyChanged();
                }
            }
        }
        public Game game;

        public Game setGame
        {
            get
            {
                return game;
            }
            set
            {
                game = value;
                OnPropertyChanged();
            }
        }

        public DateTime date;

        public DateTime setDate
        {
            get
            {
                return date;
            }
            set
            {
                date = value;
                OnPropertyChanged();
            }
        }
        public int team1Score;

        public int setTeam1Score
        {
            get
            {
                return team1Score;
            }
            set
            {
                team1Score = value;
                OnPropertyChanged();
            }
        }

        public int team2Score;

        public int setTeam2Score
        {
            get
            {
                return team2Score;
            }
            set
            {
                team2Score = value;
                OnPropertyChanged();
            }
        }
        public string statistics;

        public string setStatistics
        {
            get
            {
                return statistics;
            }
            set
            {
                statistics = value;
                OnPropertyChanged();
            }
        }

        public Team winner;

        public Team setWinner
        {
            get
            {
                return winner;
            }
            set
            {
                winner = value;
                OnPropertyChanged();
            }
        }

        private void SetSelectedMatch(int id)
        {
            Models.Match match = _matchService.GetMatchById(id);
            if (match != null)
            {
                NewMatchId = match.id;
                team1 = match.team1;
                player1 = match.player1;
                team2 = match.team2;
                player2 = match.player2;
                game = match.game;
                date = match.date;
                team1Score = match.team1Score;
                team2Score = match.team2Score;
                statistics = match.statistics;
                winner = match.winner;
            }
        }

        private void Submit()
        {
             AddMatch();
        }

        private void AddMatch()
        {
            _matchService.AddMatch(new Models.Match(NewMatchId, team1, team2, game, date, winner, team1Score, team2Score, statistics, player1, player2));
            RefreshMatchList();
            resetForm();
        }

        private void UpdateMatch()
        {
            _matchService.UpdateMatch(new Models.Match(NewMatchId, team1, team2, game, date, winner, team1Score, team2Score, statistics, player1, player2));
            RefreshMatchList();
            resetForm();
        }

        private void DeletePlayer(int id)
        {
            resetForm();
            Models.Player playerToRemove = _playerService.GetPlayerById(id);
            if (playerToRemove != null)
            {

                _playerService.DeletePlayer(id);
                RefreshMatchList();
            }
        }

        private void DeletePlayerWithoutId()
        {
            resetForm();
            Models.Player playerToRemove = _playerService.GetPlayerById(_playerService.GetAllPlayers().Count());
            if (playerToRemove != null)
            {
                _playerService.DeletePlayer(_playerService.GetAllPlayers().Count());
                RefreshMatchList();
            }
        }

        private void resetForm()
        {
            NewMatchId = 0;
            team1 = null;
            player1 = null;
            team2 = null;
            player2 = null;
            game = null;
            date = DateTime.Now;
            team1Score = 0;
            team2Score = 0;
            statistics = "";
            winner = null;
        }
        private void RefreshMatchList()
        {
            OnPropertyChanged("MatchList");
        }
    }
}
