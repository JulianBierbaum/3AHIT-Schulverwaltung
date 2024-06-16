namespace blazor_schoolmanagement.Components.Pages;

using Microsoft.AspNetCore.Components;
using lib_schoolmanagement.peopleManagement;

public class ChangeBase : ComponentBase {
    public required string studentName;
    public required string studentClass;
    public required string newStudentName;
    public required string newStudentClass;

    public required string teacherName;
    public required string newTeacherName;
    public required string newSubjects;
    public List<string>? teacherSubjects;

    public string status = "";

    public void ChangeStudent() {
        try {
            if (studentName != null && studentClass != null) {
                if (newStudentClass == null) {
                    newStudentClass = studentClass;
                } if (newStudentName == null) {
                    newStudentName = studentName;
                }

                PeopleManagement.GetInstance().ChangeStudent(studentName, studentClass, newStudentName, newStudentClass);
                status = "Person Changed!";
            }
        } catch (Exception) {
            status = "This Person doesn't exists!";
        }
    }

    public void ChangeTeacher() {
        try {
            if (teacherName != null) {
                if (newTeacherName == null) {
                    newTeacherName = teacherName;
                }

                teacherSubjects = newSubjects.Split(" ").ToList();
                PeopleManagement.GetInstance().ChangeTeacher(teacherName, newTeacherName, teacherSubjects);
                status = "Person Changed!";
            }
        } catch (Exception) {
            status = "This Person doesn't exists!";
        }
    }
}
