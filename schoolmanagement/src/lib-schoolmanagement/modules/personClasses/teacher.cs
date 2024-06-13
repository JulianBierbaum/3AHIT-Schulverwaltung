namespace lib_schoolmanagement.teacher;

using lib_schoolmanagement.person;

public class Teacher : Person {
    internal List<string> _subjects;

    public List<string> Subjects {
        get { return _subjects; }
    }

    internal Teacher(string name, List<string> subjects) : base(name) {
        _subjects = subjects;
    }

    public override string ToString() {
        return $"Student: {_name}, {_subjects}";
    }
}
