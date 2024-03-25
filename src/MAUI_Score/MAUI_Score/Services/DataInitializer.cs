using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MAUI_Score.Datas;

namespace MAUI_Score.Services
{
    public class DataInitializer
    {
        public GameDataManager GameManager { get; private set; }
        public TeamDataManager TeamManager { get; private set; }
        public PlayerDataManager PlayerManager { get; private set; }
        public MatchDataManager MatchManager { get; private set; }

        public DataInitializer()
        {
            // Instanciation des classes DataManager
            GameManager = new GameDataManager();
            TeamManager = new TeamDataManager();
            PlayerManager = new PlayerDataManager();
            MatchManager = new MatchDataManager();
        }

        // Méthode d'initialisation des données
        public void InitializeData()
        {
            // Création des jeux
            GameManager.Add(new Models.Game(1, "League of Legends", Enum.GameType.Moba, "League of Legends est un jeu vidéo de type arène de bataille en ligne multijoueur développé et édité par Riot Games."));
            GameManager.Add(new Models.Game(2, "Counter-Strike: Global Offensive", Enum.GameType.FPS, "Counter-Strike: Global Offensive est un jeu de tir à la première personne multijoueur en ligne basé sur le jeu d'équipe développé par Valve Corporation."));
            GameManager.Add(new Models.Game(3, "Starcraft II", Enum.GameType.RTS, "StarCraft II est un jeu vidéo de stratégie en temps réel développé et édité par Blizzard Entertainment."));

            // Création des joueurs
            PlayerManager.Add(new Models.Player(1, "Søren Bjerg", "Bjergsen", TeamManager.GetById(1), 0.75f, 10));
            PlayerManager.Add(new Models.Player(2, "Martin Larsson", "Rekkles", TeamManager.GetById(2), 0.65f, 15));
            PlayerManager.Add(new Models.Player(3, "Lee Sang-hyeok", "Faker", TeamManager.GetById(3), 0.85f, 20));

            // Création des équipes
            TeamManager.Add(new Models.Team(1, "Team1", new List<Models.Player>(), new List<Models.Game>(), 0, 0));
            TeamManager.Add(new Models.Team(2, "Team2", new List<Models.Player>(), new List<Models.Game>(), 0, 0));
            TeamManager.Add(new Models.Team(3, "Team3", new List<Models.Player>(), new List<Models.Game>(), 0, 0));
            TeamManager.Add(new Models.Team(4, "Team4", new List<Models.Player>(), new List<Models.Game>(), 0, 0));

            // Création des matchs
            MatchManager.Add(new Models.Match(
                1,
                TeamManager.GetById(1),
                TeamManager.GetById(2),
                GameManager.GetById(1),
                DateTime.Now,
                TeamManager.GetById(1),
                10,
                5,
                "Statistics",
                null,
                null
            ));
            MatchManager.Add(new Models.Match(
                2,
                null,
                TeamManager.GetById(4),
                GameManager.GetById(2),
                DateTime.Now,
                TeamManager.GetById(3),
                10,
                5,
                "Statistics",
                PlayerManager.GetById(1),
                PlayerManager.GetById(2)
            ));
        }
    }
}
