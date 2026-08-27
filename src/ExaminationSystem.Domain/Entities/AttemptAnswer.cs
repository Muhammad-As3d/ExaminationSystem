namespace ExaminationSystem.Domain.Entities;

public sealed class AttemptAnswer : AuditableEntity
{
    public Guid QuizAttemptId { get; set; }
    public Guid QuestionId { get; set; }
    public Guid? SelectedOptionId { get; set; }
    public bool? IsCorrect { get; set; }
    public DateTime AnsweredAt { get; set; }

    public QuizAttempt QuizAttempt { get; set; } = default!;
    public Question Question { get; set; } = default!;
    public Option? SelectedOption { get; set; }
}
