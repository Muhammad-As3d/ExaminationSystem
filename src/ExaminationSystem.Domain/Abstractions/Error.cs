namespace ExaminationSystem.Domain.Abstractions;

public record Error(string Code, string DescriptionEn, string DescriptionAr, ErrorType ErrorType)
{
    public static readonly Error None = new(null!, null!, null!, ErrorType.Failure);

    public static implicit operator Result(Error error) => Result.Failure(error);

    public static Error Failure(string Code, string DescriptionEn, string DescriptionAr) =>
       new(Code, DescriptionEn, DescriptionAr, ErrorType.Failure);
    public static Error NotFound(string Code, string DescriptionEn, string DescriptionAr) =>
        new(Code, DescriptionEn, DescriptionAr, ErrorType.NotFound);
    public static Error Conflict(string Code, string DescriptionEn, string DescriptionAr) =>
        new(Code, DescriptionEn, DescriptionAr, ErrorType.Conflict);
    public static Error BadRequest(string Code, string DescriptionEn, string DescriptionAr) =>
        new(Code, DescriptionEn, DescriptionAr, ErrorType.BadRequest);
    public static Error Unauthorized(string Code, string DescriptionEn, string DescriptionAr) =>
        new(Code, DescriptionEn, DescriptionAr, ErrorType.Unauthorized);
    public static Error Forbidden(string Code, string DescriptionEn, string DescriptionAr) =>
        new(Code, DescriptionEn, DescriptionAr, ErrorType.Forbidden);
    public static Error InvalidCredentials(string Code, string DescriptionEn, string DescriptionAr) =>
        new(Code, DescriptionEn, DescriptionAr, ErrorType.InvalidCredentials);
}

public enum ErrorType
{
    Failure,
    NotFound,
    Conflict,
    BadRequest,
    Unauthorized,
    Forbidden,
    InvalidCredentials
}
