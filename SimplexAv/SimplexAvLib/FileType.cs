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
        /// <summary>
        /// Estensione del file
        /// </summary>
        public string Extension {  get; set; }
        /// <summary>
        /// Descrizione del formato, utilizzato anche nella OpenFileDialog e SaveFileDialog
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Tipo del contenuto del file : audio, video
        /// </summary>
        public FileContent TypeOfContent { get; set; }
        /// <summary>
        /// Costruttore della classe
        /// </summary>
        /// <param name="extension">Estensione del file</param>
        /// <param name="description">Descrizione del formato, usata anche nel Open/SaveFileDialog</param>
        /// <param name="typeOfContent">Tipo del contenuto del file : audio, video</param>
        public FileType(string extension, string description, FileContent typeOfContent)
        {
            this.Extension = extension;
            this.Description = description;
            this.TypeOfContent = typeOfContent;
        }
    }
}
