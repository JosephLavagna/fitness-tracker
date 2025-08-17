namespace FitnessCoachApi.Models;

/// <summary>
/// Represents a fitness coach with their qualifications and specializations
/// </summary>
public class Coach
{
    /// <summary>
    /// Unique identifier for the coach
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Full name of the coach
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Coach's main area of specialization (e.g., "Bodybuilding", "Powerlifting")
    /// </summary>
    public string Specialization { get; set; } = string.Empty;

    /// <summary>
    /// Brief description of the coach's background and approach
    /// </summary>
    public string Description { get; set; } = string.Empty;

    /// <summary>
    /// Years of coaching experience
    /// </summary>
    public int Experience { get; set; }

    /// <summary>
    /// Number of clients successfully coached
    /// </summary>
    public int ClientCount { get; set; }

    /// <summary>
    /// Success rate percentage (0-100)
    /// </summary>
    public decimal SuccessRate { get; set; }

    /// <summary>
    /// Average rating from clients (1-5 stars)
    /// </summary>
    public decimal Rating { get; set; }

    /// <summary>
    /// URL to the coach's profile image
    /// </summary>
    public string? ProfileImage { get; set; }

    /// <summary>
    /// List of specific specialties and skills
    /// </summary>
    public List<string> Specialties { get; set; } = new();

    /// <summary>
    /// Indicates if this coach should be featured on the homepage
    /// </summary>
    public bool IsFeatured { get; set; }

    /// <summary>
    /// Professional certifications held by the coach
    /// </summary>
    public List<string> Certifications { get; set; } = new();

    /// <summary>
    /// Contact email for the coach
    /// </summary>
    public string Email { get; set; } = string.Empty;

    /// <summary>
    /// Hourly rate for coaching sessions
    /// </summary>
    public decimal HourlyRate { get; set; }

    /// <summary>
    /// Whether the coach is currently accepting new clients
    /// </summary>
    public bool IsAvailable { get; set; } = true;
}
