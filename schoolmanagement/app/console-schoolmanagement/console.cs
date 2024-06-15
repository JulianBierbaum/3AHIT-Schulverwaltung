namespace console_schoolmanagement;

using lib_schoolmanagement;
using lib_schoolmanagement.peopleManagement;

class Program {
    static void Main(string[] args) {
        PeopleManagement.GetInstance().AddStudent("testStudent", "3AHIT");
        PeopleManagement.GetInstance().AddTeacher("testTeacher", ["SEW", "INSY"]);

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
