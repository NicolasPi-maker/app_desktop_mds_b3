using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUI_Score.Datas
{
    public class PlayerDataManager : Interfaces.DataManagerInterface<Models.Player>
    {
        private List<Models.Player> players { get; set; }

        public PlayerDataManager()
        {}

        public void Add(Models.Player player)
        {
            players.Add(player);
        }

        public bool Delete(int id)
        {
            players.Remove(players.Find(p => p.id == id));
            return true;
        }

        public bool Update(Models.Player player)
        {
            Models.Player playerToUpdate = players.Find(p => p.id == player.id);
            playerToUpdate = player;
            return true;
        }

        public Models.Player GetById(int id)
        {
            return players.Find(p => p.id == id);
        }

        public List<Models.Player> GetAll()
        {
            return players;
        }   
    }
}
