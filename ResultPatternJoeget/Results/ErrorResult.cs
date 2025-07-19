namespace ResultPatternJoeget.Results;

public abstract class ErrorResult : Result
{
    public string Reason { get; protected set; }
    public ErrorResult(string reason)
    {
        Success = false;
        Reason = reason;
    }
}