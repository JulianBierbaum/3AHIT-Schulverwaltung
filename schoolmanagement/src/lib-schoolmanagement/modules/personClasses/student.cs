namespace lib_schoolmanagement.student;

using lib_schoolmanagement.person;

public class Student : Person {
    internal string _studentClass;

    public string StudentClass {
        get { return _studentClass; }
    }

    internal Student(string name, string studentClass) : base(name) {
        _studentClass = studentClass;
    }

    public override string ToString() {
        return $"Student: {_name}, {_studentClass}";
    }
}
