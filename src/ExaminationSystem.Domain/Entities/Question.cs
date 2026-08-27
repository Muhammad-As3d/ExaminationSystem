namespace ExaminationSystem.Domain.Entities;

public class Question : AuditableEntity
{
    public Guid QuizId { get; set; }
    public string Text { get; set; } = default!;
    public string? Explanation { get; set; }
    public int OrderIndex { get; set; } = 1;
    public DateTime? DeletedAt { get; set; }
    public Quiz Quiz { get; set; } = default!;
    public ICollection<Option> Options { get; set; } = [];
    public ICollection<AttemptAnswer> AttemptAnswers { get; set; } = [];
}
