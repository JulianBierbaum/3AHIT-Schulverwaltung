namespace lib_schoolmanagement.peopleManagement;

using lib_schoolmanagement.interfaces.iStudentFunctions;
using lib_schoolmanagement.interfaces.iTeacherFunctions;
using lib_schoolmanagement.person;
using lib_schoolmanagement.student;
using lib_schoolmanagement.teacher;

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
                listedPersons.Add(person);
            }
            else if (person.GetType() == typeof(Teacher) && type == Type.TEACHER) {
                listedPersons.Add(person);
            }
        }

        return listedPersons;
    }

    public List<Person> SearchPerson(string name, Type type) {
        List<Person> searchedPersons = new List<Person>();

        foreach (Person person in _peoples) {
            if (person.Name == name && person.GetType() == typeof(Student) && type == Type.STUDENT) {
                searchedPersons.Add(person);
            }
            else if (person.Name == name && person.GetType() == typeof(Teacher) && type == Type.TEACHER) {
                searchedPersons.Add(person);
            }
        }

        return searchedPersons;
    }

    public void AddStudent(string name, string studentClass) {
        _peoples.Add(new Student(name, studentClass));
    }

    public void AddTeacher(string name, List<string> subjects) {
        _peoples.Add(new Teacher(name, subjects));
    }

    public void RemoveStudent(string name, string studentClass) {
        foreach (Student student in _peoples) {
            if (student.Name == name && student.StudentClass == studentClass) {
                _peoples.Remove(student);
            }
        }
    }

    public void RemoveTeacher(string name) {
        foreach (Teacher teacher in _peoples) {
            if (teacher.Name == name) {
                _peoples.Remove(teacher);
            }
        }
    }
}

public enum Type {
    STUDENT,
    TEACHER
}
