namespace blazor_schoolmanagement.Components.Pages;

using Microsoft.AspNetCore.Components;
using lib_schoolmanagement.peopleManagement;

public class AddBase : ComponentBase {
    public required string studentName;
    public required string studentClass;

    public required string teacherName;
    public required string subjects;
    public List<string>? teacherSubjects;

    public string status = "";

    public void AddStudent() {
        try {
            if (studentName != null && studentClass != null) {
                PeopleManagement.GetInstance().AddStudent(studentName, studentClass);
                status = "Person Added!";
            }
        } catch (Exception) {
            status = "This Person already exists!";
        }
    }

    public void AddTeacher() {
        try {
            if (teacherName != null && subjects != null) {
                teacherSubjects = subjects.Split(" ").ToList();
                PeopleManagement.GetInstance().AddTeacher(teacherName, teacherSubjects);
                status = "Person Added!";
            }
        } catch (Exception) {
            status = "This Person already exists!";
        }
    }
}
