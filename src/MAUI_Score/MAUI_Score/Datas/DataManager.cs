using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUI_Score.Datas
{
    public class DataManager
    {
        public GameDataManager GameManager { get; private set; }
        public TeamDataManager TeamManager { get; private set; }
        public PlayerDataManager PlayerManager { get; private set; }
        public MatchDataManager MatchManager { get; private set; }

        public DataManager()
        {
            // Instanciation des classes DataManager
            GameManager = new GameDataManager();
            TeamManager = new TeamDataManager();
            PlayerManager = new PlayerDataManager();
            MatchManager = new MatchDataManager();
        }
    }
}
