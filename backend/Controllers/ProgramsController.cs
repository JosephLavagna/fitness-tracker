using Microsoft.AspNetCore.Mvc;
using FitnessCoachApi.Models;
using FitnessCoachApi.Services;

namespace FitnessCoachApi.Controllers;

/// <summary>
/// API controller for managing training programs
/// Provides endpoints for retrieving program information
/// </summary>
[ApiController]
[Route("api/[controller]")]
[Produces("application/json")]
public class ProgramsController : ControllerBase
{
    private readonly ProgramService _programService;
    private readonly ILogger<ProgramsController> _logger;

    public ProgramsController(ProgramService programService, ILogger<ProgramsController> logger)
    {
        _programService = programService;
        _logger = logger;
    }

    /// <summary>
    /// Gets all training programs
    /// </summary>
    /// <returns>List of all programs</returns>
    /// <response code="200">Returns the list of programs</response>
    /// <response code="500">If there's an internal server error</response>
    [HttpGet]
    [ProducesResponseType(typeof(IEnumerable<TrainingProgram>), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult<IEnumerable<TrainingProgram>>> GetPrograms()
    {
        try
        {
            _logger.LogInformation("Fetching all programs");
            var programs = await _programService.GetAllProgramsAsync();
            return Ok(programs);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error occurred while fetching programs");
            return StatusCode(500, "An error occurred while processing your request");
        }
    }

    /// <summary>
    /// Gets a specific program by ID
    /// </summary>
    /// <param name="id">The program's unique identifier</param>
    /// <returns>The requested program</returns>
    /// <response code="200">Returns the program</response>
    /// <response code="404">If the program is not found</response>
    /// <response code="500">If there's an internal server error</response>
    [HttpGet("{id}")]
    [ProducesResponseType(typeof(TrainingProgram), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult<TrainingProgram>> GetProgram(int id)
    {
        try
        {
            _logger.LogInformation("Fetching program with ID: {ProgramId}", id);
            var program = await _programService.GetProgramByIdAsync(id);
            
            if (program == null)
            {
                _logger.LogWarning("Program with ID {ProgramId} not found", id);
                return NotFound($"Program with ID {id} not found");
            }

            return Ok(program);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error occurred while fetching program with ID: {ProgramId}", id);
            return StatusCode(500, "An error occurred while processing your request");
        }
    }

    /// <summary>
    /// Gets featured programs for the homepage
    /// </summary>
    /// <returns>List of featured programs</returns>
    /// <response code="200">Returns the list of featured programs</response>
    /// <response code="500">If there's an internal server error</response>
    [HttpGet("featured")]
    [ProducesResponseType(typeof(IEnumerable<TrainingProgram>), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult<IEnumerable<TrainingProgram>>> GetFeaturedPrograms()
    {
        try
        {
            _logger.LogInformation("Fetching featured programs");
            var featuredPrograms = await _programService.GetFeaturedProgramsAsync();
            return Ok(featuredPrograms);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error occurred while fetching featured programs");
            return StatusCode(500, "An error occurred while processing your request");
        }
    }

    /// <summary>
    /// Gets programs by difficulty level
    /// </summary>
    /// <param name="difficulty">The difficulty level to filter by</param>
    /// <returns>List of programs with the specified difficulty level</returns>
    /// <response code="200">Returns the list of programs</response>
    /// <response code="400">If the difficulty parameter is invalid</response>
    /// <response code="500">If there's an internal server error</response>
    [HttpGet("difficulty/{difficulty}")]
    [ProducesResponseType(typeof(IEnumerable<TrainingProgram>), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult<IEnumerable<TrainingProgram>>> GetProgramsByDifficulty(string difficulty)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(difficulty))
            {
                return BadRequest("Difficulty level cannot be empty");
            }

            _logger.LogInformation("Fetching programs with difficulty: {Difficulty}", difficulty);
            var programs = await _programService.GetProgramsByDifficultyAsync(difficulty);
            return Ok(programs);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error occurred while fetching programs by difficulty: {Difficulty}", difficulty);
            return StatusCode(500, "An error occurred while processing your request");
        }
    }

    /// <summary>
    /// Gets programs by a specific coach
    /// </summary>
    /// <param name="coachId">The coach's unique identifier</param>
    /// <returns>List of programs created by the specified coach</returns>
    /// <response code="200">Returns the list of programs</response>
    /// <response code="400">If the coach ID is invalid</response>
    /// <response code="500">If there's an internal server error</response>
    [HttpGet("coach/{coachId}")]
    [ProducesResponseType(typeof(IEnumerable<TrainingProgram>), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult<IEnumerable<TrainingProgram>>> GetProgramsByCoach(int coachId)
    {
        try
        {
            if (coachId <= 0)
            {
                return BadRequest("Coach ID must be greater than 0");
            }

            _logger.LogInformation("Fetching programs for coach ID: {CoachId}", coachId);
            var programs = await _programService.GetProgramsByCoachAsync(coachId);
            return Ok(programs);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error occurred while fetching programs for coach ID: {CoachId}", coachId);
            return StatusCode(500, "An error occurred while processing your request");
        }
    }

    /// <summary>
    /// Gets programs by goal type
    /// </summary>
    /// <param name="goal">The goal to filter by</param>
    /// <returns>List of programs matching the specified goal</returns>
    /// <response code="200">Returns the list of programs</response>
    /// <response code="400">If the goal parameter is invalid</response>
    /// <response code="500">If there's an internal server error</response>
    [HttpGet("goal/{goal}")]
    [ProducesResponseType(typeof(IEnumerable<TrainingProgram>), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult<IEnumerable<TrainingProgram>>> GetProgramsByGoal(string goal)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(goal))
            {
                return BadRequest("Goal cannot be empty");
            }

            _logger.LogInformation("Fetching programs with goal: {Goal}", goal);
            var programs = await _programService.GetProgramsByGoalAsync(goal);
            return Ok(programs);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error occurred while fetching programs by goal: {Goal}", goal);
            return StatusCode(500, "An error occurred while processing your request");
        }
    }
}
