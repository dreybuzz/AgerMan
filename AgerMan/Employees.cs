using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AgerMan
{
    internal class Employees
    {
        public List<Employee> EmployeesList { get; set; } = new List<Employee>();

        public Employees()
        {

        }

        public Employees(List<Employee> employees)
        {
            foreach (Employee employee in employees)
            {
                EmployeesList.Add(employee);
            }
        }


        public bool Add(Employee employee)
        {
            try
            {
                this.EmployeesList.Add(employee);
                return true;
            }catch(Exception e)
            {
                return false;
            }
        }


        public Employee Find(int ID)
        {
            Employee employee = null;

            try
            {
                employee = EmployeesList.First(employee => employee.ID == ID);
            }
            catch (Exception e)
            {

            }

            return employee;
        }


        //public Employee FindAll(string key, string value, List<Employee> employees)
        //{
        //    Employee employee = null;    

        //    try
        //    {
        //        employee = employees.Where(employee => employee[key]==value);                              
        //    }
        //    catch (Exception e)
        //    {
                
        //    }

        //    return employee;
        //}




    }
}
