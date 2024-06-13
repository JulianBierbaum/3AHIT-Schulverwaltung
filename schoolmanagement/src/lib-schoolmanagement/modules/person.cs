namespace lib_schoolmanagement.person;

internal abstract class Person {
    protected string _name;

    internal string Name {
        get { return _name; }
        set { _name = value; }
    }

    internal Person(string name) {
        _name = name;
    }

    public abstract override string ToString();
}
