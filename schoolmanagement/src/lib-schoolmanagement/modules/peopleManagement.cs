namespace lib_schoolmanagement.peopleManagement;

using lib_schoolmanagement.exceptions;
using lib_schoolmanagement.interfaces.iStudentFunctions;
using lib_schoolmanagement.interfaces.iTeacherFunctions;
using lib_schoolmanagement.person;
using lib_schoolmanagement.student;
using lib_schoolmanagement.teacher;

/// <summary>
/// People Management Singleton Class
/// </summary>
public class PeopleManagement: IStudentFunctions, ITeacherFunctions {
    private PeopleManagement() {}
    private static PeopleManagement? _instance;

    /// <summary>
    /// GetInstance for Singleton class
    /// </summary>
    /// <returns>The Instance of the PeopleManagement object</returns>
    public static PeopleManagement GetInstance() {
        if (_instance == null) {
            _instance = new PeopleManagement();
        }
        return _instance;
    }

    private List<Person> _peoples = new List<Person>();

    /// <summary>
    /// Returns all Persons of specified type
    /// </summary>
    /// <param name="type">The of the Person (student, teacher)</param>
    /// <returns>List of the saved persons</returns>
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

    /// <summary>
    /// Searches for Persons of specified name
    /// </summary>
    /// <param name="name">Name of the searched person(s)</param>
    /// <returns>List of the found Persons</returns>
    public List<Person> SearchPerson(string name) {
        List<Person> searchedPersons = new List<Person>();

        foreach (Person person in _peoples) {
            if (person.Name == name) {
                searchedPersons.Add(person);
            }
        }

        return searchedPersons;
    }

    /// <summary>
    /// Method for adding a new Student
    /// </summary>
    /// <param name="name">Name of the Student</param>
    /// <param name="studentClass">Class of the Student</param>
    /// <exception cref="DuplicatePersonException">Thrown if Student with this name or class already exits</exception>
    public void AddStudent(string name, string studentClass) {
        foreach (Student student in _peoples.OfType<Student>()) {
            if (student.Name == name && student.StudentClass == studentClass) {
                throw new DuplicatePersonException(name);
            }
        }

        _peoples.Add(new Student(name, studentClass));
    }

    /// <summary>
    /// Method for adding a new Teacher
    /// </summary>
    /// <param name="name">Name of the Teacher</param>
    /// <param name="subjects">List of Subjects the Teacher has</param>
    /// <exception cref="DuplicatePersonException">Thrown if a teacher with this name already exits</exception>
    public void AddTeacher(string name, List<string> subjects) {
        foreach (Teacher teacher in _peoples.OfType<Teacher>()) {
            if (teacher.Name == name) {
                throw new DuplicatePersonException(name);
            }
        }

        _peoples.Add(new Teacher(name, subjects));
    }

    /// <summary>
    /// Method for removing Students
    /// </summary>
    /// <param name="name">Name of the Student to Remove</param>
    /// <param name="studentClass">CLass of the Student</param>
    /// <exception cref="MissingPersonException">Thrown if Student is not in List</exception>
    public void RemoveStudent(string name, string studentClass) {
        foreach (Student student in _peoples.OfType<Student>()) {
            if (student.Name == name && student.StudentClass == studentClass) {
                _peoples.Remove(student);
                return;
            }
        }
        
        throw new MissingPersonException(name);
    }

    /// <summary>
    /// Method for removing Students
    /// </summary>
    /// <param name="name">Name of the Teacher to Remove</param>
    /// <exception cref="MissingPersonException">Thrown if Teacher is not in List</exception>
    public void RemoveTeacher(string name) {
        foreach (Teacher teacher in _peoples.OfType<Teacher>()) {
            if (teacher.Name == name) {
                _peoples.Remove(teacher);
                return;
            }
        }

        throw new MissingPersonException(name);
    }

    /// <summary>
    /// Method for changing Student Attributes
    /// </summary>
    /// <param name="name">Name of the Student</param>
    /// <param name="studentClass">Class of the Student</param>
    /// <param name="newName">New Name for the Student</param>
    /// <param name="newStudentClass">New Class for the Student</param>
    /// <exception cref="MissingPersonException">Thrown if Student is not in List</exception>
    public void ChangeStudent(string name, string studentClass, string newName, string newStudentClass) {
        foreach (Student student in _peoples.OfType<Student>()) {
            if (student.Name == name && student.StudentClass == studentClass) {
                student._name = newName;
                student._studentClass = newStudentClass;
                return;
            }
        }

        throw new MissingPersonException(name);
    }

    /// <summary>
    /// Method for changing Teacher Attributes
    /// </summary>
    /// <param name="name">Name of the Teacher</param>
    /// <param name="newName">New Name of the Teacher</param>
    /// <param name="newSubjects">New Subject List if the Teacher</param>
    /// <exception cref="MissingPersonException">Thrown if Teacher is not in List</exception>
    public void ChangeTeacher(string name, string newName, List<string> newSubjects) {
        foreach (Teacher teacher in _peoples.OfType<Teacher>()) {
            if (teacher.Name == name) {
                teacher._name = newName;
                teacher._subjects = newSubjects;
                return;
            }
        }

        throw new MissingPersonException(name);
    }
}

public enum Type {
    STUDENT,
    TEACHER
}
