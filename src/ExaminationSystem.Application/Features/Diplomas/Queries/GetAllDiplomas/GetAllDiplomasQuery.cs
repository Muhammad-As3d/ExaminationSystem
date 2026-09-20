using ExaminationSystem.Application.Abstractions.Messaging;
using ExaminationSystem.Domain.Entities;
using ExaminationSystem.Domain.Enums;

namespace ExaminationSystem.Application.Features.Diplomas.Queries.GetAllDiplomas;

public record GetAllDiplomasQuery() : IRequest<Diploma>;

public sealed class GetAllDiplomasQueryHandler : IRequestHandler<GetAllDiplomasQuery, Diploma>
{
    public async Task<Diploma> Handle(GetAllDiplomasQuery query, CancellationToken cancellationToken)
    {
        var diplomas = new Diploma { Title = "test", Description = "test", DiplomaStatus = DiplomaStatus.Published };

        return diplomas;
    }
}