using MAUI_Score.Models;
using MAUI_Score.Services.ModelServices;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace MAUI_Score.ViewModels
{
    public class PlayerTeamViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private readonly PlayerService _playerService;
        private readonly TeamService _teamService;
        public ICommand SubmitCommand { get; private set; }
        public ICommand SetSelectedPlayerCommand { get; private set; }

        public ICommand DeletePlayerCommand { get; private set; }

        public PlayerTeamViewModel(PlayerService playerService, TeamService teamService)
        {
            _playerService = playerService;
            _teamService = teamService;

            SubmitCommand = new Command(Submit);
            SetSelectedPlayerCommand = new Command<int>(SetSelectedPlayer);
            DeletePlayerCommand = new Command<int>(DeletePlayer);

            Team team = new Team(1, "Team1", new List<Models.Player>(), new List<Game>(), 0, 0);
            _teamService.AddTeam(team);
            _playerService.AddPlayer(new Models.Player(1, "Søren Bjerg", "Bjergsen", team, 0.75f, 10));
            _playerService.AddPlayer(new Models.Player(2, "Martin Larsson", "Rekkles", team, 0.65f, 15));
            _playerService.AddPlayer(new Models.Player(3, "Lee Sang-hyeok", "Faker", team, 0.85f, 20));
        }

        public void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public List<Models.Player> PlayerList
        {
            get { return _playerService.GetAllPlayers().ToList(); }
        }

        public int NewPlayerId = 0;

        public int SetNewPlayerId
        {
            get { return NewPlayerId; }
            set
            {
                NewPlayerId = value;
                OnPropertyChanged();
            }
        }

        public string NewPlayerName;
        public string SetNewPayerName
        {
            get { return NewPlayerName; }
            set 
            { 
                NewPlayerName = value;
                OnPropertyChanged();
            }
        }

        public string NewPlayerPseudo;
        public string SetNewPlayerPseudo
        {
            get { return NewPlayerPseudo; }
            set
            {
                NewPlayerPseudo = value;
                OnPropertyChanged();
            }
        }

        public List<Team> TeamList
        {
            get { return _teamService.GetAllTeams().ToList(); }
        }

        public Team NewTeam;

        public Team SelectedTeam {
            get { return NewTeam;} 
            set
            {
                NewTeam = value;
                OnPropertyChanged();
            }
        }

        public int NewNbGamesPlayed;

        public int SetNewNbGamesPlayed
        {
            get { return NewNbGamesPlayed; }
            set
            {
                NewNbGamesPlayed = value;
                OnPropertyChanged();
            }
        }

        public float NewWinrate;

        public float SetNewWinrate
        {
            get { return NewWinrate; }
            set
            {
                NewWinrate = value;
                OnPropertyChanged();
            }
        }

        private void SetSelectedPlayer(int id)
        {
            Models.Player player = _playerService.GetPlayerById(id);
            if (player != null)
            {
                SetNewPlayerId = player.id;
                SetNewPayerName = player.name;
                SetNewPlayerPseudo = player.pseudo;
                SelectedTeam = player.team;
                SetNewNbGamesPlayed = player.nbGamesPlayed;
                SetNewWinrate = player.winrate;
            }
        }

        private void Submit()
        {
            if(SetNewPlayerId == 0)
            {
                AddPlayer();
            }
            else
            {
                UpdatePlayer();
            }
        }

        private void AddPlayer()
        {
            _playerService.AddPlayer(new Models.Player(_playerService.GetAllPlayers().Count() + 1, NewPlayerName, NewPlayerPseudo, NewTeam, NewWinrate, NewNbGamesPlayed));
            RefreshPlayerList();
            resetForm();
        }

        private void UpdatePlayer()
        {
            _playerService.UpdatePlayer(new Models.Player(NewPlayerId, NewPlayerName, NewPlayerPseudo, NewTeam, NewWinrate, NewNbGamesPlayed));
            RefreshPlayerList();
            resetForm();
        }

        private void DeletePlayer(int id)
        {
            resetForm();
            Models.Player playerToRemove = _playerService.GetPlayerById(id);
            if (playerToRemove != null)
            {
                
                _playerService.DeletePlayer(id);
                RefreshPlayerList();
            }
        }

        private void DeletePlayerWithoutId()
        {
            resetForm();
            Models.Player playerToRemove = _playerService.GetPlayerById(_playerService.GetAllPlayers().Count());
            if (playerToRemove != null)
            {
                _playerService.DeletePlayer(_playerService.GetAllPlayers().Count());
                RefreshPlayerList();
            }
        }

        private void resetForm()
        {
            SetNewPayerName = "";
            SetNewPlayerPseudo = "";
            SetNewNbGamesPlayed = 0;
            SetNewWinrate = 0;
        }

        private void RefreshPlayerList()
        {
            OnPropertyChanged("PlayerList");
        }
    }
}
