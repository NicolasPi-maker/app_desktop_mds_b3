using MAUI_Score.Interfaces;
using MAUI_Score.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUI_Score.Services
{
    public class GameService
    {
        private readonly DataManagerInterface<Game> _GameRepository;

        public GameService(DataManagerInterface<Game> gameRepository)
        {
            _GameRepository = gameRepository;
        }
    }
}
