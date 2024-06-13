namespace lib_schoolmanagement.teacher;

using lib_schoolmanagement.person;

internal class Teacher : Person {
    private List<string> _subjects;

    internal List<string> Subjects {
        get { return _subjects; }
        set { _subjects = value; }
    }

    internal Teacher(string name, List<string> subjects) : base(name) {
        _subjects = subjects;
    }

    public override string ToString() {
        return $"Student: {_name}, {_subjects}";
    }
}
