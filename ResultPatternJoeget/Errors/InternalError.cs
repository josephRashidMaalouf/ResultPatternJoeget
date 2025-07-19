namespace ResultPatternJoeget.Errors;

public record InternalError(string Reason) : Error(Reason);