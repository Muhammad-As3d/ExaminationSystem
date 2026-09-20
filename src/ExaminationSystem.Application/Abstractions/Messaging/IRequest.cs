namespace ExaminationSystem.Application.Abstractions.Messaging;

public interface IRequest
{
}

public interface IRequest<out TResponse>
{
}