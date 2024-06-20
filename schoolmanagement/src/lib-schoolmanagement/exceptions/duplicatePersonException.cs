namespace lib_schoolmanagement.exceptions;

/// <summary>
/// Thrown if Person already in List
/// </summary>
public class DuplicatePersonException : Exception {
    public DuplicatePersonException(string person) : base($"The Person: '{person}'already exists.\n") {}
}