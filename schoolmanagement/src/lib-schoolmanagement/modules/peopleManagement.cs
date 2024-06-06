namespace lib_schoolmanagement.peopleManagement;

using lib_schoolmanagement.person;

internal class PeopleManagement {
    private PeopleManagement() {}
    private static PeopleManagement? _instance;

    internal static PeopleManagement GetInstance() {
        if (_instance == null) {
            _instance = new PeopleManagement();
        }
        return _instance;
    }

    internal List<Person> _peoples = new List<Person>();

    internal List<Person> Peoples {
        get {
            return _peoples;
        }
    }
}
