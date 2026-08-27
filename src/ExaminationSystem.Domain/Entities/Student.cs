namespace ExaminationSystem.Domain.Entities;

public class Student
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public ICollection<Enrollment> Enrollments { get; set; } = [];
    public ICollection<QuizAttempt> QuizAttempts { get; set; } = [];
}
