namespace ExaminationSystem.Domain.Entities;

public class Diploma : AuditableEntity
{
    public string Title { get; set; } = string.Empty;
    public string? Description { get; set; }
    public DiplomaStatus DiplomaStatus { get; set; }

    public ICollection<Enrollment> Enrollments { get; set; } = [];
    public ICollection<Quiz> Quizzes { get; set; } = [];
}