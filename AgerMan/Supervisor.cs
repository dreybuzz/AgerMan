using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgerMan
{
    internal class Supervisor:Employee
    {

        public Supervisor()
        {
            this.DashboardMenu = CreateMenu();  
        }


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
