namespace console_schoolmanagement;

using lib_schoolmanagement;

class Program {
    static void Main(string[] args) {
        while(true) {
            Console.WriteLine("__________________________________________\n");
            Console.WriteLine("The following commands are available:\n");
            Console.WriteLine("Quit:                | q |\n");

            switch (Console.ReadLine()) {
                case "q":
                    Environment.Exit(1);
                    break;

                default:
                    Console.WriteLine("test");
                    break;
            }
        }
    }
}
