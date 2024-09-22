// the menu
using LibraryManagmentSystem.User;

while (true)

{   // menu main page
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("*********************************************");
    Console.WriteLine("* Welcome to Library Management System demo *");
    Console.WriteLine("*********************************************");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("Please choose your Role by entering the options number:\n");
    Console.WriteLine("(1)Manager\n(2)Librarian\n(3)Member\n");
    Console.WriteLine("-----------------------------------------------------------\n");
    int roleNo = int.Parse(Console.ReadLine());
    Console.Clear();

    // Creating lists of members, managers and users
    List<Manager> managers = new List<Manager>();
    List<Member> members = new List<Member>();
    List<User> users = new List<User>();

    // Saving some members, managers and users
    Member member = new Member("mohammad", "hassanpor", "09152086445", Gender.Male, DateTime.Now);
    members.Add(member);
    Manager manager = new Manager("mohammad", "kamel", "09151234567", Gender.Male, 200000.0);
    managers.Add(manager);
    User user = new User("kave", "akbarzade", "09293482343", Gender.Male);
    users.Add(user);
    
    switch (roleNo)
    {
        case 1:
            Console.WriteLine("Please choose one of the menu option by entering the number:");
            //printing Funcions
            Console.WriteLine("(1)search\n(2)\n(3)\n(4)\n(5)\n(6)\n(7)\n(8)\n(9)exit\n");
            Console.WriteLine("-----------------------------------------------------------\n");
            int input1 = int.Parse(Console.ReadLine());
            break;

        case 2:
            Console.WriteLine("Please choose one of the menu option by entering the number:");
            //printing Funcions
            Console.WriteLine("(1)\n(2)\n(3)\n(4)\n(5)\n(6)\n(7)\n(8)\n(9)exit\n");
            Console.WriteLine("-----------------------------------------------------------\n");
            int input2 = int.Parse(Console.ReadLine());
            break;

        case 3:
            // printing Funcions
            Console.WriteLine("(1)Search by book name\n(2)Search by author\n(3)exit\n");
            Console.WriteLine("-----------------------------------------------------------\n");
            int input3 = int.Parse(Console.ReadLine());
            break;
            switch (input3)
            {
                case 1:
                    Console.WriteLine("Please enter the book name that you are looking for:\n");
                    string bookName = Console.ReadLine();
                    string searchBookResult = member.search(bookName,"");
                    Console.WriteLine(searchBookResult);
                    break;
                case 2:
                    Console.WriteLine("Please enter the author name that you are looking for:\n");
                    string authorName = Console.ReadLine();
                    string searchAuthorResult = member.search("",authorName);
                    Console.WriteLine(searchAuthorResult);
                    break;
                case 3:
                    return;
                    break;
            }

        default:
            Console.WriteLine("You have entered a number out of list please try again\n");
            break;
    }
}