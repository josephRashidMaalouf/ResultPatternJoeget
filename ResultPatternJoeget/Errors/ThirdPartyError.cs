namespace ResultPatternJoeget.Errors;

public record ThirdPartyError(string Reason) : Error(Reason);