// See https://aka.ms/new-console-template for more information
#region Super beginner stuff
/*string name = "Hailey";
string LastName = "Snell";
double height = 5.8;
bool isPermenant = false;*/
#endregion

#region More beginner stuff
/*Console.WriteLine("Name: " + name + " " + LastName);
Console.WriteLine("Height: " + height); 
Console.WriteLine("Is permenant employee?: " + isPermenant);
Console.WriteLine("What is your name?: ");
string theirname = Console.ReadLine();
Console.WriteLine("What is your last name?: ");
string theirLastName = Console.ReadLine();
Console.WriteLine("How old are you?: ");
int age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Where are you from?: ");
string city = Console.ReadLine();
Console.WriteLine("Hello, " + theirname + " " + theirLastName + " " + "who is " + age + " years old and from " + city + ".");*/
#endregion

#region Beginner mock bank app
Console.WriteLine("!! ~~~~~~~~~~~~ Welcome to Banking ~~~~~~~~~~~~~~~~~~~~ !!");

Console.WriteLine("1. Admin");
Console.WriteLine("2. Customer ");

int userType = Convert.ToInt32(Console.ReadLine());
#region Admin stuff
if (userType == 1)
{
    Console.WriteLine("Enter admin username: ");
    string adminUser = Console.ReadLine();
    Console.WriteLine("Enter admin password: ");
    string adminPass = Console.ReadLine();

    if (adminUser == "123" && adminPass == "123")
    {
        Console.Clear();
        int adminChoice = 0;
        Console.WriteLine("Welcome Admin");
        while (adminChoice != 6)
        {
            if (adminChoice != 0)
            {
                Console.WriteLine("Would you like to do something else?");
            }
            Console.WriteLine("1. Create New Account");
            Console.WriteLine("2. Print All Account Statement");
            Console.WriteLine("3. Block an Account");
            Console.WriteLine("4. Delete Account");
            Console.WriteLine("5. Edit Account");
            Console.WriteLine("6. Exit");

            adminChoice = Convert.ToInt32(Console.ReadLine());

            switch (adminChoice)
            {
                case 1:
                    Console.WriteLine(" Thank you for opening a New Account");
                    break;
                case 2:
                    Console.WriteLine("Printing All the statements");
                    break;
                case 3:
                    Console.WriteLine("User Account Blocked ");
                    break;
                case 4:
                    Console.WriteLine("Account deleted");
                    break;
                case 5:
                    Console.WriteLine("Edit Account");
                    break;
                case 6:
                    Console.WriteLine("Thank you for Banking, see you soon");
                    break;
                default:
                    Console.WriteLine("Sorry Wrong Option");
                    break;
            }
        }
    }
    else
    {
        Console.WriteLine("Invalid credentials, try again.");
    }
}
#endregion

#region Customer Stuff
else
{
    Console.WriteLine("Enter customer username: ");
    string customerUser = Console.ReadLine();
    Console.WriteLine("Enter customer password: ");
    string customerPass = Console.ReadLine();
    if (customerUser == "12" && customerPass == "12")
    {
        int customerChoice = 0;
        Console.Clear();
        Console.WriteLine("Welcome Customer : Hailey ");
        while (customerChoice != 6)
        {
            if (customerChoice != 0)
            {
                Console.WriteLine("Would you like to do something else?");
            }
            Console.WriteLine("1. Widraw Funds ");
            Console.WriteLine("2. Deposit Funds ");
            Console.WriteLine("3. Wire / Transfer Funds ");
            Console.WriteLine("4. Request Statements ");
            Console.WriteLine("5. Change Password");
            Console.WriteLine("6. Exit");
            customerChoice = Convert.ToInt32(Console.ReadLine());
            switch (customerChoice)
            {
                case 1:
                    Console.WriteLine("Funds withdrawn");
                    break;
                case 2:
                    Console.WriteLine("Funds deposited");
                    break;
                case 3:
                    Console.WriteLine("Funds wired/transfered");
                    break;
                case 4:
                    Console.WriteLine("Statement requested");
                    break;
                case 5:
                    Console.WriteLine("Password changed");
                    break;
                case 6:
                    Console.WriteLine("Thank you for Banking, see you soon");
                    break;
                default:
                    Console.WriteLine("Sorry Wrong Option");
                    break;


            }
        }
    }
}
#endregion

#endregion


