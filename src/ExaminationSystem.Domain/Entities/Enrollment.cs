namespace ExaminationSystem.Domain.Entities;

public class Enrollment : AuditableEntity
{
    public Guid StudentId { get; set; }
    public Student Student { get; set; } = default!;
    public Guid DiplomaId { get; set; }
    public decimal Progress { get; set; } = 0m;
    public DateTime EnrolledAt { get; set; }

    public Diploma? Diploma { get; set; }
}
