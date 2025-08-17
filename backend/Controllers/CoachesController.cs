using Microsoft.AspNetCore.Mvc;
using FitnessCoachApi.Models;
using FitnessCoachApi.Services;

namespace FitnessCoachApi.Controllers;

/// <summary>
/// API controller for managing coaches
/// Provides endpoints for retrieving coach information
/// </summary>
[ApiController]
[Route("api/[controller]")]
[Produces("application/json")]
public class CoachesController : ControllerBase
{
    private readonly CoachService _coachService;
    private readonly ILogger<CoachesController> _logger;

    public CoachesController(CoachService coachService, ILogger<CoachesController> logger)
    {
        _coachService = coachService;
        _logger = logger;
    }

    /// <summary>
    /// Gets all coaches
    /// </summary>
    /// <returns>List of all coaches</returns>
    /// <response code="200">Returns the list of coaches</response>
    /// <response code="500">If there's an internal server error</response>
    [HttpGet]
    [ProducesResponseType(typeof(IEnumerable<Coach>), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult<IEnumerable<Coach>>> GetCoaches()
    {
        try
        {
            _logger.LogInformation("Fetching all coaches");
            var coaches = await _coachService.GetAllCoachesAsync();
            return Ok(coaches);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error occurred while fetching coaches");
            return StatusCode(500, "An error occurred while processing your request");
        }
    }

    /// <summary>
    /// Gets a specific coach by ID
    /// </summary>
    /// <param name="id">The coach's unique identifier</param>
    /// <returns>The requested coach</returns>
    /// <response code="200">Returns the coach</response>
    /// <response code="404">If the coach is not found</response>
    /// <response code="500">If there's an internal server error</response>
    [HttpGet("{id}")]
    [ProducesResponseType(typeof(Coach), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult<Coach>> GetCoach(int id)
    {
        try
        {
            _logger.LogInformation("Fetching coach with ID: {CoachId}", id);
            var coach = await _coachService.GetCoachByIdAsync(id);
            
            if (coach == null)
            {
                _logger.LogWarning("Coach with ID {CoachId} not found", id);
                return NotFound($"Coach with ID {id} not found");
            }

            return Ok(coach);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error occurred while fetching coach with ID: {CoachId}", id);
            return StatusCode(500, "An error occurred while processing your request");
        }
    }

    /// <summary>
    /// Gets featured coaches for the homepage
    /// </summary>
    /// <returns>List of featured coaches</returns>
    /// <response code="200">Returns the list of featured coaches</response>
    /// <response code="500">If there's an internal server error</response>
    [HttpGet("featured")]
    [ProducesResponseType(typeof(IEnumerable<Coach>), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult<IEnumerable<Coach>>> GetFeaturedCoaches()
    {
        try
        {
            _logger.LogInformation("Fetching featured coaches");
            var featuredCoaches = await _coachService.GetFeaturedCoachesAsync();
            return Ok(featuredCoaches);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error occurred while fetching featured coaches");
            return StatusCode(500, "An error occurred while processing your request");
        }
    }

    /// <summary>
    /// Gets coaches by specialization
    /// </summary>
    /// <param name="specialization">The specialization to search for</param>
    /// <returns>List of coaches with the specified specialization</returns>
    /// <response code="200">Returns the list of coaches</response>
    /// <response code="400">If the specialization parameter is invalid</response>
    /// <response code="500">If there's an internal server error</response>
    [HttpGet("specialization/{specialization}")]
    [ProducesResponseType(typeof(IEnumerable<Coach>), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult<IEnumerable<Coach>>> GetCoachesBySpecialization(string specialization)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(specialization))
            {
                return BadRequest("Specialization cannot be empty");
            }

            _logger.LogInformation("Fetching coaches with specialization: {Specialization}", specialization);
            var coaches = await _coachService.GetCoachesBySpecializationAsync(specialization);
            return Ok(coaches);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error occurred while fetching coaches by specialization: {Specialization}", specialization);
            return StatusCode(500, "An error occurred while processing your request");
        }
    }

    /// <summary>
    /// Gets coaches available for new clients
    /// </summary>
    /// <returns>List of available coaches</returns>
    /// <response code="200">Returns the list of available coaches</response>
    /// <response code="500">If there's an internal server error</response>
    [HttpGet("available")]
    [ProducesResponseType(typeof(IEnumerable<Coach>), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult<IEnumerable<Coach>>> GetAvailableCoaches()
    {
        try
        {
            _logger.LogInformation("Fetching available coaches");
            var availableCoaches = await _coachService.GetAvailableCoachesAsync();
            return Ok(availableCoaches);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error occurred while fetching available coaches");
            return StatusCode(500, "An error occurred while processing your request");
        }
    }

    /// <summary>
    /// Gets top-rated coaches
    /// </summary>
    /// <returns>List of top-rated coaches</returns>
    /// <response code="200">Returns the list of top-rated coaches</response>
    /// <response code="500">If there's an internal server error</response>
    [HttpGet("top-rated")]
    [ProducesResponseType(typeof(IEnumerable<Coach>), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult<IEnumerable<Coach>>> GetTopRatedCoaches()
    {
        try
        {
            _logger.LogInformation("Fetching top-rated coaches");
            var topRatedCoaches = await _coachService.GetTopRatedCoachesAsync();
            return Ok(topRatedCoaches);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error occurred while fetching top-rated coaches");
            return StatusCode(500, "An error occurred while processing your request");
        }
    }
}
