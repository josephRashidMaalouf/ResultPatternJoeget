namespace ResultPatternJoeget.Results;

public class NotFoundErrorResult : ErrorResult
{
    public NotFoundErrorResult(string reason) : base(reason)
    {
    }
}