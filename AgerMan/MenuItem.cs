using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgerMan
{
    class MenuItem
    {
        // Member Variables
        public int Index { get; set; } = -1;
        public string Title { get; set; } = "";
        public ConsoleColor ForegroundColor { get; set; } = ConsoleColor.White;
        public Action ItemAction { get; set; } = () => { };
        
        
         // Constructors
        public MenuItem()
        {

        }

        public MenuItem(int index, string title)
        {
            this.Index = index;
            this.Title = title;
        }

        public MenuItem(int index, string title, Action ItemAction)
        {
            this.Index = index;
            this.Title = title;
            this.ItemAction = ItemAction;
        }
       
    }
}
