namespace lib_schoolmanagement.interfaces.iStudentFunctions;

internal interface IStudentFunctions {
    internal void AddStudent(string name, string studentClass);
    internal void RemoveStudent(string name, string studentClass);
    internal void ChangeStudent(string name, string studentClass, string newName, string newStudentClass);
}
