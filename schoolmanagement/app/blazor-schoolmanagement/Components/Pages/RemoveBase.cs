namespace blazor_schoolmanagement.Components.Pages;

using Microsoft.AspNetCore.Components;
using lib_schoolmanagement.peopleManagement;

public class RemoveBase : ComponentBase {
    public required string studentName;
    public required string studentClass;

    public required string teacherName;

    public string status = "";

    public void RemoveStudent() {
        try {
            if (studentName != null && studentClass != null) {
                PeopleManagement.GetInstance().RemoveStudent(studentName, studentClass);
                status = "Person Removed!";
            }
        } catch (Exception) {
            status = "This Person doesn't exist!";
        }
    }

    public void RemoveTeacher() {
        try {
            if (teacherName != null) {
                PeopleManagement.GetInstance().RemoveTeacher(teacherName);
                status = "Person Removed!";
            }
        } catch (Exception) {
            status = "This Person doesn't exist!";
        }
    }
}