using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace MdMaker.Classes
{
    /// <summary>
    /// Represents a markdown template, where the template lives, and where the complete template should be output.
    /// </summary>
    public class MarkDownTemplate
    {
        /// <summary>
        /// The title of the template file.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// The file path where the template exists.
        /// </summary>
        public string TemplatePath { get; set; }

        /// <summary>
        /// The file where the completed file is output.
        /// </summary>
        public string OutputPath { get; set; }

        /// <summary>
        /// The body of the markdown file.
        /// </summary>
        public string Body { get; set; }
    }
}
