using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MdMaker.Classes
{
    /// <summary>
    /// This class gets data from the config file.
    /// </summary>
    public class ConfigurationHandler
    {
        /// <summary>
        /// Gets the configuration from the bin file.
        /// </summary>
        /// <returns>The configuration XML as a string.</returns>
        /// <remarks>
        /// 
        /// This string will later be deserialized.
        /// 
        /// </remarks>
        public string GetConfiguration()
        {
            return File.ReadAllText(Path.Combine(Environment.CurrentDirectory, "config.xml"));
        }
    }
}
