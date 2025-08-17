using FitnessCoachApi.Models;
using FitnessCoachApi.Data;

namespace FitnessCoachApi.Services;

/// <summary>
/// Service class for handling coach-related business logic
/// In a real application, this would interact with a database
/// </summary>
public class CoachService
{
    /// <summary>
    /// Retrieves all coaches from the data source
    /// </summary>
    /// <returns>List of all coaches</returns>
    public async Task<List<Coach>> GetAllCoachesAsync()
    {
        // Simulate async operation
        await Task.Delay(100);
        return MockData.GetCoaches();
    }

    /// <summary>
    /// Retrieves a specific coach by their ID
    /// </summary>
    /// <param name="id">The coach's unique identifier</param>
    /// <returns>The coach if found, null otherwise</returns>
    public async Task<Coach?> GetCoachByIdAsync(int id)
    {
        await Task.Delay(50);
        return MockData.GetCoaches().FirstOrDefault(c => c.Id == id);
    }

    /// <summary>
    /// Retrieves only featured coaches for homepage display
    /// </summary>
    /// <returns>List of featured coaches</returns>
    public async Task<List<Coach>> GetFeaturedCoachesAsync()
    {
        await Task.Delay(75);
        return MockData.GetFeaturedCoaches();
    }

    /// <summary>
    /// Searches coaches by specialization
    /// </summary>
    /// <param name="specialization">The specialization to search for</param>
    /// <returns>List of coaches matching the specialization</returns>
    public async Task<List<Coach>> GetCoachesBySpecializationAsync(string specialization)
    {
        await Task.Delay(100);
        return MockData.GetCoaches()
            .Where(c => c.Specialization.Contains(specialization, StringComparison.OrdinalIgnoreCase))
            .ToList();
    }

    /// <summary>
    /// Gets coaches available for new clients
    /// </summary>
    /// <returns>List of available coaches</returns>
    public async Task<List<Coach>> GetAvailableCoachesAsync()
    {
        await Task.Delay(100);
        return MockData.GetCoaches()
            .Where(c => c.IsAvailable)
            .ToList();
    }

    /// <summary>
    /// Gets top-rated coaches (rating >= 4.5)
    /// </summary>
    /// <returns>List of top-rated coaches</returns>
    public async Task<List<Coach>> GetTopRatedCoachesAsync()
    {
        await Task.Delay(100);
        return MockData.GetCoaches()
            .Where(c => c.Rating >= 4.5m)
            .OrderByDescending(c => c.Rating)
            .ToList();
    }
}
