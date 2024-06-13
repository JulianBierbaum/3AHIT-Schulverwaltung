namespace lib_schoolmanagement.peopleManagement;

using lib_schoolmanagement.interfaces.iStudentFunctions;
using lib_schoolmanagement.interfaces.iTeacherFunctions;
using lib_schoolmanagement.person;

public class PeopleManagement: IStudentFunctions, ITeacherFunctions {
    private PeopleManagement() {}
    private static PeopleManagement? _instance;

    public static PeopleManagement GetInstance() {
        if (_instance == null) {
            _instance = new PeopleManagement();
        }
        return _instance;
    }

    private List<Person> _peoples = new List<Person>();

    public List<Person> ListPersons() {
        
    }
}
