namespace console_schoolmanagement;

using lib_schoolmanagement.exceptions;
using lib_schoolmanagement.peopleManagement;

class Program {
    static void Main(string[] args) {
        while(true) {
            Console.WriteLine("_____________________________________");
            Console.WriteLine("The following commands are available:\n");
            Console.WriteLine("List Persons:        | l |");
            Console.WriteLine("Search Person:       | s |");
            Console.WriteLine("Add Person:          | a |");
            Console.WriteLine("Remove Person:       | r |");
            Console.WriteLine("Change Person:       | c |");
            Console.WriteLine("Quit:                | q |\n");

            switch (Console.ReadLine()) {
                case "c":
                    Console.WriteLine("What do you want to change?:\n");
                    Console.WriteLine("Student:        | 1 |");
                    Console.WriteLine("Teacher:        | 2 |\n");

                    switch (Console.ReadLine()) {
                        case "1":
                            Console.WriteLine("\n\n");
                            Console.WriteLine("Name of the Person:");
                            string? studentName = Console.ReadLine();

                            Console.WriteLine("\nStudent Class:");
                            string? studentClass = Console.ReadLine();

                            Console.WriteLine("\nNew Name (empty for same):");
                            string? newName = Console.ReadLine();

                            Console.WriteLine("\nNew Class (empty for same):");
                            string? newClass = Console.ReadLine();

                            if (studentName == null || studentClass == null) {
                                Console.WriteLine("\nInvalid Input\n\n");
                                break;
                            } if (newClass == null) {
                                newClass = studentClass;
                            } if (newName == null) {
                                newName = studentName;
                            }

                            try {
                                PeopleManagement.GetInstance().ChangeStudent(studentName, studentClass, newName, newClass);
                            } catch (MissingPersonException) {
                                Console.WriteLine("\nThis Student wasn't found\n\n");
                            }
                        break;
                        
                        case "2":
                            Console.WriteLine("\n\n");
                            Console.WriteLine("Name of the Teacher:");
                            string? teacherName = Console.ReadLine();

                            if (teacherName == null) {
                                Console.WriteLine("\nInvalid Input\n\n");
                                break;
                            }
                            
                            Console.WriteLine("\nNew Name (empty for same):");
                            string? newTeacherName = Console.ReadLine();

                            Console.WriteLine("Enter the Subjects (Seperated by WHITESPACE, leave empty for same):");
                            string? teacherSubjects = Console.ReadLine();

                            if (newTeacherName == null || teacherSubjects == null) {
                                Console.WriteLine("\nInvalid Input\n\n");
                                break;
                            } if (newTeacherName == null) {
                                newTeacherName = teacherName;
                            }

                            List<string>? newTeacherSubjects = teacherSubjects.Split(" ").ToList();

                            try {
                                PeopleManagement.GetInstance().ChangeTeacher(teacherName, newTeacherName, newTeacherSubjects);
                            } catch (MissingPersonException) {
                                Console.WriteLine("\nThis Student wasn't found\n\n");
                            }
                            
                        break;
                        
                        default:
                            Console.WriteLine("\nInvalid Input\n\n");
                        break;
                    }
                break;

                case "r":
                    Console.WriteLine("What do you want to remove?:\n");
                    Console.WriteLine("Student:        | 1 |");
                    Console.WriteLine("Teacher:        | 2 |\n");

                    switch (Console.ReadLine()) {
                        case "1":
                            Console.WriteLine("\n\n");
                            Console.WriteLine("Name of the Person:");
                            string? studentName = Console.ReadLine();

                            Console.WriteLine("\nStudent Class:");
                            string? studentClass = Console.ReadLine();

                            if (studentName == null || studentClass == null) {
                                Console.WriteLine("\nInvalid Input\n\n");
                                break;
                            }
                            
                            try {
                                PeopleManagement.GetInstance().RemoveStudent(studentName, studentClass);
                            } catch (MissingPersonException) {
                                Console.WriteLine("\nThis Student wasn't found\n\n");
                            }
                        break;
                        
                        case "2":
                            Console.WriteLine("\n\n");
                            Console.WriteLine("Name of the Teacher:");
                            string? teacherName = Console.ReadLine();

                            if (teacherName == null) {
                                Console.WriteLine("\nInvalid Input\n\n");
                                break;
                            }
                            
                            try {
                                PeopleManagement.GetInstance().RemoveTeacher(teacherName);
                            } catch (MissingPersonException) {
                                Console.WriteLine("\nThis Teacher wasn't found\n\n");
                            }
                            
                        break;
                        
                        default:
                            Console.WriteLine("\nInvalid Input\n\n");
                        break;
                    }
                break;

                case "a":
                    Console.WriteLine("What do you want to add?:\n");
                    Console.WriteLine("Student:        | 1 |");
                    Console.WriteLine("Teacher:        | 2 |\n");

                    switch (Console.ReadLine()) {
                        case "1":
                            Console.WriteLine("\n\n");
                            Console.WriteLine("Name of the Person:");
                            string? studentName = Console.ReadLine();

                            Console.WriteLine("\nStudent Class:");
                            string? studentClass = Console.ReadLine();

                            if (studentName == null || studentClass == null) {
                                Console.WriteLine("\nInvalid Input\n\n");
                                break;
                            }
                            
                            try {
                                PeopleManagement.GetInstance().AddStudent(studentName, studentClass);
                            } catch (DuplicatePersonException) {
                                Console.WriteLine("\nThis Student already exists\n\n");
                            }
                        break;
                        
                        case "2":
                            Console.WriteLine("\n\n");
                            Console.WriteLine("Name of the Teacher:");
                            string? teacherName = Console.ReadLine();

                            Console.WriteLine("Enter the Subjects (Seperated by WHITESPACE):");
                            string? subjects = Console.ReadLine();

                            if (teacherName == null || subjects == null) {
                                Console.WriteLine("\nInvalid Input\n\n");
                                break;
                            }
                            List<string>? teacherSubjects = subjects.Split(" ").ToList();
                            
                            try {
                                PeopleManagement.GetInstance().AddTeacher(teacherName, teacherSubjects);
                            } catch (DuplicatePersonException) {
                                Console.WriteLine("\nThis Teacher already exists\n\n");
                            }
                            
                        break;
                        
                        default:
                            Console.WriteLine("\nInvalid Input\n\n");
                        break;
                    }
                break;

                case "l":
                    Console.WriteLine("What do you want to list?:\n");
                    Console.WriteLine("Students:        | 1 |");
                    Console.WriteLine("Teachers:        | 2 |\n");

                    switch (Console.ReadLine()) {
                        case "1":
                            Console.WriteLine("\n\n");
                            foreach (var person in PeopleManagement.GetInstance().ListPersons(Type.STUDENT)) {
                                Console.WriteLine(person.ToString());
                            }
                        break;
                        
                        case "2":
                            Console.WriteLine("\n\n");
                            foreach (var person in PeopleManagement.GetInstance().ListPersons(Type.TEACHER)) {
                                Console.WriteLine(person.ToString());
                            }
                        break;
                        
                        default:
                            Console.WriteLine("\nInvalid Input\n\n");
                        break;
                    }
                break;
                
                case "s":
                    Console.WriteLine("Name of the Person:");
                    string? name = Console.ReadLine();

                    if (name == null) {
                        Console.WriteLine("\nInvalid Input\n\n");
                        break;
                    }

                    Console.WriteLine("\n\n");
                    Console.WriteLine("What do you want to search?:\n");
                    Console.WriteLine("Students:        | 1 |");
                    Console.WriteLine("Teachers:        | 2 |\n");

                    switch (Console.ReadLine()) {
                        case "1":
                            Console.WriteLine("\n");
                            foreach (var person in PeopleManagement.GetInstance().SearchPerson(name, Type.STUDENT)) {
                                Console.WriteLine(person.ToString());
                            }
                        break;
                        
                        case "2":
                            Console.WriteLine("\n");
                            foreach (var person in PeopleManagement.GetInstance().SearchPerson(name, Type.TEACHER)) {
                                Console.WriteLine(person.ToString());
                            }
                        break;
                        
                        default:
                            Console.WriteLine("\nInvalid Input\n\n");
                        break;
                    }
                break;

                case "q":
                    Environment.Exit(1);
                break;

                default:
                    Console.WriteLine("\nInvalid Input\n\n");
                    break;
            }
        }
    }
}
