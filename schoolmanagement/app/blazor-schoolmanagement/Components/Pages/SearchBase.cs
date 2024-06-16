namespace blazor_schoolmanagement.Components.Pages;

using Microsoft.AspNetCore.Components;
using lib_schoolmanagement.person;
using lib_schoolmanagement.peopleManagement;

public class SearchBase : ComponentBase {
    public required string name;
    public List<string> people = [];

    public void SearchPeople() {
        people = [];
        List<Person> personObj = PeopleManagement.GetInstance().SearchPerson(name);

        foreach (Person person in personObj) {
            people.Add(person.ToString());
        }
    }
}