namespace lib_schoolmanagement.teacher;

using lib_schoolmanagement.person;

/// <summary>
/// Teacher Class
/// </summary>
public class Teacher : Person {
    internal List<string> _subjects;

    public List<string> Subjects {
        get { return _subjects; }
    }

    /// <summary>
    /// Constructor         
    /// </summary>
    /// <param name="name">Name of the Teacher</param>
    /// <param name="subjects">List of the Subjects of the Teacher</param>
    internal Teacher(string name, List<string> subjects) : base(name) {
        _subjects = subjects;
    }

    /// <summary>
    /// ToString Method of Teacher
    /// </summary>
    /// <returns>String representation of the Teacher Object</returns>
    public override string ToString() {
        return $"Teacher: {_name}, Subjects: {string.Join(", ", _subjects)}";
    }
}
