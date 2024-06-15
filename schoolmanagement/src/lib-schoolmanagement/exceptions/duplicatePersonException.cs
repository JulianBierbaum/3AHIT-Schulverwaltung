namespace lib_schoolmanagement.exceptions;

public class DuplicatePersonException : Exception {
    public DuplicatePersonException(string person) : base($"The Person: '{person}'already exists.\n") {}
}