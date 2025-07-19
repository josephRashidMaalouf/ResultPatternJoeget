namespace ResultPatternJoeget.Errors;

public record AuthenticationError(string Reason) : Error(Reason);