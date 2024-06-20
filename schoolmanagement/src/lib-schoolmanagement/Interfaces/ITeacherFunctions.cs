namespace lib_schoolmanagement.interfaces.iTeacherFunctions;

/// <summary>
/// Basic Functions for Teacher-Object manipulation
/// </summary>
internal interface ITeacherFunctions {
    internal void AddTeacher(string name, List<string> subjects);
    internal void RemoveTeacher(string name);
    internal void ChangeTeacher(string name, string newName, List<string> newSubjects);
}
