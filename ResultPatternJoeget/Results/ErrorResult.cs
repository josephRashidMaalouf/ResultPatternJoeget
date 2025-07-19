using ResultPatternJoeget.Errors;

namespace ResultPatternJoeget.Results;

public class ErrorResult : Result
{
    public List<Error> Errors { get; } = [];

    public ErrorResult(params Error[] error)
    {
        Success = false;
        Errors.AddRange(error);
    }
}