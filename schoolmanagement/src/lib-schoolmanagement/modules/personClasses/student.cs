namespace lib_schoolmanagement.student;

using lib_schoolmanagement.person;

/// <summary>
/// Student Class
/// </summary>
public class Student : Person {
    internal string _studentClass;

    public string StudentClass {
        get { return _studentClass; }
    }

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="name">Name of the Student</param>
    /// <param name="studentClass">Class of the Student</param>
    internal Student(string name, string studentClass) : base(name) {
        _studentClass = studentClass;
    }

    /// <summary>
    /// ToString Method for Student
    /// </summary>
    /// <returns>String Representation of Student</returns>
    public override string ToString() {
        return $"Student: {_name}, {_studentClass}";
    }
}
