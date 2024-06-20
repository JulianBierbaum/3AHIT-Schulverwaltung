namespace lib_schoolmanagement.interfaces.iStudentFunctions;

/// <summary>
/// Basic Functions for Student-Object manipulation
/// </summary>
internal interface IStudentFunctions {
    internal void AddStudent(string name, string studentClass);
    internal void RemoveStudent(string name, string studentClass);
    internal void ChangeStudent(string name, string studentClass, string newName, string newStudentClass);
}
