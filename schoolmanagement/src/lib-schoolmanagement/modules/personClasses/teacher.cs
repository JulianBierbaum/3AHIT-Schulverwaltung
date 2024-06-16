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
        return $"Teacher: {_name}, Subjects: {string.Join(", ", _subjects)}";
    }
}
