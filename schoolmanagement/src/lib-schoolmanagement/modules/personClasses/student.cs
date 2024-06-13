namespace lib_schoolmanagement.student;

using lib_schoolmanagement.person;

internal class Student : Person {
    private string _studentClass;

    internal string StudentClass {
        get { return _studentClass; }
        set { _studentClass = value; }
    }

    internal Student(string name, string studentClass) : base(name) {
        _studentClass = studentClass;
    }

    public override string ToString() {
        return $"Student: {_name}, {_studentClass}";
    }
}
