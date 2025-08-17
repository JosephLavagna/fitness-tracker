using FitnessCoachApi.Models;
using FitnessCoachApi.Data;

namespace FitnessCoachApi.Services;

/// <summary>
/// Service class for handling program-related business logic
/// In a real application, this would interact with a database
/// </summary>
public class ProgramService
{
    /// <summary>
    /// Retrieves all training programs from the data source
    /// </summary>
    /// <returns>List of all programs</returns>
    public async Task<List<TrainingProgram>> GetAllProgramsAsync()
    {
        await Task.Delay(100);
        return MockData.GetPrograms();
    }

    /// <summary>
    /// Retrieves a specific program by its ID
    /// </summary>
    /// <param name="id">The program's unique identifier</param>
    /// <returns>The program if found, null otherwise</returns>
    public async Task<TrainingProgram?> GetProgramByIdAsync(int id)
    {
        await Task.Delay(50);
        return MockData.GetPrograms().FirstOrDefault(p => p.Id == id);
    }

    /// <summary>
    /// Retrieves only featured programs for homepage display
    /// </summary>
    /// <returns>List of featured programs</returns>
    public async Task<List<TrainingProgram>> GetFeaturedProgramsAsync()
    {
        await Task.Delay(75);
        return MockData.GetFeaturedPrograms();
    }

    /// <summary>
    /// Gets programs by difficulty level
    /// </summary>
    /// <param name="difficultyLevel">The difficulty level to filter by</param>
    /// <returns>List of programs matching the difficulty level</returns>
    public async Task<List<TrainingProgram>> GetProgramsByDifficultyAsync(string difficultyLevel)
    {
        await Task.Delay(100);
        return MockData.GetPrograms()
            .Where(p => p.DifficultyLevel.Equals(difficultyLevel, StringComparison.OrdinalIgnoreCase))
            .ToList();
    }

    /// <summary>
    /// Gets programs by a specific coach
    /// </summary>
    /// <param name="coachId">The coach's ID</param>
    /// <returns>List of programs created by the specified coach</returns>
    public async Task<List<TrainingProgram>> GetProgramsByCoachAsync(int coachId)
    {
        await Task.Delay(100);
        return MockData.GetPrograms()
            .Where(p => p.CoachId == coachId)
            .ToList();
    }

    /// <summary>
    /// Gets programs by goal type
    /// </summary>
    /// <param name="goal">The goal to filter by</param>
    /// <returns>List of programs matching the goal</returns>
    public async Task<List<TrainingProgram>> GetProgramsByGoalAsync(string goal)
    {
        await Task.Delay(100);
        return MockData.GetPrograms()
            .Where(p => p.Goal.Contains(goal, StringComparison.OrdinalIgnoreCase))
            .ToList();
    }

    /// <summary>
    /// Gets programs within a price range
    /// </summary>
    /// <param name="minPrice">Minimum price</param>
    /// <param name="maxPrice">Maximum price</param>
    /// <returns>List of programs within the price range</returns>
    public async Task<List<TrainingProgram>> GetProgramsByPriceRangeAsync(decimal minPrice, decimal maxPrice)
    {
        await Task.Delay(100);
        return MockData.GetPrograms()
            .Where(p => p.Price >= minPrice && p.Price <= maxPrice)
            .ToList();
    }
}
