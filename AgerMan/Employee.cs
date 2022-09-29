using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgerMan
{
    internal class Employee
    {
        public int ID { get; } = new Random().Next(100000, 9999999);

        public string FirstName { get; set; } = "";

        public string MiddleName { get; set; } = "";

        public string LastName { get; set; } = "";

        public string FullName { get; } = "";

        public string Username { get; set; } = "";

        public string Password { get; set; } = "";

        public DateTime DateOfBirth { get; set; } = DateTime.Now;

        public int Age { get; } = 0;

        public float Salary { get; set; } = 0;

        public List<Team> Teams { get; set; } = new List<Team>();

        public DateTime StartDate { get; set; } =  DateTime.Now;

        public int TotalWorkDays { get; } = 0;

        public Department Department { get; set; }  = new Department();

        public Menu DashboardMenu = CreateMenu();


        private static Menu CreateMenu()
        {
            Menu menu = new Menu();
            MenuItem clockIn = new MenuItem(1, "Clock In");
            MenuItem clockOut = new MenuItem(2, "Clock Out");
            MenuItem profile = new MenuItem(3, "Profile");
            MenuItem viewDept = new MenuItem(4, "Department");
            MenuItem viewTeams = new MenuItem(5, "Teams");
            MenuItem reports = new MenuItem(6, "Reports & Requests");
            MenuItem logout = new MenuItem(99, "Log Out");
            return menu;
        }
    }

   
}
