using SimplexAvLib.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplexAvLib
{
    /// <summary>
    /// Elemento che contiente le info sul tipo di file 
    /// </summary>
    public class FileType
    {
        public string Extension {  get; set; }
        public string Description { get; set; }
        public FileContent TypeOfContent { get; set; }
        public FileType(string extension, string description, FileContent typeOfContent)
        {
            this.Extension = extension;
            this.Description = description;
            this.TypeOfContent = typeOfContent;
        }
    }
}
