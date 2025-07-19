namespace ResultPatternJoeget.Results;

public class AuthenticationErrorResult : ErrorResult
{
    public AuthenticationErrorResult(string reason) : base(reason)
    {
    }
}