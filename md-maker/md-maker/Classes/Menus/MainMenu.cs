using System;
using System.Collections.Generic;
using System.Text;

namespace md_maker.Classes.Menus
{
    /// <summary>
    /// The main menu for the application
    /// </summary>
    /// <remarks>
    /// 
    /// The main menu only writes to the console and takes in user input. 
    /// 
    /// Little to no logic should be implented here. 
    /// 
    /// </remarks>
    class MainMenu
    {
        public void Start()
        {
            DisplayGreeting();
        }

        private void DisplayGreeting()
        {
            Console.WriteLine("Welcome to Markdown Maker!");
            Console.WriteLine("Getting templates from config...");


        }
    }
}
