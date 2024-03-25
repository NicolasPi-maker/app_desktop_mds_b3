using MAUI_Score.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUI_Score.Services
{
    public class PlayerService
    {
        private readonly DataManagerInterface<Models.Player> _PlayerRepository;

        public PlayerService(DataManagerInterface<Models.Player> PlayerRepository)
        {
            _PlayerRepository = PlayerRepository;
        }
    }
}
