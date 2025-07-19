namespace ResultPatternJoeget.Errors;

public record NotFoundError(string Reason) : Error(Reason);