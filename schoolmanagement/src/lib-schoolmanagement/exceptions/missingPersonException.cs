namespace lib_schoolmanagement.exceptions;

public class MissingPersonException : Exception {
    public MissingPersonException(string person) : base($"The Person: '{person}' was not found.\n") {}
}