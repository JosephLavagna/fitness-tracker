using FitnessCoachApi.Models;

namespace FitnessCoachApi.Data;

/// <summary>
/// Provides mock data for the application
/// In a real application, this would be replaced with a database
/// </summary>
public static class MockData
{
    /// <summary>
    /// Returns a list of sample coaches with realistic data
    /// </summary>
    public static List<Coach> GetCoaches()
    {
        return new List<Coach>
        {
            new Coach
            {
                Id = 1,
                Name = "Marcus Steel",
                Specialization = "Competitive Bodybuilding",
                Description = "Former Mr. Olympia competitor with 15 years of experience in elite bodybuilding. Specializes in contest preparation and advanced muscle development techniques.",
                Experience = 15,
                ClientCount = 250,
                SuccessRate = 94.5m,
                Rating = 4.9m,
                ProfileImage = "https://images.unsplash.com/photo-1571019613454-1cb2f99b2d8b?w=400",
                Specialties = new List<string> { "Contest Prep", "Advanced Training", "Posing", "Peak Week" },
                IsFeatured = true,
                Certifications = new List<string> { "IFBB Pro Card", "NASM-CPT", "Precision Nutrition Level 2" },
                Email = "marcus@elitefitnesscoach.com",
                HourlyRate = 150.00m,
                IsAvailable = true
            },
            new Coach
            {
                Id = 3,
                Name = "Tony \"The Tank\" Rodriguez",
                Specialization = "Mass Building & Strength",
                Description = "Powerlifting champion turned bodybuilding coach. Specializes in building serious mass and strength for aspiring bodybuilders and strength athletes.",
                Experience = 18,
                ClientCount = 320,
                SuccessRate = 92.8m,
                Rating = 4.7m,
                ProfileImage = "https://images.unsplash.com/photo-1583454110551-21f2fa2afe61?w=400",
                Specialties = new List<string> { "Mass Building", "Powerlifting", "Strength Training", "Progressive Overload" },
                IsFeatured = true,
                Certifications = new List<string> { "USAPL Certified", "NSCA-CSCS", "Starting Strength Coach" },
                Email = "tony@elitefitnesscoach.com",
                HourlyRate = 120.00m,
                IsAvailable = true
            },
            new Coach
            {
                Id = 4,
                Name = "Dr. Elena Volkov",
                Specialization = "Scientific Training & Recovery",
                Description = "PhD in Exercise Physiology with focus on evidence-based training methods. Combines cutting-edge science with practical bodybuilding application.",
                Experience = 10,
                ClientCount = 150,
                SuccessRate = 97.1m,
                Rating = 4.9m,
                ProfileImage = "https://images.unsplash.com/photo-1559839734-2b71ea197ec2?w=400",
                Specialties = new List<string> { "Scientific Training", "Recovery Optimization", "Periodization", "Sports Nutrition" },
                IsFeatured = false,
                Certifications = new List<string> { "PhD Exercise Physiology", "ACSM-CEP", "ISSN-CISSN" },
                Email = "elena@elitefitnesscoach.com",
                HourlyRate = 160.00m,
                IsAvailable = true
            },
            new Coach
            {
                Id = 5,
                Name = "Jake \"Titan\" Thompson",
                Specialization = "Classic Physique",
                Description = "Classic Physique specialist with aesthetic focus. Helps clients build the perfect balance of size, symmetry, and conditioning reminiscent of the Golden Era.",
                Experience = 8,
                ClientCount = 95,
                SuccessRate = 91.3m,
                Rating = 4.6m,
                ProfileImage = "https://images.unsplash.com/photo-1507003211169-0a1dd7228f2d?w=400",
                Specialties = new List<string> { "Classic Physique", "Symmetry", "Aesthetic Training", "Golden Era Style" },
                IsFeatured = false,
                Certifications = new List<string> { "ISSA-CFT", "NASM-CPT", "Precision Nutrition Level 1" },
                Email = "jake@elitefitnesscoach.com",
                HourlyRate = 110.00m,
                IsAvailable = true
            },
            new Coach
            {
                Id = 6,
                Name = "Amanda Force",
                Specialization = "Transformation & Fat Loss",
                Description = "Transformation specialist who helps clients achieve dramatic physique changes. Expert in combining muscle building with strategic fat loss for complete body recomposition.",
                Experience = 9,
                ClientCount = 200,
                SuccessRate = 93.7m,
                Rating = 4.8m,
                ProfileImage = "https://images.unsplash.com/photo-1438761681033-6461ffad8d80?w=400",
                Specialties = new List<string> { "Body Recomposition", "Fat Loss", "Muscle Building", "Lifestyle Coaching" },
                IsFeatured = true,
                Certifications = new List<string> { "NASM-CPT", "NASM-CNC", "Precision Nutrition Coach" },
                Email = "amanda@elitefitnesscoach.com",
                HourlyRate = 125.00m,
                IsAvailable = true
            }
        };
    }

    /// <summary>
    /// Returns a list of sample training programs
    /// </summary>
    public static List<TrainingProgram> GetPrograms()
    {
        return new List<TrainingProgram>
        {
            new TrainingProgram
            {
                Id = 1,
                Name = "Elite Mass Builder",
                Description = "Intensive 16-week program designed to pack on serious muscle mass. Perfect for intermediate to advanced trainees looking to break through plateaus.",
                DurationWeeks = 16,
                DifficultyLevel = "Advanced",
                Goal = "Mass Building",
                Price = 299.99m,
                CoachId = 3,
                RequiredEquipment = new List<string> { "Barbell", "Dumbbells", "Cable Machine", "Leg Press" },
                TargetMuscles = new List<string> { "Full Body", "Compound Focus" },
                IsFeatured = true,
                EnrollmentCount = 156,
                Rating = 4.8m
            },
            new TrainingProgram
            {
                Id = 2,
                Name = "Competition Prep Masterclass",
                Description = "Complete 20-week contest preparation program covering training, nutrition, posing, and peak week strategies used by IFBB Pro competitors.",
                DurationWeeks = 20,
                DifficultyLevel = "Expert",
                Goal = "Competition Prep",
                Price = 499.99m,
                CoachId = 1,
                RequiredEquipment = new List<string> { "Full Gym Access", "Posing Platform", "Cardio Equipment" },
                TargetMuscles = new List<string> { "Full Body", "Conditioning Focus" },
                IsFeatured = true,
                EnrollmentCount = 89,
                Rating = 4.9m
            },
            new TrainingProgram
            {
                Id = 3,
                Name = "Women's Figure Excellence",
                Description = "Specialized 12-week program for women focusing on building lean muscle while maintaining feminine curves and proportions.",
                DurationWeeks = 12,
                DifficultyLevel = "Intermediate",
                Goal = "Figure Development",
                Price = 249.99m,
                CoachId = 2,
                RequiredEquipment = new List<string> { "Dumbbells", "Cable Machine", "Resistance Bands" },
                TargetMuscles = new List<string> { "Glutes", "Shoulders", "Core", "Legs" },
                IsFeatured = true,
                EnrollmentCount = 203,
                Rating = 4.7m
            },
            new TrainingProgram
            {
                Id = 4,
                Name = "Scientific Strength & Size",
                Description = "Evidence-based 14-week program combining latest research in muscle hypertrophy with practical application for maximum results.",
                DurationWeeks = 14,
                DifficultyLevel = "Intermediate",
                Goal = "Strength & Hypertrophy",
                Price = 349.99m,
                CoachId = 4,
                RequiredEquipment = new List<string> { "Barbell", "Dumbbells", "Cable Machine", "Bench" },
                TargetMuscles = new List<string> { "Full Body", "Evidence-Based Programming" },
                IsFeatured = false,
                EnrollmentCount = 67,
                Rating = 4.9m
            }
        };
    }

    /// <summary>
    /// Returns only featured coaches for homepage display
    /// </summary>
    public static List<Coach> GetFeaturedCoaches()
    {
        return GetCoaches().Where(c => c.IsFeatured).ToList();
    }

    /// <summary>
    /// Returns only featured programs for homepage display
    /// </summary>
    public static List<TrainingProgram> GetFeaturedPrograms()
    {
        return GetPrograms().Where(p => p.IsFeatured).ToList();
    }
}
