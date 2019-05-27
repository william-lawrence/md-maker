using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace MdMaker.Classes.Menus
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

            ConfigurationHandler configurationHandler = new ConfigurationHandler();

            string configuration = configurationHandler.GetConfiguration();

            StringReader configStringReader = new StringReader(configuration);

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<MarkDownTemplate>), new XmlRootAttribute("config"));

            List<MarkDownTemplate> markDownTemplateList = (List<MarkDownTemplate>)xmlSerializer.Deserialize(configStringReader);

            foreach (MarkDownTemplate template in markDownTemplateList)
            {
                Console.WriteLine(template.Title);
            }
        }
    }
}
