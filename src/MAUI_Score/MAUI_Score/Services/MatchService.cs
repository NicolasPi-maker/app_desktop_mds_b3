using MAUI_Score.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUI_Score.Services
{
    public class MatchService
    {
        private readonly DataManagerInterface<Models.Match> _MatchRepository;

        public MatchService(DataManagerInterface<Models.Match> gameRepository)
        {
            _MatchRepository = gameRepository;
        }
    }
}
