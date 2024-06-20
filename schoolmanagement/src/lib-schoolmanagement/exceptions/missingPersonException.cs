namespace lib_schoolmanagement.exceptions;

/// <summary>
/// Thrown if Person not in List
/// </summary>
public class MissingPersonException : Exception {
    public MissingPersonException(string person) : base($"The Person: '{person}' was not found.\n") {}
}