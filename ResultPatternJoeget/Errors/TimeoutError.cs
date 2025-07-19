namespace ResultPatternJoeget.Errors;
public record TimeoutError(string Reason) : Error(Reason);