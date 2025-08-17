namespace FitnessCoachApi.Models;

/// <summary>
/// Represents a training program offered by coaches
/// </summary>
public class TrainingProgram
{
    /// <summary>
    /// Unique identifier for the program
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Name of the training program
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Detailed description of the program
    /// </summary>
    public string Description { get; set; } = string.Empty;

    /// <summary>
    /// Duration of the program in weeks
    /// </summary>
    public int DurationWeeks { get; set; }

    /// <summary>
    /// Difficulty level (Beginner, Intermediate, Advanced, Expert)
    /// </summary>
    public string DifficultyLevel { get; set; } = string.Empty;

    /// <summary>
    /// Primary goal of the program (Mass Building, Fat Loss, Competition Prep, etc.)
    /// </summary>
    public string Goal { get; set; } = string.Empty;

    /// <summary>
    /// Price of the program
    /// </summary>
    public decimal Price { get; set; }

    /// <summary>
    /// ID of the coach who created this program
    /// </summary>
    public int CoachId { get; set; }

    /// <summary>
    /// Navigation property to the coach
    /// </summary>
    public Coach? Coach { get; set; }

    /// <summary>
    /// List of required equipment for the program
    /// </summary>
    public List<string> RequiredEquipment { get; set; } = new();

    /// <summary>
    /// Target muscle groups or body parts
    /// </summary>
    public List<string> TargetMuscles { get; set; } = new();

    /// <summary>
    /// Whether this program should be featured on the homepage
    /// </summary>
    public bool IsFeatured { get; set; }

    /// <summary>
    /// Number of users enrolled in this program
    /// </summary>
    public int EnrollmentCount { get; set; }

    /// <summary>
    /// Average rating from users (1-5 stars)
    /// </summary>
    public decimal Rating { get; set; }

    /// <summary>
    /// Prerequisites or requirements to join the program
    /// </summary>
    public List<string> Prerequisites { get; set; } = new();

    /// <summary>
    /// Expected outcomes or results from the program
    /// </summary>
    public List<string> ExpectedOutcomes { get; set; } = new();

    /// <summary>
    /// Whether the program is currently available for enrollment
    /// </summary>
    public bool IsAvailable { get; set; } = true;

    /// <summary>
    /// Date when the program was created
    /// </summary>
    public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

    /// <summary>
    /// Date when the program was last updated
    /// </summary>
    public DateTime LastUpdated { get; set; } = DateTime.UtcNow;
}
