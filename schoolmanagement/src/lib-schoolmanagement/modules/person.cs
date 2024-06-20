namespace lib_schoolmanagement.person;

/// <summary>
/// Abstract Class Person
/// </summary>
public abstract class Person {
    internal string _name;

    public string Name {
        get { return _name; }
    }

    internal Person(string name) {
        _name = name;
    }

    public abstract override string ToString();
}
