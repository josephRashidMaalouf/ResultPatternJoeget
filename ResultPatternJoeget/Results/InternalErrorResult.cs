namespace ResultPatternJoeget.Results;

public class InternalErrorResult : ErrorResult
{
    public InternalErrorResult(string reason) : base(reason)
    {
    }
}