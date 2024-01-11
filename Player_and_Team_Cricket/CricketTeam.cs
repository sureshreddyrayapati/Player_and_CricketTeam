using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player_and_Team_Cricket
{
    public class CricketTeam : Team
    {
        private List<Player> players;

        public CricketTeam()
        {
            players = new List<Player>();
        }

        public void AddPlayer(Player player)
        {
            if (players.Count < 11)
            {
                players.Add(player);
                Console.WriteLine($"Player {player.Name} is added succesfully to the team.");
            }
            else
            {
                Console.WriteLine("The team cannot have more than 11 players.");
            }
        }

        public void RemovePlayer(int playerId)
        {
            Player playerToRemove = players.FirstOrDefault(p => p.Id == playerId);
            if (playerToRemove != null)
            {
                players.Remove(playerToRemove);
                Console.WriteLine($"Player {playerToRemove.Name} is removed successfully from the team.");
            }
            else
            {
                Console.WriteLine($"Player wtith Id {playerId} not found in the team.");
            }
        }

        public Player GetPlayerById(int playerId)
        {
            return players.FirstOrDefault(p => p.Id == playerId);
        }

        public List<Player> GetPlayersByName(string playerName)
        {
            return players.Where(p => p.Name.Equals(playerName, StringComparison.OrdinalIgnoreCase)).ToList();
        }
        public List<Player> GetAllPlayers()
        {
            return players.ToList();
        }
    }
}