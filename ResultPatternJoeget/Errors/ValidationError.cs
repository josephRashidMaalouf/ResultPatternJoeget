namespace ResultPatternJoeget.Errors;

public record ValidationError(string Reason) : Error(Reason);