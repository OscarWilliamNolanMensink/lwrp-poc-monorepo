namespace Lwrp.Contracts;

/// <summary>
/// Non-generic Result for operations that only succeed/fail with an error message.
/// </summary>
public readonly record struct Result(bool IsSuccess, string? Error)
{
    public static Result Success() => new(true, null);

    public static Result Failure(string error) =>
        new(false, error);

    // Optional deconstruct, if you like pattern matching:
    public void Deconstruct(out bool isSuccess, out string? error) =>
        (isSuccess, error) = (IsSuccess, Error);
}

/// <summary>
/// Generic Result for operations that return a value on success.
/// </summary>
public readonly record struct Result<T>(bool IsSuccess, T? Value, string? Error)
{
    public static Result<T> Success(T value) =>
        new(true, value, null);

    public static Result<T> Failure(string error) =>
        new(false, default, error);

    public void Deconstruct(out bool isSuccess, out T? value, out string? error) =>
        (isSuccess, value, error) = (IsSuccess, Value, Error);
}
