using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUI_Score.Datas
{
    public class PlayerDataManager
    {
        private List<Models.Player> players { get; set; }

        public PlayerDataManager()
        {
            players.Add(new Models.Player(1, "John", "JohnDoe", null, 0.5f, 10));
            players.Add(new Models.Player(2, "Jane", "JaneDoe", null, 0.6f, 15));
            players.Add(new Models.Player(3, "Jack", "JackDoe", null, 0.7f, 20));
            players.Add(new Models.Player(4, "Jill", "JillDoe", null, 0.8f, 25));
        }

        public void addPlayer(Models.Player player)
        {
            players.Add(player);
        }

        public void removePlayer(Models.Player player)
        {
            players.Remove(player);
        }

        public void updatePlayer(Models.Player player)
        {
            Models.Player playerToUpdate = players.Find(p => p.id == player.id);
            playerToUpdate = player;
        }

        public Models.Player getPlayerById(int id)
        {
            return players.Find(p => p.id == id);
        }

        public List<Models.Player> getPlayers()
        {
            return players;
        }   
    }
}
