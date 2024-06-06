namespace lib_schoolmanagement.person;

internal abstract class Person {
    protected string _name;
    protected List<string> _classes;

    internal string Name {
        get { return _name; }
        set { _name = value; }
    }

    internal List<string> Classes {
        get { return _classes; }
    }

    internal Person(string name, List<string> classes) {
        _name = name;
        _classes = classes;
    }

    public abstract override string ToString();
}
