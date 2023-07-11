using Imi.Project.Pin.Concept.Quiz.Infrastructure.Services;
using Imi.Project.Pin.Concept.Quiz.Interfaces;
using Microsoft.AspNetCore.SignalR;

namespace Imi.Project.Pin.Concept.Quiz.Hubs
{
    public class QuizHub : Hub
    {
        private readonly IPlayerTrackingService playerTrackingService;

        public QuizHub(IPlayerTrackingService PlayerTrackingService)
        {
            playerTrackingService = PlayerTrackingService;
        }

        public async Task SendMessage(string windowId, string message)
        {
            // Get the player name associated with the windowId
            var playerName = playerTrackingService.GetPlayerName(windowId);

            // Broadcast the message to all player windows except the sender
            await Clients.AllExcept(new[] { Context.ConnectionId }).SendAsync("ReceiveMessage", playerName, message);
        }

        public async Task UpdateScore(string windowId, int score)
        {
            // Get the player name associated with the windowId
            var playerName = playerTrackingService.GetPlayerName(windowId);

            // Broadcast the updated score to all player windows except the sender
            await Clients.AllExcept(new[] { Context.ConnectionId }).SendAsync("UpdateScore", playerName, score);
        }

        private string GetPlayerName(string windowId)
        {
            // Implement the logic to get the player name based on the windowId
            // This could be done using the playerWindows dictionary or any other data structure you are using to track players

            return string.Empty; // Return the player name or an empty string if not found
        }
    }
}
