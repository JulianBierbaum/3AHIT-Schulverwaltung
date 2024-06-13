namespace lib_schoolmanagement.peopleManagement;

using lib_schoolmanagement.interfaces.iStudentFunctions;
using lib_schoolmanagement.interfaces.iTeacherFunctions;
using lib_schoolmanagement.person;
using lib_schoolmanagement.student;

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

    public List<Person> ListPersons(Type type) {
        List<Person> listedPersons = new List<Person>();

        foreach (Person person in _peoples) {
            if (person.GetType() == typeof(Student) && type == Type.STUDENT) {

            }
        }

        return listedPersons;
    }
}

public enum Type {
    STUDENT,
    TEACHER
}
