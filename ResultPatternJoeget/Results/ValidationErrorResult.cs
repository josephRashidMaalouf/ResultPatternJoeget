namespace ResultPatternJoeget.Results;

public class ValidationErrorResult : ErrorResult
{
    public ValidationErrorResult(string reason) : base(reason)
    {
    }
}