using Imi.Project.Pin.Concept.Quiz.Interfaces;

namespace Imi.Project.Pin.Concept.Quiz.Infrastructure.Services
{
    public class PlayerTrackingService : IPlayerTrackingService
    {
        private readonly Dictionary<string, string> playerWindows = new Dictionary<string, string>(); // Maps windowId to player name

        public void AddPlayer(string windowId, string playerName)
        {
            if (!string.IsNullOrEmpty(playerName))
            {
                playerWindows[windowId] = playerName;
            }
        }

        public void RemovePlayer(string windowId)
        {
            if (playerWindows.ContainsKey(windowId))
            {
                playerWindows.Remove(windowId);
            }
        }

        public string GetPlayerName(string windowId)
        {
            if (playerWindows.TryGetValue(windowId, out var playerName))
            {
                return playerName;
            }

            return string.Empty; // Player name not found
        }

        public int GetPlayerIndexFromWindowId(string windowId)
        {
            var playerName = GetPlayerName(windowId);
            if (!string.IsNullOrEmpty(playerName))
            {
                // Logic to find the player index based on the playerName
                // For example, if you are using a list of players, you can iterate over the list and find the index based on the matching playerName.
                // Return -1 if not found.
                // Adjust this logic according to your specific implementation.
            }

            return -1; // Player not found
        }
    }
}
