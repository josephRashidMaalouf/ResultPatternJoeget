namespace ResultPatternJoeget.Results;

public abstract class Result
{
    public bool Success { get; protected set; }
}
public abstract class Result<T> : Result
{
    public T Data { get; protected set; }

    protected Result(T data)
    {
        Data = data;
    }
}