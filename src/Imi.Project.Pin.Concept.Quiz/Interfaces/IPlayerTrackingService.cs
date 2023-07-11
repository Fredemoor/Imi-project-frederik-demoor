namespace Imi.Project.Pin.Concept.Quiz.Interfaces
{
    public interface IPlayerTrackingService
    {
        void AddPlayer(string windowId, string playerName);
        void RemovePlayer(string windowId);
        string GetPlayerName(string windowId);
        int GetPlayerIndexFromWindowId(string windowId);
    }
}
