# Joeget.Results

A simple and extendable implementation of the result pattern for .NET.

[![NuGet](https://img.shields.io/nuget/v/results.joeget.svg)](https://www.nuget.org/packages/results.joeget)
[![License: MIT](https://img.shields.io/badge/License-MIT-blue.svg)](LICENSE)

## Overview

Joeget.Results provides a standardized way to represent operation outcomes, encapsulating both success and error states, with optional data and error details.  
This pattern helps you write cleaner, more robust, and more testable code by making success and failure explicit.

## Installation

Install via NuGet Package Manager:
`dotnet add package results.joeget`


Or via the NuGet UI in Visual Studio.

## Usage

### Basic Result

Use SuccessResult, or derived types of the ErrorResult to represent the outcome of operations.

using ResultPatternJoeget.Results;

```
// Success without data 
Result result = new SuccessResult();

// Success with data 
Result<T> result = new SuccessResult<(T)data>();

// Error with reason. Example given with the InternalErrorResult type

Result error = new InternalErrorResult("An unexpected error occurred");
```


### Error Types

The library provides several error result types for common scenarios:

- `InternalErrorResult` – For unexpected or server-side errors.
- `NotFoundErrorResult` – When a resource is not found.
- `AuthenticationErrorResult` – For authentication or authorization failures.
- `ValidationErrorResult` – For input or business rule validation errors.

All error results inherit from `ErrorResult`, which includes a `Reason` property describing the error.


### Custom Error Results

You can extend `ErrorResult` to define your own error types:

```
public class CustomErrorResult : ErrorResult 
{ 
   public CustomErrorResult(string reason) : base(reason) {}
}
```

## Target Framework

- .NET 9

## License

MIT

## Links

- [GitHub Repository](https://github.com/josephRashidMaalouf/ResultPatternJoeget)
- [NuGet Package](https://www.nuget.org/packages/results.joeget)
