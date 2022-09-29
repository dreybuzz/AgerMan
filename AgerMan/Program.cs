using System;
using System.Diagnostics;
using System.Text;


namespace AgerMan
{

    class Program
    {



        static void Main()
        {
            Employees employees = new Employees();

            Employee devEmployee = new ();
            devEmployee.Username = "dev";
            devEmployee.Password = "dev";

            employees.Add(devEmployee);


            MenuItem exitMenuItem = new MenuItem(99, "Exit");
            MenuItem loginMenuItem = new MenuItem(1, "Login", () => LoginScreen(employees));
            MenuItem forgotCredentialsMenuItem = new MenuItem(2, "Forgot Credentials", () => Console.WriteLine("Forgot Password Activated"));
            MenuItem helpMenuItem = new MenuItem(3, "Help", () => Console.WriteLine("Help Activated")  );
            List<MenuItem> menuItems = new List<MenuItem>() { loginMenuItem, forgotCredentialsMenuItem, helpMenuItem, exitMenuItem };
            Menu mainMenu = new Menu(menuItems);
            mainMenu.ShowMenu("");
            Console.WriteLine("Welcome To AgerMan. Press 1 To Proceed To Login.");
            string userInput = Console.ReadLine();
            int parsedUserInput = ParseUserInput(userInput);


            while (parsedUserInput != exitMenuItem.Index)
            {
                parsedUserInput = ParseUserInput(userInput);
                try
                {
                    Console.Clear();
                    mainMenu.ShowMenu();
                    MenuItem menuItem = menuItems.First(menuItem => menuItem.Index == parsedUserInput);
                    menuItem.ItemAction();
                }
                catch (Exception e)
                {
                    Console.Clear();
                    mainMenu.ShowMenu();
                    Console.WriteLine("Invalid Input! Try Again");
                }
                userInput = Console.ReadLine();
                parsedUserInput = ParseUserInput(userInput);
            }
        }
        
       static int ParseUserInput(string input)
        {
            try
            {
                int parsedUserInput = int.Parse(input);
                return parsedUserInput;
            }catch(Exception e)
            {
                return -1;
            }
        }


       static bool PromptCredentials(Employees employees)
        {
            Console.Clear();
            Console.WriteLine("Login To AgerMan. Press ESC To Return To Main Menu\n");
            string inputKey;
            string username = "";
            string password;
            Console.WriteLine("Enter Username:");
            username = Console.ReadLine();
            Console.WriteLine("Enter Password:");
            password = GetPassword();

            return Authenticate(username, password, employees);
        }


       static string GetPassword()
        {
            StringBuilder input = new StringBuilder();
            while (true)
            {
                int x = Console.CursorLeft;
                int y = Console.CursorTop;
                ConsoleKeyInfo key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.Enter)
                {
                    Console.WriteLine();
                    break;
                }
                if (key.Key == ConsoleKey.Backspace && input.Length > 0)
                {
                    input.Remove(input.Length - 1, 1);
                    Console.SetCursorPosition(x - 1, y);
                    Console.Write(" ");
                    Console.SetCursorPosition(x - 1, y);
                }
                else if (key.KeyChar < 32 || key.KeyChar > 126)
                {
                    Trace.WriteLine("Output suppressed: no key char"); //catch non-printable chars, e.g F1, CursorUp and so ...
                }
                else if (key.Key != ConsoleKey.Backspace)
                {
                    input.Append(key.KeyChar);
                    Console.Write("*");
                }
            }
            return input.ToString();
        }


       static void LoginScreen(Employees employees)
       {
            bool authenticated = false;
            while (!authenticated)
            {
                authenticated = PromptCredentials(employees);
            }
            Console.WriteLine("Authentication Successful");
        }


        static bool Authenticate(string username, string password, Employees employees) {
            try
            {
                Employee employee = employees.EmployeesList.First(employee => employee.Username == username && employee.Password == password);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}