namespace blazor_schoolmanagement.Components.Pages;

using Microsoft.AspNetCore.Components;

using lib_schoolmanagement.person;
using lib_schoolmanagement.peopleManagement;
using lib_schoolmanagement.student;

public class ListBase : ComponentBase {
    List<Person> studentObj = PeopleManagement.GetInstance().ListPersons(Type.STUDENT);
    List<Person> teacherObj = PeopleManagement.GetInstance().ListPersons(Type.TEACHER);

    public List<string> people = [];

    protected override void OnInitialized() {
        studentObj = PeopleManagement.GetInstance().ListPersons(Type.STUDENT);
        teacherObj = PeopleManagement.GetInstance().ListPersons(Type.TEACHER);

        foreach (Person student in studentObj) {
            people.Add(student.ToString());
        }

        foreach (Person teacher in teacherObj) {
            people.Add(teacher.ToString());
        }
    }
}
