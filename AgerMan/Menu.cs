using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgerMan
{
    class Menu
    {
        public List<MenuItem> MenuItems = new List<MenuItem>() { };
        public int Size { get; set; }

        public Menu()
        {

        }

        public Menu(List<MenuItem> menuItems)
        {
            foreach (MenuItem menuItem in menuItems)
            {
                this.MenuItems.Add(menuItem);
            }

        }

        public void AddItem(MenuItem menuItem)
        {
            this.MenuItems.Add(menuItem);
        }

        public void RemoveItem(MenuItem menuItem)
        {
            this.MenuItems.Remove(menuItem);
        }

        public List<MenuItem> GetMenuItems()
        {
            return this.MenuItems;
        }

        public void ShowMenu(string counterType = "default")
        {
            string counter;
            MenuItem menuItem;

            for (int i = 0; i < this.MenuItems.Count; i++)
            {
                menuItem = this.MenuItems[i];
                if (counterType == "default")
                {
                    counter = i.ToString();
                }else if (counterType == "index")
                {
                    counter = menuItem.Index.ToString();
                }
                else
                {
                    counter = "->";
                }
                Console.WriteLine("{0} {1} ", counter, menuItem.Title);
                Console.WriteLine();
            }



        }

    }
}
