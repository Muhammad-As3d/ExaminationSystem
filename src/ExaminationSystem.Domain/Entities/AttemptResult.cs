namespace ExaminationSystem.Domain.Entities;

public sealed class AttemptResult : AuditableEntity
{
    public Guid AttemptId { get; set; }
    public Guid StudentId { get; set; }
    public Guid QuizId { get; set; }
    public decimal Score { get; set; }
    public bool Passed { get; set; }
    public DateTime SubmittedAt { get; set; }

    public QuizAttempt Attempt { get; set; } = default!;
}
