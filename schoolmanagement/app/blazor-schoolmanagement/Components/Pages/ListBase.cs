namespace blazor_schoolmanagement.Components.Pages;

using Microsoft.AspNetCore.Components;

using lib_schoolmanagement.person;
using lib_schoolmanagement.peopleManagement;

public class ListBase : ComponentBase {
    public string? Person { get; set; }

    public List<Person> GetPeople() {
        PeopleManagement.GetInstance().AddStudent("test", "3AHIT");
        List<Person> people = PeopleManagement.GetInstance().ListPersons(Type.STUDENT);

        Person = people[0].ToString();
        return people;
    }
}
